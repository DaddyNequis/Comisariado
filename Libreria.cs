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
    public partial class Libreria : Form
    {
        public Libreria()
        {
            InitializeComponent();
        }


        MasterAPI MAPI = new MasterAPI();


      


        public void loadList()
        {

            List<Terrenos> terrenos =  MAPI.GetTerrenos();

            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(Terrenos));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (Terrenos item in terrenos)
            {
                for (int i = 0; i < values.Length; i++)
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;
                table.Rows.Add(values);
            }
            dataGridView1.DataSource = table;



        }

    


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduzca nombre de Cedente");
            }
            else
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadList();
        }

        private void Libreria_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void buttonver_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BENEFICIARIOBOX.Text == "")
            {
                MessageBox.Show("Introduzca nombre de Beneficiario");
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Selecciona un Tipo de terreno");
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PARAJEBOX.Text == "")
            {
                MessageBox.Show("Introduzca un paraje");
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FECHA.Text == "")
            {
                MessageBox.Show("Introduzca un paraje");
            }
            else
            {

            }
        }
    }
}
