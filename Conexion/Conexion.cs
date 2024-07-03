using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class Conexion
    {
        private string CadenaConexion;
        private string server = "jyjtechsolutions.com";
        private string nombre_base = "u481278819_marysmakeup";
        private string usuario = "u481278819_marysmk";
        private string passwd = "Marys2024";
        public Conexion()
        {
            CadenaConexion = $"Server={server};" +
                $"Database={nombre_base};" +
                $"User Id={usuario}; " +
                $"Password= {passwd};";
        }

        /// <summary>
        /// Establece la conexion a la base de datos
        /// </summary>
        /// <returns></returns>
        public MySqlConnection EstablecerConexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
        public void AbrirConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion establecida!!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error{ex.Message}");
            }
        }
        /// <summary>
        /// Cierra la conexion con la base de datos
        /// </summary>
        /// <param name="conexion"></param>
        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                conexion.Close(); 
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Ocurrio un error: {ex.Message}");
            }
        }

        public void EjecutarConsulta(string consulta)
        {
            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand(consulta, con);
                    int cantidadFilasAfectadas = cmd.ExecuteNonQuery();
                    Console.WriteLine($"filas afectivas {cantidadFilasAfectadas}");
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Ocurrio un Error: {ex.Message}");

                }
            }

        }


        /// <summary>
        /// Ejecuta una consulta del tipo select y la almacena en un DataTable para 
        /// imprimirlo despues en un DaTaGridView si se desea
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataTable ImprimirConsulta(string consulta)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection con = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(con);
                    MySqlCommand cmd = new MySqlCommand(consulta, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error {ex}");
                }
                return dataTable;
            }
        }
    }
}
