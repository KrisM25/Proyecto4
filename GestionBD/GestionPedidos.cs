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
    public class GestionPedidos : Conexion
    {



        public DataTable ListaTodosPedidos()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("proc", con);
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




        public void RegistrarPedido(int idPedido, string cedulaClientePide, string estado, DateTime FechaPedido, string NombreCliente)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {

                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("Registrar_Pedido", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idPedido", idPedido);
                    cmd.Parameters.AddWithValue("p_cedulaClientePide", cedulaClientePide);
                    cmd.Parameters.AddWithValue("p_estado", estado);
                    cmd.Parameters.AddWithValue("p_fechaPedido", FechaPedido);
                    cmd.Parameters.AddWithValue("p_nombreCliente", NombreCliente);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Pedido Guardado");
                }
                catch (MySqlException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }




        public DataTable BuscarPedido(string IdPedido)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Buscar_Pedido", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idPedido", IdPedido);
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




        public string ActualizarPedido(int IdPedido, string cedulaClientePide, string estado, DateTime fechaPedido, string nombreCliente)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {

                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Actualizar_Pedido", connection))
                    {
                        cmd.Parameters.AddWithValue("p_idPedido", IdPedido);
                        cmd.Parameters.AddWithValue("p_cedulaClientePide", cedulaClientePide);
                        cmd.Parameters.AddWithValue("p_estado", estado);
                        cmd.Parameters.AddWithValue("p_fechaPedido", fechaPedido);
                        cmd.Parameters.AddWithValue("p_nombreCliente", nombreCliente);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Pedido Actualizado");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Pedido actualizado exitosamente" : "Error al actualizar la Marca";
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
    }
}


