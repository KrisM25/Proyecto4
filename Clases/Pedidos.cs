using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Pedidos
    {
        public int IdPedido { get; set; }
        public string CedulaCliente { get; set; }
        public string Estado {  get; set; }
        public Pedidos() { }

        public Pedidos(int IdPedido_p,string CedulaCliente_p,string Estado_p)
        {
            this.IdPedido = IdPedido_p;
            this.CedulaCliente = CedulaCliente_p;
            this.Estado = Estado_p;
        }
    }
}
