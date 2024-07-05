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
    public class GestionCréditos : Conexion
    {


        public DataTable ListaTodosCreditos()
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






        public void RegistrarCredito(int creditoId, int pedidId, string estado, int fecha)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {

                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("Registrar_", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("new_author_name", creditoId);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Crédito Guardado");
                }
                catch (MySqlException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }



        public DataTable BuscarCredito(string IdCredito)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Buscar_Credito", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idCredito", IdCredito);
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


        public string ActualizarCredito(int idCredito, int idPedido, string estado, DateTime fechaRegistroCredito)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("Actualizar_Credito", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idCredito", idCredito);
                    cmd.Parameters.AddWithValue("p_idPedido", idPedido);
                    cmd.Parameters.AddWithValue("p_estado", estado);
                    cmd.Parameters.AddWithValue("p_fechaRegistroCredito", fechaRegistroCredito);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Crédito Actualizado");


                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Credito actualizado exitosamente" : "Error al actualizar la Marca";
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

