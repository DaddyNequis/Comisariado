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
            NuevoDoc.ActiveForm.Close();
        }
    }
}
