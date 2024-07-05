using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Proyecto4.GestionBD;

namespace Proyecto4.Formularios
{
    public partial class Detale_Factura : MaterialForm
    {
        public Detale_Factura()
        {
            InitializeComponent();
        }

        private void Detale_Factura_Load(object sender, EventArgs e)
        {
            GestionDetallefactura gestionDetallefact = new GestionDetallefactura();
            dataGridViewDetallefactura.DataSource = gestionDetallefact.ListaTodasDetallesFactura();
        }

        private void txtIIDDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            int IdProducto = int.Parse(txtIDProducto.Text);
            double CantidadComprada = double.Parse(txtCantidadComprada.Text);
            int IdFactura = int.Parse(txtIDFactura.Text);
            


            // Crear una instancia de GestionDetalleFactura y llamar al método RegistrarDetalleFactura
            GestionDetallefactura gestionDetalleFactura = new GestionDetallefactura();
            string resultado = gestionDetalleFactura.RegistrarDetalleFactura(IdProducto,CantidadComprada,IdFactura);

            //Refrescamos la lista
            GestionDetallefactura gestiondetallefactura = new GestionDetallefactura();
            dataGridViewDetallefactura.DataSource = gestiondetallefactura.ListaTodasDetallesFactura();

            // Mostrar el resultado
            MessageBox.Show(resultado, "Resultado del Detalle Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void btnBuscarDetalleFactura_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la factura
            int idDetallefactura = int.Parse(txtBuscarDetalleFactura.Text);

            // Crear una instancia de GestionDetalleFactura y llamar al método BuscarDetalleFactura
            GestionDetallefactura gestionfactura = new GestionDetallefactura();
            DataTable resultado = gestionfactura.BuscarDetalleFactura(idDetallefactura);

            // Mostrar el resultado en un DataGridView
            dataGridViewDetallefactura.DataSource = resultado;
        }

        private void dataGridViewDetallefactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDetallefactura.Rows[e.RowIndex];

                txtIDProducto.Text = row.Cells["Producto"].Value.ToString();
                txtCantidadComprada.Text = row.Cells["Cantidad_Comprada"].Value.ToString();
                txtIDFactura.Text = row.Cells["Factura_Id"].Value.ToString();
                
               
            }
        }

        private void btnActualizarDetalleFactura_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            int idProducto = int.Parse(txtIDProducto.Text);
            double CantidadComprada = int.Parse(txtCantidadComprada.Text);
            int idFactura = int.Parse(txtIDFactura.Text);
           

            // Crear una instancia de GestionDetalleFactura y llamar al método ActualizarDetalleFactura
            GestionDetallefactura gestionDetalleFactura = new GestionDetallefactura();
            string resultado = gestionDetalleFactura.ActualizarDetalleFactura(idProducto, CantidadComprada, idFactura);

            // Mostrar el resultado
            MessageBox.Show(resultado, "Resultado de la Actualización de Detalle Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtIDProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidadComprada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIDFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarDetalleFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
