using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Oaxaca
{
    class MasterAPI
    {

        public struct Documento
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




        public Boolean NuevoDocumento()
        {


            return true;
        }



    }
}

