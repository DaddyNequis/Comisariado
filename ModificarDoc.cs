using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Oaxaca
{
    public partial class ModificarDoc : Form
    {

        int NuevoId;
        MasterAPI MAPI = new MasterAPI();


        public ModificarDoc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ModificarDoc_Load(object sender, EventArgs e)
        {

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
            //NuevoId = MAPI.GetNewId();

            //string Cedente = NombreCedente.Text;
            //string Biblioteca = Application.StartupPath + @"\Biblioteca";
            //string CarpCedente = Application.StartupPath + @"\Biblioteca\" + NuevoId;
            //string CarpetaVersion = Application.StartupPath + @"\Biblioteca\" + NuevoId + @"\1\ ";

            //try
            //{

            //    if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1 || SolarTerreno.Text == "" || Colonias.Text == "" || Hectareas.Text == "")
            //    {
            //        MessageBox.Show("Llene todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    else
            //    {
            //        try
            //        {
            //            int temp = Convert.ToInt32(Hectareas.Text);
            //            TabNuevoDoc.TabPages.Remove(Registro);
            //            TabNuevoDoc.TabPages.Insert(0, EscanearTab);
            //            //Imagenes de documentos escaneados en pestaña de escanear
            //            listView1.View = View.Details;
            //            listView1.Columns.Add("Documentos Escaneados", 700, HorizontalAlignment.Center);

            //            if (Directory.Exists(Biblioteca))
            //            {
            //                Directory.CreateDirectory(CarpCedente);
            //                Directory.CreateDirectory(CarpetaVersion);
            //            }
            //            else
            //            {
            //                Directory.CreateDirectory(Biblioteca);
            //                Directory.CreateDirectory(CarpCedente);
            //                Directory.CreateDirectory(CarpetaVersion);
            //            }

            //            ObjTerreno terreno = new ObjTerreno();
            //            VerTerreno version = new VerTerreno();
            //            List<VerTerreno> versiones = new List<VerTerreno>();

            //            terreno.DocumentID = NuevoId;
            //            terreno.LastVersion = 1;
            //            version.Cedentes = listBox1.Items.Cast<String>().ToList();
            //            version.Beneficiarios = listBox2.Items.Cast<String>().ToList();
            //            version.Fecha = dateTimePicker1.Value.ToString();
            //            version.Hectareas = Hectareas.Text;
            //            version.Paraje = Colonias.Text;
            //            version.VersionID = 1;
            //            version.Tipo = SolarTerreno.Text;

            //            versiones.Add(version);
            //            terreno.Versiones = versiones;
            //            string result = JsonConvert.SerializeObject(terreno);
            //            File.WriteAllText(CarpCedente + @"\terreno.json", result);
            //            MAPI.RegistrarTerreno(version, terreno);

            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Introduzca valor numerico en Hectareas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }
    }
}
