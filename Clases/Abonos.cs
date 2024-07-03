using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Abonos
    {
        public int IdAbono {  get; set; }
        public double MontoAbono { get; set; }
        public string TipoPagoAbono { get; set; }
        public string TransaccionComprobanten {  get; set; }
        public int IdCreditoAbono {  get; set; }
        public string FechaAbono { get; set; }
        public Abonos() { }

        public Abonos (int IdAbono_p, double MontoAbono_p, string TipoPagoAbono_p, string TransaccionComprobanten_p, int IdCreditoAbono_p, string FechaAbono_p)
        {
            this.IdAbono = IdAbono_p;
            this.MontoAbono = MontoAbono_p;
            this.TipoPagoAbono = TipoPagoAbono_p;
            this.TransaccionComprobanten = TransaccionComprobanten_p;
            this.IdCreditoAbono = IdCreditoAbono_p;
            this.FechaAbono = FechaAbono_p;
        }
    }
}
