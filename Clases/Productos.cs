using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Productos
    {
        int IdProducto { get; set; }
        string NombreProducto { get; set; }
        int MarcaProducto { get; set; }
        double StockProductos {  get; set; }
        string Proveedor {  get; set; }
        int PrecioProducto {  get; set; }

        public Productos() { }
        
        public Productos (int IdProducto_p,string NombreProducto_p, int MarcaProducto_p,double StockProductos,string Proveedor_p,int PrecioProducto_p)
        {
            this.IdProducto = IdProducto_p;
            this.NombreProducto = NombreProducto_p;
            this.MarcaProducto = MarcaProducto_p;
            this.StockProductos = StockProductos;
            this.Proveedor = Proveedor_p;
            this.PrecioProducto = PrecioProducto_p;
        }
    }
}
