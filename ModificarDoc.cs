using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace Sistema_Oaxaca
{
    public partial class ModificarDoc : Form
    {

        int NuevoId;
        int VersionId;
        MasterAPI MAPI = new MasterAPI();


        public ModificarDoc()
        {
            InitializeComponent();
            TabNuevoDoc.TabPages.Remove(vaginado);
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ModificarDoc_Load(object sender, EventArgs e)
        {
            try
            {
                var deviceManager = new DeviceManager();

                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) //Lista de Dispositivos
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) //Saltar si no es escaner
                    {
                        continue;
                    }
                    comboBox1.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                    //     comboBox1.Items.Add(deviceManager.DeviceInfos[i].Properties["Nombre"].get_Value());

                    //   textBox2.Text = deviceManager.DeviceInfos[i].Properties.;
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void InicioMod_Click(object sender, EventArgs e)
        {
            Home.ActiveForm.Show();
            ModificarDoc.ActiveForm.Close();
        }

        private void NextDocNuevo_Click(object sender, EventArgs e)
        {
            NuevoId = 13;
            ObjTerreno ElTerreno = MAPI.GetTerrenoById(NuevoId);


            VersionId = ElTerreno.LastVersion + 1;
            string Cedente = NombreCedente.Text;
            string Biblioteca = Application.StartupPath + @"\Biblioteca";
            string CarpCedente = Application.StartupPath + @"\Biblioteca\" + NuevoId;
            string CarpetaVersion = Application.StartupPath + @"\Biblioteca\" + NuevoId + @"\"+ VersionId + @"\";

            try
            {

                if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1 ||  Colonias.Text == "" || Hectareas.Text == "")
                {
                    MessageBox.Show("Llene todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    try
                    {
                        int temp = Convert.ToInt32(Hectareas.Text);
                
                        //Imagenes de documentos escaneados en pestaña de escanear
                        listView1.View = View.Details;
                        listView1.Columns.Add("Documentos Escaneados", 700, HorizontalAlignment.Center);

             
                        Directory.CreateDirectory(CarpetaVersion);
                       

                  
                        VerTerreno version = new VerTerreno();
                        List<VerTerreno> versiones = ElTerreno.Versiones;

                        
                        ElTerreno.LastVersion = VersionId;
                        version.Cedentes = listBox1.Items.Cast<String>().ToList();
                        version.Beneficiarios = listBox2.Items.Cast<String>().ToList();
                        version.Fecha = dateTimePicker1.Value.ToString();
                        version.Hectareas = Hectareas.Text;
                        version.Paraje = Colonias.Text;
                        version.VersionID = VersionId;
                     

                        versiones.Add(version);
                        ElTerreno.Versiones = versiones;
                        string result = JsonConvert.SerializeObject(ElTerreno);
                        File.WriteAllText(CarpCedente + @"\terreno.json", result);
                         MAPI.RegVersionTerreno(version, ElTerreno);
                        TabNuevoDoc.TabPages.Remove(chicodo);

                        TabNuevoDoc.TabPages.Insert(0, vaginado);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Introduzca valor numerico en Hectareas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FinNuevoDoc_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string TextoListBox1 = NombreCedente.Text;
            int a = 0;

            if (NombreCedente.Text == "")
            {

                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona o introduce un Cedente por favor");
                }
            }

            else
            {
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString() == TextoListBox1)
                    {
                        a = 1;
                    }
                    else
                    {
                        a = 0;
                    }
                }
                if (a == 1)
                {
                    MessageBox.Show("Cedente ya existente");
                    int y = listBox1.FindString(TextoListBox1);
                    listBox1.SetSelected(y, true);
                }
                else
                {
                    int x = 0;
                    Int32.TryParse(listBox1.Items.Count.ToString(), out x);
                    listBox1.Items.Add(TextoListBox1);
                    listBox1.SetSelected(x, true);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string TextoListBox2 = NombreBeneficiario.Text;
            int b = 0;

            if (NombreBeneficiario.Text == "")
            {

                if (listBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona o introduce un Cedente por favor");
                }
            }

            else
            {
                foreach (var item in listBox2.Items)
                {
                    if (item.ToString() == TextoListBox2)
                    {
                        b = 1;
                    }
                    else
                    {
                        b = 0;
                    }
                }
                if (b == 1)
                {
                    MessageBox.Show("Cedente ya existente");
                    int y = listBox2.FindString(TextoListBox2);
                    listBox2.SetSelected(y, true);
                }
                else
                {
                    int x = 0;
                    Int32.TryParse(listBox2.Items.Count.ToString(), out x);
                    listBox2.Items.Add(TextoListBox2);
                    listBox2.SetSelected(x, true);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void Escanear_Click(object sender, EventArgs e)
        {

        }
    }
}
