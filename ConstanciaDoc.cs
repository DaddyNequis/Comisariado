using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Sistema_Oaxaca
{
    public partial class ConstanciaDoc : Form
    {
        public ConstanciaDoc()
        {
            InitializeComponent();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string CONSTANCIAS = Application.StartupPath + @"\Constancias";
            string Source = Application.StartupPath+ @"\CONUSODESUELO.docx";
            string Dest = Application.StartupPath + @"\Constancias\CONUSODESUELO.docx";

            try
            {
                if (Directory.Exists(CONSTANCIAS))
                {
                    File.Copy(Source, Dest,true);
                    Process.Start(Application.StartupPath+ @"\Constancias\CONUSODESUELO.docx");
                }
                else
                {
                    Directory.CreateDirectory(CONSTANCIAS);
                    File.Copy(Source, Dest,true);
                    Process.Start(Application.StartupPath+ @"\Constancias\CONUSODESUELO.docx");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        

        private void InicioMod_Click(object sender, EventArgs e)
        {
            Home.ActiveForm.Show();
            ConstanciaDoc.ActiveForm.Close();
        }

        private void ConstanciaDoc_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string CONSTANCIAS = Application.StartupPath + @"\Constancias";
            string Source = Application.StartupPath + @"\CONCULTIVO.docx";
            string Dest = Application.StartupPath + @"\Constancias\CONCULTIVO.docx";

            try
            {
                if (Directory.Exists(CONSTANCIAS))
                {
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONCULTIVO.docx");
                }
                else
                {
                    Directory.CreateDirectory(CONSTANCIAS);
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONCULTIVO.docx");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string CONSTANCIAS = Application.StartupPath + @"\Constancias";
            string Source = Application.StartupPath + @"\CONPASTOREO.docx";
            string Dest = Application.StartupPath + @"\Constancias\CONPASTOREO.docx";

            try
            {
                if (Directory.Exists(CONSTANCIAS))
                {
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONPASTOREO.docx");
                }
                else
                {
                    Directory.CreateDirectory(CONSTANCIAS);
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONPASTOREO.docx");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string CONSTANCIAS = Application.StartupPath + @"\Constancias";
            string Source = Application.StartupPath + @"\CONSOLAR.docx";
            string Dest = Application.StartupPath + @"\Constancias\CONSOLAR.docx";

            try
            {
                if (Directory.Exists(CONSTANCIAS))
                {
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONSOLAR.docx");
                }
                else
                {
                    Directory.CreateDirectory(CONSTANCIAS);
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONSOLAR.docx");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string CONSTANCIAS = Application.StartupPath + @"\Constancias";
            string Source = Application.StartupPath + @"\CONTARRENDAMIENTO.docx";
            string Dest = Application.StartupPath + @"\Constancias\CONTARRENDAMIENTO.docx";

            try
            {
                if (Directory.Exists(CONSTANCIAS))
                {
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONTARRENDAMIENTO.docx");
                }
                else
                {
                    Directory.CreateDirectory(CONSTANCIAS);
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONTARRENDAMIENTO.docx");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string CONSTANCIAS = Application.StartupPath + @"\Constancias";
            string Source = Application.StartupPath + @"\CONJORNALERO.docx";
            string Dest = Application.StartupPath + @"\Constancias\CONJORNALERO.docx";

            try
            {
                if (Directory.Exists(CONSTANCIAS))
                {
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONJORNALERO.docx");
                }
                else
                {
                    Directory.CreateDirectory(CONSTANCIAS);
                    File.Copy(Source, Dest, true);
                    Process.Start(Application.StartupPath + @"\Constancias\CONJORNALERO.docx");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
