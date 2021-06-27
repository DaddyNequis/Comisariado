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
            ListaTerrenos lista = new ListaTerrenos();
            lista.ListaTrerrenos = yeah;
            lista.count = yeah.Count();


            string  result = JsonConvert.SerializeObject(lista);

            textBox1.Text = result;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ObjTerreno Terr = new ObjTerreno();
            VerTerreno Version = new VerTerreno();
            List <VerTerreno> Versiones= new List<VerTerreno>();

            Versiones.Add(Version);
            Terr.Versiones = Versiones;


            string result = JsonConvert.SerializeObject(Terr);

            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"Biblioteca\biblioteca.json");
            ListaTerrenos lista;
            lista = JsonConvert.DeserializeObject<ListaTerrenos>(text);
            textBox1.Text = lista.count.ToString();
        }
    }
}
