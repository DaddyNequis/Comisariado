using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Oaxaca
{
    class ObjTerreno
    {
       
        public Int16 DocumentID { get; set; }
        public Int16 LastVersion { get; set; }
        public List<VerTerreno> Versiones { get; set; }


}

class VerTerreno
    {

        public Int16 VersionID { get; set; }
        public String Tipo { get; set; }
        public String Fecha { get; set; }
        public List<String> Cedentes { get; set; }
        public List<String> Beneficiarios { get; set; }
        public String Hectareas { get; set; }
        public String Paraje { get; set; }


    }
}
