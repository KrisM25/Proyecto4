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
    public class GestionDetallefactura : Conexion
    {
        // Función para registrar un nuevo Detalle factura

        public string RegistrarDetalleFactura(int IDDetalleFact ,int IdProducto, double CantidadComprada, int IdFactura)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Registrar_DetalleFactura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_IDDetalle", IDDetalleFact);
                        cmd.Parameters.AddWithValue("p_Producto", IdProducto);
                        cmd.Parameters.AddWithValue("p_Cantidad_Comprada", CantidadComprada);
                        cmd.Parameters.AddWithValue("p_Factura_Id", IdFactura);
                       


                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Detalle Factura registrada exitosamente" : "Error al registrar le Detalle Factura";
                    }
                }
                catch (MySqlException err)
                {
                    return $"Ocurrió un error: {err.Message}";
                }
                finally
                {
                    CerrarConexion(connection);
                }
            }
        }


        public DataTable ListaTodasDetallesFactura()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = EstablecerConexion())
                try
                {
                    AbrirConexion(con);
                    
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Detalle_Factura", con);
                    MySqlDataAdapter adacter = new MySqlDataAdapter(cmd);
                    adacter.Fill(dt);

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

            return dt;


        }

        public DataTable BuscarDetalleFactura(int idDetalleFactura)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                DataTable dataTable = new DataTable();
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Buscar_DetalleFactura", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Id_Detalle", idDetalleFactura);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }
                }
                catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrió un error: {err.Message}");
                }
                finally
                {
                    CerrarConexion(connection);
                }
                return dataTable;
            }
        }

        public string ActualizarDetalleFactura(int IdDetalleFact,int idProducto, double CantidadComprada, int IdFactura)
        {
            string Res = "";
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand("Actualizar_DetalleFactura", connection);
                    
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_Id_Detalle", IdDetalleFact);
                        cmd.Parameters.AddWithValue("p_Producto", idProducto);
                        cmd.Parameters.AddWithValue("p_Cantidad_Comprada ", CantidadComprada);
                        cmd.Parameters.AddWithValue("p_Factura_Id", IdFactura);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        Res = rowsAffected > 0 ? "Detalle Factura actualizada exitosamente" : "Error al actualizar el Detalle factura";
                    
                }
                catch (MySqlException err)
                {
                    Res = $"Ocurrió un error: {err.Message}";
                }
                finally
                {
                    CerrarConexion(connection);
                }
            }
            return Res;
        }


    }
}
