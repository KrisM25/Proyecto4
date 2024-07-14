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
    public class Gestion_DetallePedido : Conexion
    {
        public DataTable ListarDetallePedidos()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Listar_DetallePedido", con);
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public void RegistrarDetallePedido(int idDetalle, int idPedidoDetalle, int codProducto, int cant)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {

                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("Registrar_DetallePedido", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idDetalle", idDetalle);
                    cmd.Parameters.AddWithValue("p_idPedidoDetalle", idPedidoDetalle);
                    cmd.Parameters.AddWithValue("p_codProducto", codProducto);
                    cmd.Parameters.AddWithValue("p_cantidad", cant);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Detalle_Pedido Guardado");
                }
                catch (MySqlException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }



        public DataTable BuscarDetallePedido(string IdDetalle)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Buscar_DetallePedido", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idDetalle", IdDetalle);
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



        public string ActualizarDetallePedido(int idDetalle, int idPedidoDetalle, int codProducto, int cant)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand("Actualizar_DetallePedido", connection); 
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idDetalle", idDetalle);
                    cmd.Parameters.AddWithValue("p_idPedidoDetalle", idPedidoDetalle);
                    cmd.Parameters.AddWithValue("p_codProducto", codProducto);
                    cmd.Parameters.AddWithValue("p_cantidad", cant);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "DetallePedido actualizado exitosamente" : "Error al actualizar el Detalle pedido";
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

        public string EliminarDetallePedido(int idDetalle)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand("Eliminar_DetallePedido", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idDetalle", idDetalle);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? " Detalle Pedido eliminado exitosamente" : "Error al eliminar el Detalle pedido";
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
    }
}

