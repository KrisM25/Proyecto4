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
    public class GestionProductos : Conexion
    {
        public string RegistrarProductos(int IdProducto, string NombreProducto, int IdMarca, double CantidadStock, string IdProveedor, int PrecioProducto)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Registrar_Producto", connection))
                    {
                        cmd.Parameters.AddWithValue("id", IdProducto);
                        cmd.Parameters.AddWithValue("nombreProducto", NombreProducto);
                        cmd.Parameters.AddWithValue("marca", IdMarca);
                        cmd.Parameters.AddWithValue("stock", CantidadStock);
                        cmd.Parameters.AddWithValue("proveedor", IdProveedor);
                        cmd.Parameters.AddWithValue("PrecioProducto", PrecioProducto);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Producto registrado exitosamente" : "Error al registrar el producto";
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

        public DataTable BuscarProducto(int idProducto)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                DataTable dataTable = new DataTable();
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Buscar_Producto", connection))
                    {
                        cmd.Parameters.AddWithValue("id", idProducto);

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

        public DataTable ListaTodasProductos()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = EstablecerConexion())
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM productos", con);
                    MySqlDataAdapter adacter = new MySqlDataAdapter(cmd);
                    adacter.Fill(dt);

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

            return dt;


        }

        public string ActualizarProducto(int IdProducto,string NombreProducto, int IdMarca, double CantidadStock, string IdProveedor, int PrecioProducto)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Actualizar_Producto", connection))
                    {
                        cmd.Parameters.AddWithValue("id", IdProducto);
                        cmd.Parameters.AddWithValue("nombreProducto", NombreProducto);
                        cmd.Parameters.AddWithValue("marca", IdMarca);
                        cmd.Parameters.AddWithValue("stock", CantidadStock);
                        cmd.Parameters.AddWithValue("proveedor", IdProveedor);
                        cmd.Parameters.AddWithValue("PrecioProducto", PrecioProducto);



                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Producto actualizado exitosamente" : "Error al actualizar el Producto";
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

        public string EliminarProducto(int idProducto)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);


                    MySqlCommand cmd = new MySqlCommand("Eliminar_Producto", connection);
                    cmd.Parameters.AddWithValue("id", idProducto);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0 ? "Producto eliminado exitosamente" : "Error al eliminar el Producto";
                }
                catch (MySqlException ex)
                {
                    return $"Error al eliminar Producto: {ex.Message}";
                }
                finally
                {
                    CerrarConexion(connection);
                }
            }
        }
    }
}
