using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Proveedor
    {
        public int IdProveedor {  get; set; }
        public string NombreProveedor { get; set; }
        public string TelefonoProveedor {  get; set; }
        public string CorreoProveedor { get; set; }
        public Proveedor() { }

        public Proveedor (int IdProveedor_p,string NombreProveedor_p,string TelefonoProveedor_p,string CorreoProveedor_p)
        {
            this.IdProveedor = IdProveedor_p;
            this.NombreProveedor = NombreProveedor_p;
            this.TelefonoProveedor = TelefonoProveedor_p;
            this.CorreoProveedor = CorreoProveedor_p;
        }
    }
}
