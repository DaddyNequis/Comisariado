using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Oaxaca
{
    class MasterAPI
    {

         class Documento
        {
            Int16 DID;
            String Cedente;
            String Beneficiario;
            String Tipo;
            String Fecha;
            List<String> Cedentes;
            List<String> Beneficiarios;
            String Hectareas;
            String Paraje;



        }

        public String DirBiblioteca = Application.StartupPath + @"\Biblioteca";



        public List<Terrenos> GetTerrenos()
        {

            string text = System.IO.File.ReadAllText(@"Biblioteca\biblioteca.json");
            ListaTerrenos lista;
            lista = JsonConvert.DeserializeObject<ListaTerrenos>(text);
            List<Terrenos> terrenos = lista.ListaTrerrenos;



            return terrenos;
        }
        public Boolean RegistrarTerreno(VerTerreno verterreno, ObjTerreno terreno)
        {
           
            string text = System.IO.File.ReadAllText(@"Biblioteca\biblioteca.json");
            ListaTerrenos lista;
            lista = JsonConvert.DeserializeObject<ListaTerrenos>(text);
            List<Terrenos> terrenos = lista.ListaTrerrenos;
            Terrenos lterreno = new Terrenos();
            lterreno.Beneficiarios = verterreno.Beneficiarios;
            lterreno.Tipo = verterreno.Tipo;
            lterreno.Fecha = verterreno.Fecha;
            lterreno.Cedentes = verterreno.Cedentes;
            lterreno.Hectareas = verterreno.Hectareas;
            lterreno.Paraje = verterreno.Paraje;
            lterreno.DocumentID = terreno.DocumentID;
            terrenos.Add(lterreno);


             lista = new ListaTerrenos();
            lista.ListaTrerrenos = terrenos;
            lista.count = terrenos.Count();


            string result = JsonConvert.SerializeObject(lista);
            File.WriteAllText(DirBiblioteca + @"\biblioteca.json", result);
            return true;
        }




        public int GetNewId()
        {
            int newid = 0;
            string text = System.IO.File.ReadAllText(@"Biblioteca\biblioteca.json");
            ListaTerrenos lista;
            lista = JsonConvert.DeserializeObject<ListaTerrenos>(text);

            return lista.count + 1;
        }


         public  Boolean LoadDocuments()
        {

            try
            {
                string[] dirs = Directory.GetDirectories(DirBiblioteca, "p*", SearchOption.TopDirectoryOnly);
             //   Console.WriteLine("The number of directories starting with p is {0}.", dirs.Length);
                foreach (string dir in dirs)
                {
                    



                }
            }
            catch (Exception e)
            {
                MessageBox.Show("API Error: " + e.ToString());
                
            }

            return true;

        }

    }
}

