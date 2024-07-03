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
    public class GestionProveedores : Conexion
    {
        public string RegistrarProveedor(string IdProveedor,string NombreProveedor, string TelefonoProveedor,string CorreoProveedor)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Registrar_Proveedor", connection))
                    {

                        cmd.Parameters.AddWithValue("idProveedor", IdProveedor);
                        cmd.Parameters.AddWithValue("nombre_proveedor", NombreProveedor);
                        cmd.Parameters.AddWithValue("telefono", TelefonoProveedor);
                        cmd.Parameters.AddWithValue("correo", CorreoProveedor);




                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Proveedor registrado exitosamente" : "Error al registrar el Proveedor";
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

        public DataTable ListaTodasProveedor()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = EstablecerConexion())
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM proveedor", con);
                    MySqlDataAdapter adacter = new MySqlDataAdapter(cmd);
                    adacter.Fill(dt);

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

            return dt;


        }

        public DataTable BuscarProveedor(string idProveedorr)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                DataTable dataTable = new DataTable();
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Buscar_Proveedor", connection))
                    {
                        cmd.Parameters.AddWithValue("idProveedor", idProveedorr);

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

        public string ActualizarProveedor(string IdProveedor,string NombreProveedor, string TelefonoProveedor, string CorreoProveedor)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Actualizar_Proveedor", connection))
                    {
                        cmd.Parameters.AddWithValue("idProveedor", IdProveedor);
                        cmd.Parameters.AddWithValue("nombre_proveedor", NombreProveedor);
                        cmd.Parameters.AddWithValue("telefono", TelefonoProveedor);
                        cmd.Parameters.AddWithValue("correo", CorreoProveedor);



                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Proveedor actualizado exitosamente" : "Error al actualizar el Proveedor";
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

        public string EliminarProveedor(string idProveedor)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);


                    MySqlCommand cmd = new MySqlCommand("Eliminar_Proveedor", connection);
                    cmd.Parameters.AddWithValue("idProveedor", idProveedor);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Proveedor eliminado exitosamente" : "Error al eliminar el Proveedor";
                }
                catch (MySqlException ex)
                {
                    return $"Error al eliminar Proveedor: {ex.Message}";
                }
                finally
                {
                    CerrarConexion(connection);
                }
            }
        }
    }
}
