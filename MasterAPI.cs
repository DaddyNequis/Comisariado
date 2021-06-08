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

        public Boolean NuevoDocumento()
        {


            return true;
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

