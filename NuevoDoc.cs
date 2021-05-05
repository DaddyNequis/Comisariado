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

namespace Sistema_Oaxaca
{
    public partial class NuevoDoc : Form
    {
        public NuevoDoc()
        {
            InitializeComponent();
        }

        private void NextDocNuevo_Click(object sender, EventArgs e)
        {
            string Cedente = NombreCedente.Text;
            string Biblioteca = Application.StartupPath + @"\Biblioteca";
            string CarpCedente = Application.StartupPath + @"\Biblioteca\ " + Cedente;

            try
            {
                if(Directory.Exists(Biblioteca))
                {
                    Directory.CreateDirectory(CarpCedente);
                }
                else
                {
                    Directory.CreateDirectory(Biblioteca);
                    Directory.CreateDirectory(CarpCedente);
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

            try
            {
                var deviceManager = new DeviceManager ();

                for (int i=1; i <= deviceManager.DeviceInfos.Count; i++) //Lista de Dispositivos
                {
                    if(deviceManager.DeviceInfos[i].Type!=WiaDeviceType.ScannerDeviceType) //Saltar si no es escaner
                    {
                        continue;
                    }
                    ListaDisp.Items.Add(deviceManager.DeviceInfos[i].Properties["Nombre"].get_Value());
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Escanear_Click(object sender, EventArgs e)
        {
            string Cedente = NombreCedente.Text;
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

                var Ubicacion = Application.StartupPath + @"\Biblioteca\ " + Cedente + @"\ DOCUMENTO " + Cedente; // Guardar en la carpeta del nuevo cedente

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
    }
}
