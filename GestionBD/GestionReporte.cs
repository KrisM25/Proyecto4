using MySql.Data.MySqlClient;
using Proyecto4.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.GestionBD
{
    public class GestionReporte: Conexion
    {
        public DataSet ReporteFacturacion()
        {
            DataSet tabla = new DataSet();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("SELECT\r\n    F.idFactura,\r\n    C.idCliente,\r\n    C.nombre,\r\n    C.apellidos,    \r\n    C.telefono,\r\n    C.correo,\r\n    DF.Producto,\r\n    DF.Cantidad_Comprada,\r\n    F.subTotal,\r\n    F.IVA,\r\n    F.descuento,\r\n    F.total,\r\n    F.fechaGeneracionFactura,\r\n    F.estado_factura\r\nFROM facturacion F\r\nINNER JOIN Detalle_Factura DF ON F.idFactura = DF.Factura_Id\r\nINNER JOIN pedidos P ON F.pedido = P.idPedido\r\nINNER JOIN clientes C ON P.cedulaClientePide = C.idCliente;", con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tabla);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Ocurrio un error: " + ex.Message);
                }
                finally
                {//despues de finalizar todo, cerrar la conexion
                    CerrarConexion(con);
                }
            }
            return tabla;


        }
    }
}
