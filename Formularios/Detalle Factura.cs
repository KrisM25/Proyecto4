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
using Proyecto4.Clases;
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
            var DetallesFactura = gestionDetallefact.ListaTodasDetallesFactura();
            dataGridViewDetallefactura.DataSource = DetallesFactura;
            CBBXIDDetalleFactura.DataSource = DetallesFactura;
            CBBXIDDetalleFactura.DisplayMember = "Id_Detalle";
            CBBXIDDetalleFactura.ValueMember = "Id_Detalle";

            GestionProductos gestionproducto = new GestionProductos();
            var Productos = gestionproducto.ListaTodasProductos();
            CBBXIDProducto.DataSource = Productos;
            CBBXIDProducto.DisplayMember = "nombreProducto";
            CBBXIDProducto.ValueMember = "id";


            GestionFactura gestionFactura = new GestionFactura();
            var Factura = gestionFactura.ListaTodasFacturas();
            CBBXIDFactura.DataSource = Factura;
            CBBXIDFactura.DisplayMember = "idFactura";
            CBBXIDFactura.ValueMember = "idFactura";
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { CBBXIDDetalleFactura,CBBXIDProducto,txtCantidadComprada,CBBXIDFactura }))
            {
                // Obtener los valores de los controles

                int IDDetalleFactura = int.Parse(CBBXIDDetalleFactura.SelectedValue.ToString());
                int IdProducto = int.Parse(CBBXIDProducto.SelectedValue.ToString());
                double CantidadComprada = double.Parse(txtCantidadComprada.Text);
                int IdFactura = int.Parse(CBBXIDFactura.SelectedValue.ToString());
            


                // Crear una instancia de GestionDetalleFactura y llamar al método RegistrarDetalleFactura
                GestionDetallefactura gestionDetalleFactura = new GestionDetallefactura();
                string resultado = gestionDetalleFactura.RegistrarDetalleFactura(IDDetalleFactura,IdProducto,CantidadComprada,IdFactura);

                //Refrescamos la lista
                GestionDetallefactura gestiondetallefactura = new GestionDetallefactura();
                dataGridViewDetallefactura.DataSource = gestiondetallefactura.ListaTodasDetallesFactura();


                CBBXIDDetalleFactura.SelectedItem = null;
                CBBXIDDetalleFactura.Refresh();

                CBBXIDProducto.SelectedItem = null;
                CBBXIDProducto.Refresh();

                txtCantidadComprada.Clear();

                CBBXIDFactura.SelectedItem = null;
                CBBXIDFactura.Refresh();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado del Detalle Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        

        private void btnBuscarDetalleFactura_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarDetalleFactura }))
            {
                    // Obtener el ID de la factura
                    int idDetallefactura = int.Parse(txtBuscarDetalleFactura.Text);

                // Crear una instancia de GestionDetalleFactura y llamar al método BuscarDetalleFactura
                GestionDetallefactura gestionfactura = new GestionDetallefactura();
                DataTable resultado = gestionfactura.BuscarDetalleFactura(idDetallefactura);

                // Mostrar el resultado en un DataGridView
                dataGridViewDetallefactura.DataSource = resultado;

                txtBuscarDetalleFactura.Clear();

            }
            else { Console.WriteLine("1"); }
        }

        private void dataGridViewDetallefactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDetallefactura.Rows[e.RowIndex];

                CBBXIDDetalleFactura.SelectedValue = row.Cells["Id_Detalle"].Value.ToString();
                CBBXIDProducto.SelectedValue = row.Cells["Producto"].Value.ToString();
                txtCantidadComprada.Text = row.Cells["Cantidad_Comprada"].Value.ToString();
                CBBXIDFactura.SelectedValue = row.Cells["Factura_Id"].Value.ToString();
                
               
            }
        }

        private void btnActualizarDetalleFactura_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { CBBXIDDetalleFactura, CBBXIDProducto, txtCantidadComprada, CBBXIDFactura }))
            {
                // Obtener los valores de los controles
                int IDDetalleFactura = int.Parse(CBBXIDDetalleFactura.SelectedValue.ToString());
                int IdProducto = int.Parse(CBBXIDProducto.SelectedValue.ToString());
                double CantidadComprada = double.Parse(txtCantidadComprada.Text);
                int IdFactura = int.Parse(CBBXIDFactura.SelectedValue.ToString());


                // Crear una instancia de GestionDetalleFactura y llamar al método ActualizarDetalleFactura
                GestionDetallefactura gestionDetalleFactura = new GestionDetallefactura();
                string resultado = gestionDetalleFactura.ActualizarDetalleFactura(IDDetalleFactura,IdProducto, CantidadComprada, IdFactura);

                CBBXIDDetalleFactura.SelectedItem = null;
                CBBXIDDetalleFactura.Refresh();

                CBBXIDProducto.SelectedItem = null;
                CBBXIDProducto.Refresh();

                txtCantidadComprada.Clear();

                CBBXIDFactura.SelectedItem = null;
                CBBXIDFactura.Refresh();
                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización de Detalle Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        

        private void txtCantidadComprada_KeyPress(object sender, KeyPressEventArgs e)
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
