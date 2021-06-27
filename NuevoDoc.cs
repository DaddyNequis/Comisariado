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
        int NuevoId;
        MasterAPI MAPI = new MasterAPI();
        public NuevoDoc()
        {
            InitializeComponent();
        }
 
        private void NextDocNuevo_Click(object sender, EventArgs e)
        {
            NuevoId = MAPI.GetNewId();

            string Cedente = NombreCedente.Text;
            string Biblioteca = Application.StartupPath + @"\Biblioteca";
            string CarpCedente = Application.StartupPath + @"\Biblioteca\ " + NuevoId;
            string CarpetaVersion = Application.StartupPath + @"\Biblioteca\ " + NuevoId + @"\1\ ";
            try
            {
                if(Directory.Exists(Biblioteca))
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
                List <VerTerreno> versiones = new List<VerTerreno>();

                terreno.DocumentID = NuevoId;
                terreno.LastVersion = 1;
                version.Cedentes = listBox1.Items.Cast<String>().ToList(); 
                version.Beneficiarios = listBox2.Items.Cast<String>().ToList();
                version.Fecha = monthCalendar1.ToString();
                version.Hectareas = textBox2.Text;
                version.Paraje = Colonias.Text;
                version.VersionID = 1;
                versiones.Add(version);
                terreno.Versiones = versiones;
                string result = JsonConvert.SerializeObject(terreno);
                File.WriteAllText(CarpCedente + @"\terreno.json", result);
                MAPI.RegistrarTerreno(version, terreno);
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
            string CarpetaVersion = Application.StartupPath + @"\Biblioteca\ " + NuevoId + @"\1\ ";
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

                var dispositivo = EscanerDisponible.Connect(); // Conectarse al escaner disponible

                var ItemEscaner = dispositivo.Items[1]; // Seleccionar el escaner

                var imgFile = (ImageFile)ItemEscaner.Transfer(FormatID.wiaFormatJPEG);  // Conseguir imagen JPG y guardarla en variable
                
                String filename = Directory.GetFiles(CarpetaVersion, "*", SearchOption.TopDirectoryOnly).Length.ToString();
                var Ubicacion = CarpetaVersion + filename + @".jpg"; // Guardar en la carpeta del nuevo cedente

                imgFile.SaveFile(Ubicacion);

                ImagenEscaneada.ImageLocation = Ubicacion;

            }
            catch(COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InicioNuev_Click(object sender, EventArgs e)
        {
            Home.ActiveForm.Show();
            NuevoDoc.ActiveForm.Close();
        }

        private void FinNuevoDoc_Click(object sender, EventArgs e)
        {
            
         

        }

        private void NuevoDoc_Load_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
