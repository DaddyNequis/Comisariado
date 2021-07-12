using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Sistema_Oaxaca
{
  
    public partial class MedTerrenos : Form
    {

        public MedTerrenos()
        {
            InitializeComponent();
            webView21.Source = new Uri("https://www.google.com.mx/maps/");
        }


        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void MedTerrenos_Load(object sender, EventArgs e)
        {

        }

        private void MedTerrenos_FormClosing(object sender, FormClosingEventArgs e)
        {
            webView21.Hide();

        }
    }
}
