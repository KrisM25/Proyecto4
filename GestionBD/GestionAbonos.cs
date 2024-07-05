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
    public class GestionAbonos : Conexion
    {


        public DataTable ListaTodosAbonos()
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






        public void RegistrarAbono(int idAbonos, double monto, string tipoPago, string transaccion_comprobante, int idCredito, DateTime fechaAbono)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {

                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("Registrar_Abono", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idAbonos", idAbonos);
                    cmd.Parameters.AddWithValue("p_monto", monto);
                    cmd.Parameters.AddWithValue("p_tipoPago", tipoPago);
                    cmd.Parameters.AddWithValue("p_transaccion_comprobante", transaccion_comprobante);
                    cmd.Parameters.AddWithValue("p_idCredito", idCredito);
                    cmd.Parameters.AddWithValue("p_fechaAbono", fechaAbono);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Abono Guardado");
                }
                catch (MySqlException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }




        public DataTable BuscarAbono(string IdAbono)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Buscar_Abono", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idPedido", IdAbono);
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

        public string ActualizarAbono(int idAbonos, double monto, string tipoPago, string transaccion_comprobante, int idCredito, DateTime fechaAbono)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("Actualizar_Abono", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idAbonos", idAbonos);
                    cmd.Parameters.AddWithValue("p_monto", monto);
                    cmd.Parameters.AddWithValue("p_tipoPago", tipoPago);
                    cmd.Parameters.AddWithValue("p_transaccion_comprobante", transaccion_comprobante);
                    cmd.Parameters.AddWithValue("p_idCredito", idCredito);
                    cmd.Parameters.AddWithValue("p_fechaAbono", fechaAbono);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Crédito Actualizado");


                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Abono actualizado exitosamente" : "Error al actualizar la Marca";
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
