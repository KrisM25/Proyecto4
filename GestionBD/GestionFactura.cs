﻿using MySql.Data.MySqlClient;
using Proyecto4.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.GestionBD
{
    public class GestionFactura : Conexion
    {
        // Función para registrar una nueva factura
        public string RegistrarFactura(string CedulaCliente, string CodProduc, int UnidadesCompradas, string Nuevo, double DescuentoApli, int NumeroPedido,double CostaEnvio,string EstadoFact)
        {
            string Res = "";
            using (MySqlConnection connection = EstablecerConexion())
            {
                try
                {
                    AbrirConexion(connection);

                    MySqlCommand cmd = new MySqlCommand("SP_facturacion", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("cedula_cliente", CedulaCliente);
                        cmd.Parameters.AddWithValue("cod_prod", CodProduc);
                        cmd.Parameters.AddWithValue("unidades_compra", UnidadesCompradas);
                        cmd.Parameters.AddWithValue("nuevo", Nuevo);
                        cmd.Parameters.AddWithValue("descuento_aplicar", DescuentoApli);
                        cmd.Parameters.AddWithValue("nPedido", NumeroPedido);
                        cmd.Parameters.AddWithValue("CostoEnvio", NumeroPedido);
                        cmd.Parameters.AddWithValue("EstadoFactura", EstadoFact);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        Res = rowsAffected > 0 ? "Factura registrada exitosamente" : "Error al registrar la factura";
                    
                }
                catch (MySqlException err)
                {
                    Res = $"Ocurrió un error: {err.Message}";
                }
                finally
                {
                    CerrarConexion(connection);
                }
            }
            return Res;
        }

        

        public DataTable BuscarFactura(int idFactura)
        {
            using (MySqlConnection connection = EstablecerConexion())
            {
                DataTable dataTable = new DataTable();
                try
                {
                    AbrirConexion(connection);

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM facturacion WHERE idFactura = @idFactura", connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@idFactura", idFactura);

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

        public DataTable ListaTodasFacturas()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = EstablecerConexion())
                try
                {
                    AbrirConexion(con);
                    
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM facturacion", con);
                    MySqlDataAdapter adacter = new MySqlDataAdapter(cmd);
                    adacter.Fill(dt);

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

            return dt;


        }
    }
}

