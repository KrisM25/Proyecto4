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
    public class GestionUsuario : Conexion
    {
        public string usuarioVerificar { get; set; }

        public string PasswordVerificar { get; set; }


        public GestionUsuario() { }


        public bool Verificar_Usuario_Contra(string usuario, string contrasennia)
        {
            bool existe = false;
            DataTable dt = new DataTable();

            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Contrasenia = @Contrasenia";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasenia", contrasennia);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    existe = dt.Rows.Count > 0;
                }
                catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrió un error: {err.Message}");
                }
                finally
                {
                    CerrarConexion(connection);
          
                }
            } 
            return existe;
        }

        public void RegistrarUsuario(string nombreUsuario, string contrasenia)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);
                    MySqlCommand cmd = new MySqlCommand("sp_AgregarUsuario", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("p_Contrasenia", contrasenia);
                    Console.WriteLine(cmd.ExecuteNonQuery());
                }
                catch (MySqlException err)
                {
                    Console.WriteLine($"Ocurrio un error: {err.Message}");
                }
            }
        }


    }
}
