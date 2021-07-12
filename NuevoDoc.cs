using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WIA;
using System.Runtime.InteropServices;
using Newtonsoft.Json;


namespace Sistema_Oaxaca
{
    public partial class NuevoDoc : Form
    {
        CargandoForm Cargando;
        int NuevoId;
        MasterAPI MAPI = new MasterAPI();
        public NuevoDoc()
        {
            InitializeComponent();
            TabNuevoDoc.TabPages.Remove(EscanearTab);
            SolarTerreno.Items.Add("Solar");
            SolarTerreno.Items.Add("Terreno");
        }

        private void NextDocNuevo_Click(object sender, EventArgs e)
        {

            NuevoId = MAPI.GetNewId();

            string Cedente = NombreCedente.Text;
            string Biblioteca = Application.StartupPath + @"\Biblioteca";
            string CarpCedente = Application.StartupPath + @"\Biblioteca\" + NuevoId;
            string CarpetaVersion = Application.StartupPath + @"\Biblioteca\" + NuevoId + @"\1\ ";

            try
            {

                if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1 || SolarTerreno.Text == "" || Colonias.Text == "" || Hectareas.Text == "")
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

                        if (Directory.Exists(Biblioteca))
                        {
                            Directory.CreateDirectory(CarpCedente);
                            Directory.CreateDirectory(CarpetaVersion);
                        }
                        else
                        {
                            Directory.CreateDirectory(Biblioteca);
                            Directory.CreateDirectory(CarpCedente);
                            Directory.CreateDirectory(CarpetaVersion);
                        }

                        ObjTerreno terreno = new ObjTerreno();
                        VerTerreno version = new VerTerreno();
                        List<VerTerreno> versiones = new List<VerTerreno>();

                        terreno.DocumentID = NuevoId;
                        terreno.LastVersion = 1;
                        version.Cedentes = listBox1.Items.Cast<String>().ToList();
                        version.Beneficiarios = listBox2.Items.Cast<String>().ToList();
                        version.Fecha = dateTimePicker1.Value.ToString();
                        version.Hectareas = Hectareas.Text;
                        version.Paraje = Colonias.Text;
                        version.VersionID = 1;
                        version.Tipo = SolarTerreno.Text;

                        versiones.Add(version);
                        terreno.Versiones = versiones;
                                               string result = JsonConvert.SerializeObject(terreno);
                        File.WriteAllText(CarpCedente + @"\terreno.json", result);
                        MAPI.RegistrarTerreno(version, terreno);
                        TabNuevoDoc.TabPages.Remove(Registro);
                        TabNuevoDoc.TabPages.Insert(0, EscanearTab);
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



        private void ListaDisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevoDoc_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    var deviceManager = new DeviceManager();

            //    for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) //Lista de Dispositivos
            //    {
            //        if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) //Saltar si no es escaner
            //        {
            //            continue;
            //        }
            //        ListaDisp.Items.Add(deviceManager.DeviceInfos[i].Properties["Nombre"].get_Value());
            //    }
            //}
            //catch (COMException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void Escanear_Click(object sender, EventArgs e)
        {
            string Cedente = NombreCedente.Text;
            string CarpetaVersion = Application.StartupPath + @"\Biblioteca\" + NuevoId + @"\1\ ";
            try
            {



                var deviceManager = new DeviceManager();

                DeviceInfo EscanerDisponible = null;

                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) //Lista de Dispositivos
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) //Saltar si no es escaner
                    {
                        continue;
                    }

                    EscanerDisponible = deviceManager.DeviceInfos[i];

                    break;
                }

                Show();

                var dispositivo = EscanerDisponible.Connect(); // Conectarse al escaner disponible

                var ItemEscaner = dispositivo.Items[1]; // Seleccionar el escaner

                var imgFile = (ImageFile)ItemEscaner.Transfer(FormatID.wiaFormatJPEG);  // Conseguir imagen JPG y guardarla en variable

                String filename = Directory.GetFiles(CarpetaVersion, "*", SearchOption.TopDirectoryOnly).Length.ToString();
                var Ubicacion = CarpetaVersion + filename + @".jpg"; // Guardar en la carpeta del nuevo cedente

                imgFile.SaveFile(Ubicacion);

                ImagenEscaneada.ImageLocation = Ubicacion;

                Hide();

                ObtImagenes();

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Show() //Enseñar pantalla de cargando
        {
            CargandoForm VentanaLoading = new CargandoForm();
            VentanaLoading.Show();
        }

        private void Hide()
        {
            CargandoForm VentanaLoading = new CargandoForm();
            VentanaLoading.Close();
        }

        private void InicioNuev_Click(object sender, EventArgs e)
        {
            Home.ActiveForm.Show();
            NuevoDoc.ActiveForm.Close();
        }

        private void FinNuevoDoc_Click(object sender, EventArgs e)
        {
            Home.ActiveForm.Show();
            NuevoDoc.ActiveForm.Close();
        }

        private void NuevoDoc_Load_1(object sender, EventArgs e)
        {
            NuevoId = 5;




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
        private void NombreCedente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 250 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void NombreBeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 250 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void Colonias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 250 && e.KeyChar <= 255))
            {
                MessageBox.Show("Introduzca solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Preview de Imagen Seleccionada

            foreach (ListViewItem itm in listView1.SelectedItems)
            {
                int imgIndex = itm.ImageIndex;
                this.ImagenEscaneada.Image = listView1.SmallImageList.Images[imgIndex];
            }
        }

        private void ObtImagenes()
        {
            //Guardar Imagenes
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(130, 150);
            //Cargar Imagenes
            String[] paths = { };
            string Ubi = Application.StartupPath + @"\Biblioteca\" + NuevoId + @"\1";
            paths = Directory.GetFiles(Ubi, "*.jpg",SearchOption.TopDirectoryOnly);
            try
            {
                foreach(String path in paths)
                {
                    imgs.Images.Add(Image.FromFile(path));
                }
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Mostrar Imagenes
            listView1.SmallImageList = imgs;
            listView1.LargeImageList = imgs;
            int a= paths.Length - 1;
            for (int i= 0; i<=a;i++)    
            {
                int d = i + 1;
                string b = d.ToString();
                listView1.Items.Add(b, i);
            }

      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtImagenes();
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
    }
}
