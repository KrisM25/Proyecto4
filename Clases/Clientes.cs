using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Clientes
    {
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidosCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public Clientes() { }

        public Clientes(string IdCliente_p, string NombreCliente_p, string ApellidosCliente_p,string TelefonoCliente_p,string CorreoCliente_p)
        {
            this.IdCliente = IdCliente_p;
            this.NombreCliente = NombreCliente_p;
            this.ApellidosCliente = ApellidosCliente_p;
            this.TelefonoCliente = TelefonoCliente_p;
            this.CorreoCliente = CorreoCliente_p;
        }
    }
}
