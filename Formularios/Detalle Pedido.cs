using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Proyecto4.GestionBD;

namespace Proyecto4.Formularios
{
    public partial class Detalle_Pedido : MaterialForm
    {

        public Detalle_Pedido()
        {
            InitializeComponent();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Menú_Admin NewMenú = new Menú_Admin();
            NewMenú.Show();
        }

        private void txtIDDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdPedidoDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodProducPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras, números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIDDetalle, txtIdPedidoDetalle, txtCodProducPedido, txtCantidad }))
            {
                Gestion_DetallePedido GesDetallePed = new Gestion_DetallePedido();
                GesDetallePed.RegistrarDetallePedido(Convert.ToInt32(txtIDDetalle.Text), Convert.ToInt32(txtIdPedidoDetalle.Text), Convert.ToInt32(txtCodProducPedido.Text), Convert.ToInt32(txtCantidad.Text));
                dataGridViewDetallePedido.DataSource = GesDetallePed.ImprimirConsulta("Select * from detallePedido");
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        private void btnBuscarDetallePedido_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIDDetalle }))
            {
                Gestion_DetallePedido GesDetallePed = new Gestion_DetallePedido();
                dataGridViewDetallePedido.DataSource = GesDetallePed.BuscarDetallePedido(txtBuscarDetallePedido.Text);
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIDDetalle, txtIdPedidoDetalle, txtCodProducPedido, txtCantidad }))
            {

                // Obtener los valores de los controles
                int idDetalle = int.Parse(txtIDDetalle.Text);
                int idPedidoDetalle = int.Parse(txtIdPedidoDetalle.Text);
                int codProducto = int.Parse(txtCodProducPedido.Text);
                int cant = int.Parse(txtCantidad.Text);

                // Instanciar la clase para gestionar pedidos
                Gestion_DetallePedido GesDetallePed = new Gestion_DetallePedido();

                // Actualizar el pedido y obtener el resultado
                string resultado = GesDetallePed.ActualizarDetallePedido(idDetalle, idPedidoDetalle, codProducto, cant);

                // Actualizar el DataGridView con la lista actualizada de pedidos
                DataTable dt = GesDetallePed.ListarDetallePedidos();
                Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                dataGridViewDetallePedido.DataSource = dt;

                // Limpiar los campos de texto
                txtIDDetalle.Clear();
                txtIdPedidoDetalle.Clear();
                txtCodProducPedido.Clear();
                txtCantidad.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Detalle Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("Campos vacíos.");
            }  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada para eliminar
            if (dataGridViewDetallePedido.SelectedRows.Count > 0)
            {
                // Obtener el ID del pedido seleccionado
                int idDetalle = Convert.ToInt32(dataGridViewDetallePedido.SelectedRows[0].Cells["idDetalle"].Value);

                // Confirmar con el usuario antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este Detalle pedido?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Instanciar la clase para gestionar Detalle pedidos
                        Gestion_DetallePedido gesDetallePed = new Gestion_DetallePedido();

                        // Llamar al método para eliminar el Detalle pedido de la base de datos
                        string mensaje = gesDetallePed.EliminarDetallePedido(idDetalle);

                        // Mostrar mensaje de éxito
                        MessageBox.Show(mensaje, "Eliminar Detalle Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView con la lista actualizada de Detalle pedidos
                        DataTable dt = gesDetallePed.ListarDetallePedidos();
                        Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                        dataGridViewDetallePedido.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el Detalle pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un Detalle pedido para eliminar.", "Detalle Pedido no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Detalle_Pedido_Load(object sender, EventArgs e)
        {

            Gestion_DetallePedido GesDetallePed = new Gestion_DetallePedido();
            dataGridViewDetallePedido.DataSource = GesDetallePed.ImprimirConsulta("Select * from detallePedido");
        }
    }
}
