using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Oaxaca
{
    class ObjTerreno
    {
       
        public int DocumentID { get; set; }
        public int LastVersion { get; set; }
        public List<VerTerreno> Versiones { get; set; }


}

class VerTerreno
    {

        public int VersionID { get; set; }
        public String Tipo { get; set; }
        public String Fecha { get; set; }
        public List<String> Cedentes { get; set; }
        public List<String> Beneficiarios { get; set; }
        public String Hectareas { get; set; }
        public String Paraje { get; set; }


    }
}
