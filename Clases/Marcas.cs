using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Marcas
    {
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public Marcas() { }

        public Marcas(int idMarca_p,string NombreMarca_p)
        {
            this.IdMarca = idMarca_p;
            this.NombreMarca = NombreMarca_p;
        }
    }
}
