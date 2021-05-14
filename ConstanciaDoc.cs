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
    public partial class ConstanciaDoc : Form
    {
        public ConstanciaDoc()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void InicioMod_Click(object sender, EventArgs e)
        {
            Home.ActiveForm.Show();
            ConstanciaDoc.ActiveForm.Close();
        }
    }
}
