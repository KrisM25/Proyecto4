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
                    MySqlCommand cmd = new MySqlCommand("Listar_Credito", con);
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






        public string RegistrarCredito(int idCredito, int idPedidoCredito, string estado, DateTime fecha)
        {
            try
            {
                using (MySqlConnection con = EstablecerConexion())
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Registrar_Credito", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idCredito", idCredito);
                    cmd.Parameters.AddWithValue("p_idPedido", idPedidoCredito);
                    cmd.Parameters.AddWithValue("p_estado", estado);
                    cmd.Parameters.AddWithValue("p_fechaRegistro", fecha);  // Asegúrate de que el nombre del parámetro coincida
                    cmd.ExecuteNonQuery();
                    return "Crédito registrado exitosamente.";
                }
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error: {ex.Message}";
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

        public string EliminarCredito(int idCredito)
        {
            try
            {
                using (MySqlConnection con = EstablecerConexion())
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Eliminar_Credito", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idCredito", idCredito);
                    cmd.ExecuteNonQuery();
                    return "Crédito eliminado exitosamente.";
                }
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error: {ex.Message}";
            }
        }

        public string ActualizarCredito(int idCredito, int idPedidoCredito, string estado, DateTime fecha)
        {
            try
            {
                using (MySqlConnection con = EstablecerConexion())
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Actualizar_Credito", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idCredito", idCredito);
                    cmd.Parameters.AddWithValue("p_idPedido", idPedidoCredito);
                    cmd.Parameters.AddWithValue("p_estado", estado);
                    cmd.Parameters.AddWithValue("p_fechaRegistro", fecha);  // Asegúrate de que el nombre del parámetro coincida
                    cmd.ExecuteNonQuery();
                    return "Crédito actualizado exitosamente.";
                }
            }
            catch (Exception ex)
            {
                return $"Ocurrió un error: {ex.Message}";
            }
        }



    }
}

