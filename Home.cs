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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NuevoDoc VentanaNuevoDoc = new NuevoDoc();
            VentanaNuevoDoc.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Form1 NuForm = new Form1();
            NuForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ModificarDoc VentanaModificarDoc = new ModificarDoc();
            VentanaModificarDoc.ShowDialog();
        }

        private void Constanciaspng_Click(object sender, EventArgs e)
        {
            ConstanciaDoc VentanaConstanciaDoc = new ConstanciaDoc();
            VentanaConstanciaDoc.ShowDialog();

        }

        private void LibreriaDocPng_Click(object sender, EventArgs e)
        {
           Libreria VentanaLibreria = new Libreria();
            VentanaLibreria.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            NuevoDoc VentanaNuevoDoc = new NuevoDoc();
            VentanaNuevoDoc.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Libreria VentanaLibreria = new Libreria();
            VentanaLibreria.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ConstanciaDoc VentanaConstanciaDoc = new ConstanciaDoc();
            VentanaConstanciaDoc.ShowDialog();
        }

        private void Medicionespng_Click(object sender, EventArgs e)
        {
            MedTerrenos VentanaMedTerrenos = new MedTerrenos();
            VentanaMedTerrenos.ShowDialog();
        }
    }
}
