using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Creditos
    {
        public int IdCredito { get; set; }
        public int IdPedidoCredito { get; set; }
        public string EstadoCliente { get; set; }
        public string FechaRegistroCredito { get; set; }

        public Creditos() { }

        public Creditos (int IdCredito_p, int IdPedidoCredito_p, string EstadoCliente_p, string FechaRegistroCredito_p)
        {
            this.IdCredito = IdCredito_p;
            this.IdPedidoCredito = IdPedidoCredito_p;
            this.EstadoCliente = EstadoCliente_p;
            this.FechaRegistroCredito = FechaRegistroCredito_p;
        }
    }
}
