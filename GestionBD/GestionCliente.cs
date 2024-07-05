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
    public class GestionCliente : Conexion
    {

        public GestionCliente() { }//Constructor por  defecto de la clase

        public void RegistrarCliente(string IdCliente, string nombre, string apellido, string telefono, string correo) //Todo esto es como (ObtenerListaCategorias) nada mas que en una clase y en teoria es mas ordenado 
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("Registrar_Cliente", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idCliente", IdCliente);
                    cmd.Parameters.AddWithValue("p_nombre", nombre);
                    cmd.Parameters.AddWithValue("p_apellidos", apellido);
                    cmd.Parameters.AddWithValue("p_telefono", telefono);
                    cmd.Parameters.AddWithValue("p_correo", correo);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Cliente Guardado");
                }
                catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrio un error: {err.Message}");
                }
            }
        }





        public DataTable ListaTodosClientess()
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


        public DataTable BuscarCliente(string IdCliente)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand("Buscar_Cliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_idCliente", IdCliente);
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



        public string ActualizarCliente(int IdCliente, string nombre, string apellido, string telefono, string correo)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("Actualizar_Cliente", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_idCliente", IdCliente);
                        cmd.Parameters.AddWithValue("p_nombre", nombre);
                        cmd.Parameters.AddWithValue("p_apellidos", apellido);
                        cmd.Parameters.AddWithValue("p_telefono", telefono);
                        cmd.Parameters.AddWithValue("p_correo", correo);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0 ? "Cliente actualizado exitosamente" : "Error al actualizar la Marca";
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


        public void EliminarCliente(int IdCliente)
        {
            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);

                    MySqlCommand cmd = new MySqlCommand("Eliminar_Cliente", con);
                    cmd.Parameters.AddWithValue(" p_idCliente", IdCliente);

                    int rowsAffected = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    CerrarConexion(con);
                }
            }
        }
    }
}

