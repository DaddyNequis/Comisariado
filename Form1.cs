using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Sistema_Oaxaca.MasterAPI;
namespace Sistema_Oaxaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        MasterAPI MAPI = new MasterAPI();



        private void button1_Click(object sender, EventArgs e)
        {
            // MAPI.LoadDocuments();
            Terrenos Terr = new Terrenos();

            List <Terrenos> yeah = new List<Terrenos>();

            yeah.Add(Terr);
            yeah.Add(Terr);
            yeah.Add(Terr);

            string  result = JsonConvert.SerializeObject(yeah);

            textBox1.Text = result;



        }
    }
}
