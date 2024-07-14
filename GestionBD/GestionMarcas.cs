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
    public class GestionMarcas : Conexion
    {
        public string RegistrarMarca( string NombreMarca)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Registrar_Marca", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_nombre_marca", NombreMarca);
                        



                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Marca registrada exitosamente" : "Error al registrar la Marca";
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

        public DataTable ListaTodasMarcas()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = EstablecerConexion())
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM marcas", con);
                    MySqlDataAdapter adacter = new MySqlDataAdapter(cmd);
                    adacter.Fill(dt);

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

            return dt;


        }

        public DataTable BuscarMarca(int idMarca)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                DataTable dataTable = new DataTable();
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Buscar_Marca", connection))
                    {
                        cmd.Parameters.AddWithValue("id", idMarca);

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

        public string ActualizarMarca(int idMarca, string NombreMarca)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Actualizar_Marca", connection))
                    {
                        cmd.Parameters.AddWithValue("id", idMarca);
                        cmd.Parameters.AddWithValue("nombre_marca", NombreMarca);
                        


                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Marca actualizada exitosamente" : "Error al actualizar la Marca";
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

        public string EliminarMarca(int idMarca)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    
                    MySqlCommand cmd = new MySqlCommand("Eliminar_Marca", connection);
                    cmd.Parameters.AddWithValue("id", idMarca);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Marca eliminada exitosamente" : "Error al eliminar la Marca";
                }
                catch (MySqlException ex)
                {
                   return $"Error al eliminar marca: {ex.Message}";
                }
                finally
                {
                    CerrarConexion(connection);
                }
            }
        }
    }
}
