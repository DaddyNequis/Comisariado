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
    public partial class CargandoForm : Form
    {
        public CargandoForm()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }
    }
}
