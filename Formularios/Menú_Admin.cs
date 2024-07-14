using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using K4os.Compression.LZ4.Encoders;
using MaterialSkin.Controls;
using Proyecto4.GestionBD;
using Proyecto4.Reportes;

namespace Proyecto4.Formularios
{
    public partial class Menú_Admin : MaterialForm
    {
        public Menú_Admin()
        {
            InitializeComponent();
        }

        private void Menú_Admin_Load(object sender, EventArgs e)
        {
            GestionFactura gestionFactura = new GestionFactura();
            dataGridViewFacturacion.DataSource = gestionFactura.ListaTodasFacturas();

            GestionMarcas gestionmarca = new GestionMarcas();
            dataGridViewMarcas.DataSource = gestionmarca.ListaTodasMarcas();

            GestionProductos gestionproducto = new GestionProductos();
            dataGridViewProductos.DataSource = gestionproducto.ListaTodasProductos();

            GestionProveedores gestionproveedores = new GestionProveedores();
            dataGridViewProveedores.DataSource = gestionproveedores.ListaTodasProveedor();

            GestionCliente GesCliente = new GestionCliente();
            dataGridViewClientes.DataSource = GesCliente.ImprimirConsulta("Select * from clientes");

            GestionPedidos GesPedidos = new GestionPedidos();
            dataGridView2Pedidos.DataSource = GesPedidos.ImprimirConsulta("Select * from pedidos Order by estado DESC");

            GestionCréditos GesCredito = new GestionCréditos();
            dataGridViewCreditos.DataSource = GesCredito.ImprimirConsulta("Select * from credito");

            // Después de llenar el DataGridView con datos
            GestionAbonos GesAbono = new GestionAbonos();
            dataGridViewAbonos.DataSource = GesAbono.ImprimirConsulta("SELECT * FROM abonos");

            // Imprimir nombres de columnas para depuración
            foreach (DataGridViewColumn column in dataGridViewAbonos.Columns)
            {
                Console.WriteLine(column.Name);
            }


        }



        private void btnDetallePedido_Click(object sender, EventArgs e)
        {
            Detalle_Pedido NewDetallePedido = new Detalle_Pedido();
            NewDetallePedido.Show();
        }

        private void btnDetalleFactura_Click(object sender, EventArgs e)
        {
            Detale_Factura NewDetalleFactura = new Detale_Factura();
            NewDetalleFactura.Show();
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtCedulaCliente, txtCod_Produc, txtUnidadesCompra, ComboBoxNuevo, txtDescuentoFactura, txtNumeroPedido }))
            {
                // Obtener los valores de los controles
                string CedulaCliente = txtCedulaCliente.Text;
                string CodigoProduc = txtCod_Produc.Text;
                int UnidadesCompradas = int.Parse(txtUnidadesCompra.Text);
                string Nuevo = ComboBoxNuevo.Text;
                double DescuentoAplicar = double.Parse(txtDescuentoFactura.Text);
                int NumPedido = int.Parse(txtNumeroPedido.Text);


                // Crear una instancia de GestionFacturacion y llamar al método RegistrarFactura
                GestionFactura gestionFacturacion = new GestionFactura();
                string resultado = gestionFacturacion.RegistrarFactura(CedulaCliente, CodigoProduc, UnidadesCompradas, Nuevo, DescuentoAplicar, NumPedido);

                //Refrescamos la lista
                GestionFactura gestionFactura = new GestionFactura();
                dataGridViewFacturacion.DataSource = gestionFactura.ListaTodasFacturas();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Facturación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCedulaCliente.Clear();
                txtCod_Produc.Clear();
                txtUnidadesCompra.Clear();
                txtDescuentoFactura.Clear();
                txtNumeroPedido.Clear();
            }
            else
            {
                Console.WriteLine("1");
            }
        }


        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarFactura }))
            {
                // Obtener el ID de la factura
                int idFactura = int.Parse(txtBuscarFactura.Text);

                // Crear una instancia de GestionFacturacion y llamar al método BuscarFactura
                GestionFactura gestionFacturacion = new GestionFactura();
                DataTable resultado = gestionFacturacion.BuscarFactura(idFactura);

                // Mostrar el resultado en un DataGridView
                dataGridViewFacturacion.DataSource = resultado;

                txtBuscarFactura.Clear();
            }
            else
            {
                Console.WriteLine("1");
            }
        }





        private void btnGuardarmarca_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtNombreMarca }))
            {

                // Obtener los valores de los controles

                string NombreMarca = txtNombreMarca.Text;




                // Crear una instancia de GestionMarcas y llamar al método RegistrarMarca
                GestionMarcas gestionmarcas = new GestionMarcas();
                string resultado = gestionmarcas.RegistrarMarca(NombreMarca);

                //Refrescamos la lista

                dataGridViewMarcas.DataSource = gestionmarcas.ListaTodasMarcas();

                txtNombreMarca.Clear();
                txtIdMarca.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarMarca }))
            {
                // Obtener el ID de la marca
                int idMarca = int.Parse(txtBuscarMarca.Text);

                // Crear una instancia de GestionMarcas y llamar al método BuscarMarca
                GestionMarcas gestionmarca = new GestionMarcas();
                DataTable resultado = gestionmarca.BuscarMarca(idMarca);

                // Mostrar el resultado en un DataGridView
                dataGridViewMarcas.DataSource = resultado;

                txtBuscarMarca.Clear();
            }
            else { Console.WriteLine("1"); }
        }

        private void btnActualizarMarca_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdMarca, txtNombreMarca }))
            {
                // Obtener los valores de los controles
                int idMarca = int.Parse(txtIdMarca.Text);
                string NombreMarca = txtNombreMarca.Text;



                // Crear una instancia de GestionMarca y llamar al método ActualizarMarca
                GestionMarcas gestionmarcas = new GestionMarcas();
                string resultado = gestionmarcas.ActualizarMarca(idMarca, NombreMarca);

                dataGridViewMarcas.DataSource = gestionmarcas.ListaTodasMarcas();

                txtNombreMarca.Clear();
                txtIdMarca.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización de la Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdMarca }))
            {
                // Obtener los valores de los controles
                int idMarca = int.Parse(txtIdMarca.Text);


                // Crear una instancia de GestionMarca y llamar al método EliminarMarca
                GestionMarcas gestionmarcas = new GestionMarcas();
                string resultado = gestionmarcas.EliminarMarca(idMarca);

                dataGridViewMarcas.DataSource = gestionmarcas.ListaTodasMarcas();

                txtNombreMarca.Clear();
                txtIdMarca.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de eliminar la Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        private void dataGridViewMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMarcas.Rows[e.RowIndex];

                txtIdMarca.Text = row.Cells["id"].Value.ToString();
                txtNombreMarca.Text = row.Cells["nombre_marca"].Value.ToString();



            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdProducto, txtNombreProducto, txtIddeMarca, txtCantidadStock, txtIdProveedor, txtPrecioProducto }))
            {
                // Obtener los valores de los controles

                int IdProducto = int.Parse(txtIdProducto.Text);
                string NombreProducto = txtNombreProducto.Text;
                int IdMarca = int.Parse(txtIddeMarca.Text);
                double CantidadStock = double.Parse(txtCantidadStock.Text);
                string IdProveedor = txtIdProveedor.Text;
                int PrecioProducto = int.Parse(txtPrecioProducto.Text);


                // Crear una instancia de Gestionproductos y llamar al método RegistrarProducto
                GestionProductos gestionproductos = new GestionProductos();
                string resultado = gestionproductos.RegistrarProductos(IdProducto, NombreProducto, IdMarca, CantidadStock, IdProveedor, PrecioProducto);

                //Refrescamos la lista

                dataGridViewProductos.DataSource = gestionproductos.ListaTodasProductos();

                txtIdProducto.Clear();
                txtNombreProducto.Clear();
                txtIddeMarca.Clear();
                txtCantidadStock.Clear();
                txtIdProveedor.Clear();
                txtPrecioProducto.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdProducto, txtNombreProducto, txtIddeMarca, txtCantidadStock, txtIdProveedor, txtPrecioProducto }))
            {
                // Obtener los valores de los controles
                int IdProducto = int.Parse(txtIdProducto.Text);
                string NombreProducto = txtNombreProducto.Text;
                int IdMarca = int.Parse(txtIddeMarca.Text);
                double CantidadStock = double.Parse(txtCantidadStock.Text);
                string IdProveedor = txtIdProveedor.Text;
                int PrecioProducto = int.Parse(txtPrecioProducto.Text);



                // Crear una instancia de GestionProducto y llamar al método ActualizarProducto
                GestionProductos gestionproductos = new GestionProductos();
                string resultado = gestionproductos.ActualizarProducto(IdProducto, NombreProducto, IdMarca, CantidadStock, IdProveedor, PrecioProducto);

                dataGridViewMarcas.DataSource = gestionproductos.ListaTodasProductos();

                txtIdProducto.Clear();
                txtNombreProducto.Clear();
                txtIddeMarca.Clear();
                txtCantidadStock.Clear();
                txtIdProveedor.Clear();
                txtPrecioProducto.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarProducto }))
            {
                // Obtener el ID del Producto
                int idProducto = int.Parse(txtBuscarProducto.Text);

                // Crear una instancia de GestionProducto y llamar al método BuscarProducto
                GestionProductos gestionproductos = new GestionProductos();
                DataTable resultado = gestionproductos.BuscarProducto(idProducto);

                // Mostrar el resultado en un DataGridView
                dataGridViewProductos.DataSource = resultado;

                txtBuscarProducto.Clear();
            }
            else { Console.WriteLine("1"); }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdProducto }))
            {
                // Obtener los valores de los controles
                int idProducto = int.Parse(txtIdProducto.Text);


                // Crear una instancia de GestionProducto y llamar al método ActualizarProducto
                GestionProductos gestionproductos = new GestionProductos();
                string resultado = gestionproductos.EliminarProducto(idProducto);

                dataGridViewMarcas.DataSource = gestionproductos.ListaTodasProductos();

                txtIdProducto.Clear();
                txtNombreProducto.Clear();
                txtIddeMarca.Clear();
                txtCantidadStock.Clear();
                txtIdProveedor.Clear();
                txtPrecioProducto.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];

                txtIdProducto.Text = row.Cells["id"].Value.ToString();
                txtNombreProducto.Text = row.Cells["nombreProducto"].Value.ToString();
                txtIddeMarca.Text = row.Cells["marca"].Value.ToString();
                txtCantidadStock.Text = row.Cells["stock"].Value.ToString();
                txtIdProveedor.Text = row.Cells["proveedor"].Value.ToString();
                txtPrecioProducto.Text = row.Cells["PrecioProducto"].Value.ToString();



            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { IDDEPROVEEDOR, txtNombreProveedor, txtTelefonoProveedor, txtCorreoProveedor }))
            {
                // Obtener los valores de los controles

                string IdProveedor = IDDEPROVEEDOR.Text;
                string NombreProveedor = txtNombreProveedor.Text;
                string TelefonoProveedor = txtTelefonoProveedor.Text;
                string CorreoProveedor = txtCorreoProveedor.Text;



                // Crear una instancia de Gestionproveedores y llamar al método RegistrarProveedores
                GestionProveedores gestionproveedores = new GestionProveedores();
                string resultado = gestionproveedores.RegistrarProveedor(IdProveedor, NombreProveedor, TelefonoProveedor, CorreoProveedor);

                //Refrescamos la lista

                dataGridViewProveedores.DataSource = gestionproveedores.ListaTodasProveedor();

                txtIdProveedor.Clear();
                txtNombreProducto.Clear();
                txtTelefonoProveedor.Clear();
                txtCorreoProveedor.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado del Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdProveedor, txtNombreProveedor, txtTelefonoProveedor, txtCorreoProveedor }))
            {
                // Obtener los valores de los controles
                string IdProveedor = txtIdProducto.Text;
                string NombreProveedor = txtNombreProveedor.Text;
                string TelefonoProveedor = txtTelefonoProveedor.Text;
                string CorreoProveedor = txtCorreoProveedor.Text;



                // Crear una instancia de GestionProveedory llamar al método ActualizarProveedor
                GestionProveedores gestionproveedores = new GestionProveedores();
                string resultado = gestionproveedores.ActualizarProveedor(IdProveedor, NombreProveedor, TelefonoProveedor, CorreoProveedor);

                dataGridViewProveedores.DataSource = gestionproveedores.ListaTodasProveedor();

                txtIdProveedor.Clear();
                txtNombreProveedor.Clear();
                txtTelefonoProveedor.Clear();
                txtCorreoProveedor.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { Console.WriteLine("1"); }
        }

        private void btnBuscarproveedor_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarProveedor }))
            {
                // Obtener el ID del Proveedor
                string idProveedor = txtBuscarProveedor.Text;

                // Crear una instancia de GestionProveedor y llamar al método BuscarProveedor
                GestionProveedores gestionproveedores = new GestionProveedores();
                DataTable resultado = gestionproveedores.BuscarProveedor(idProveedor);

                // Mostrar el resultado en un DataGridView
                dataGridViewProveedores.DataSource = resultado;

                txtBuscarProveedor.Clear();
            }
            else { Console.WriteLine("1"); }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdProveedor }))
            {
                // Obtener los valores de los controles
                string idProveedor = txtIdProveedor.Text;


                // Crear una instancia de GestionProveedor y llamar al método ActualizarProveedor
                GestionProveedores gestionproveedores = new GestionProveedores();
                string resultado = gestionproveedores.EliminarProveedor(idProveedor);

                dataGridViewProveedores.DataSource = gestionproveedores.ListaTodasProveedor();

                txtIdProveedor.Clear();
                txtNombreProducto.Clear();
                txtTelefonoProveedor.Clear();
                txtCorreoProveedor.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        private void dataGridViewProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProveedores.Rows[e.RowIndex];

                txtIdProveedor.Text = row.Cells["idProveedor"].Value.ToString();
                txtNombreProveedor.Text = row.Cells["nombre_proveedor"].Value.ToString();
                txtTelefonoProveedor.Text = row.Cells["telefono"].Value.ToString();
                txtCorreoProveedor.Text = row.Cells["correo"].Value.ToString();

            }
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.CamposVacios(new object[] { txtIDCliente, txtNombre, txtApellidoCliente, txtTelCliente, txtEmailCliente }))
            {

            }
            else
            {
                Console.WriteLine("1");
                GestionCliente GesClientes = new GestionCliente();
                GesClientes.RegistrarCliente(txtIDCliente.Text, txtNombre.Text, txtApellidoCliente.Text, txtTelCliente.Text, txtEmailCliente.Text);
                dataGridViewClientes.DataSource = GesClientes.ImprimirConsulta("Select * from clientes");
            }

        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarCliente }))
            {
                GestionCliente GesClientes = new GestionCliente();

                dataGridViewClientes.DataSource = GesClientes.BuscarCliente(txtBuscarCliente.Text);
            }
            else
            {
                Console.WriteLine("1");
            }

        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIDCliente, txtNombre, txtApellidoCliente, txtTelCliente, txtEmailCliente }))
            {
                // Obtener los valores de los controles
                string IDCliente = txtIDCliente.Text;
                string Nombre = txtNombre.Text;
                string ApellidoCliente = txtApellidoCliente.Text;
                string TelCliente = txtTelCliente.Text;
                string CorreoCliente = txtEmailCliente.Text;

                // Instanciar la clase para gestionar clientes
                GestionCliente GesClientes = new GestionCliente();

                // Actualizar el cliente y obtener el resultado
                string resultado = GesClientes.ActualizarCliente(IDCliente, Nombre, ApellidoCliente, TelCliente, CorreoCliente);

                // Actualizar el DataGridView con la lista actualizada de clientes
                DataTable dt = GesClientes.ListarClientes();
                Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                dataGridViewClientes.DataSource = dt;

                // Limpiar los campos de texto
                txtIDCliente.Clear();
                txtNombre.Clear();
                txtApellidoCliente.Clear();
                txtEmailCliente.Clear();
                txtTelCliente.Clear();

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("Campos vacíos.");
            }
        }


        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada para eliminar
            if (dataGridViewClientes.SelectedRows.Count > 0)
            {
                // Obtener el ID del cliente seleccionado
                string idCliente = dataGridViewClientes.SelectedRows[0].Cells["idCliente"].Value.ToString();

                // Confirmar con el usuario antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Instanciar la clase para gestionar clientes
                        GestionCliente gesClientes = new GestionCliente();

                        // Llamar al método para eliminar el cliente de la base de datos
                        string mensaje = gesClientes.EliminarCliente(idCliente);

                        // Mostrar mensaje de éxito
                        MessageBox.Show(mensaje, "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView con la lista actualizada de clientes
                        DataTable dt = gesClientes.ListarClientes();
                        Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                        dataGridViewClientes.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }







        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIDPedido, txtIdPedidoCliente, ComboBoxEstadoPedido, FechaPedido, txtNombreCliente }))
            {
                GestionPedidos GesPedidos = new GestionPedidos();
                GesPedidos.RegistrarPedido(Convert.ToInt32(txtIDPedido.Text), txtIdPedidoCliente.Text, ComboBoxEstadoPedido.SelectedItem.ToString(), FechaPedido.Value, txtNombreCliente.Text);
                dataGridView2Pedidos.DataSource = GesPedidos.ImprimirConsulta("Select * from pedidos");
            }
            else
            {
                Console.WriteLine("1");
            }

        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarPedido }))
            {
                GestionPedidos GesPedido = new GestionPedidos();

                dataGridView2Pedidos.DataSource = GesPedido.BuscarPedido(txtBuscarPedido.Text);
            }
            else
            {
                Console.WriteLine("1");
            }

        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIDPedido, txtIdPedidoCliente, ComboBoxEstadoPedido, FechaPedido, txtNombreCliente }))
            {
                // Obtener los valores de los controles
                int IDPedido = int.Parse(txtIDPedido.Text);
                string CedulaClientePide = txtIdPedidoCliente.Text;
                string NombreCliente = txtNombreCliente.Text;
                string ComboEstadoPedi = ComboBoxEstadoPedido.Text;
                DateTime Fecha = FechaPedido.Value; // Utiliza el valor del DateTimePicker

                // Instanciar la clase para gestionar pedidos
                GestionPedidos GesPedido = new GestionPedidos();

                // Actualizar el pedido y obtener el resultado
                string resultado = GesPedido.ActualizarPedido(IDPedido, CedulaClientePide, NombreCliente, ComboEstadoPedi, Fecha);

                // Actualizar el DataGridView con la lista actualizada de pedidos
                DataTable dt = GesPedido.ListarPedidos();
                Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                dataGridView2Pedidos.DataSource = dt;

                // Limpiar los campos de texto
                txtIDPedido.Clear();
                txtIdPedidoCliente.Clear();
                txtNombreCliente.Clear();
                ComboBoxEstadoPedido.SelectedIndex = -1; // Desseleccionar el combobox
                FechaPedido.Value = DateTime.Now; // Resetear la fecha

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("Campos vacíos.");
            }
        }



        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada para eliminar
            if (dataGridView2Pedidos.SelectedRows.Count > 0)
            {
                // Obtener el ID del pedido seleccionado
                int idPedido = Convert.ToInt32(dataGridView2Pedidos.SelectedRows[0].Cells["idPedido"].Value);

                // Confirmar con el usuario antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este pedido?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Instanciar la clase para gestionar pedidos
                        GestionPedidos gesPedidos = new GestionPedidos();

                        // Llamar al método para eliminar el pedido de la base de datos
                        string mensaje = gesPedidos.EliminarPedido(idPedido);

                        // Mostrar mensaje de éxito
                        MessageBox.Show(mensaje, "Eliminar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView con la lista actualizada de pedidos
                        DataTable dt = gesPedidos.ListarPedidos();
                        Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                        dataGridView2Pedidos.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un pedido para eliminar.", "Pedido no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }









        private void btnRegistrarCredito_Click(object sender, EventArgs e)
        {
            // Mensaje de depuración para verificar el valor del campo de texto
            Console.WriteLine($"Valor de idcredito: '{idcredito.Text}'");
            Console.WriteLine($"Valor de txtIdPedidoCred: '{txtIdPedidoCred.Text}'");
            Console.WriteLine($"Valor de ComboBoxEstadoCredito: '{ComboBoxEstadoCredito.SelectedItem?.ToString()}'");
            Console.WriteLine($"Valor de FechaCredito: '{FechaCredito.Value}'");

            if (!string.IsNullOrWhiteSpace(idcredito.Text) &&
                !string.IsNullOrWhiteSpace(txtIdPedidoCred.Text) &&
                ComboBoxEstadoCredito.SelectedItem != null &&
                FechaCredito.Value != null)
            {
                try
                {
                    int IdCredito = Convert.ToInt32(idcredito.Text);
                    int IdPedidoCred = Convert.ToInt32(txtIdPedidoCred.Text);
                    string Estado = ComboBoxEstadoCredito.SelectedItem.ToString();
                    DateTime Fecha = FechaCredito.Value;

                    GestionCréditos GesCreditos = new GestionCréditos();
                    string resultado = GesCreditos.RegistrarCredito(IdCredito, IdPedidoCred, Estado, Fecha);

                    MessageBox.Show(resultado, "Resultado de la Actualización del Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridViewCreditos.DataSource = GesCreditos.ListaTodosCreditos();

                    idcredito.Clear();
                    txtIdPedidoCred.Clear();
                    ComboBoxEstadoCredito.SelectedIndex = -1;
                    FechaCredito.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBuscarCredito_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarCredito }))
            {
                GestionCréditos GesCredito = new GestionCréditos();
                dataGridViewCreditos.DataSource = GesCredito.BuscarCredito(txtBuscarCredito.Text);
            }
            else
            {
                Console.WriteLine("1");
            }


        }

        private void btnActualizarCredito_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Iniciando validación de campos...");
            Console.WriteLine($"Valor de idcredito: '{idcredito.Text}'");
            Console.WriteLine($"Valor de txtIdPedidoCred: '{txtIdPedidoCred.Text}'");
            Console.WriteLine($"Valor de ComboBoxEstadoCredito: '{ComboBoxEstadoCredito.SelectedItem?.ToString()}'");
            Console.WriteLine($"Valor de FechaCredito: '{FechaCredito.Value}'");

            if (!string.IsNullOrWhiteSpace(idcredito.Text) &&
                !string.IsNullOrWhiteSpace(txtIdPedidoCred.Text) &&
                ComboBoxEstadoCredito.SelectedItem != null &&
                FechaCredito.Value != null)
            {
                try
                {
                    int IdCredito = Convert.ToInt32(idcredito.Text);
                    int IdPedidoCred = Convert.ToInt32(txtIdPedidoCred.Text);
                    string Estado = ComboBoxEstadoCredito.SelectedItem.ToString();
                    DateTime Fecha = FechaCredito.Value;

                    GestionCréditos GesCredito = new GestionCréditos();
                    string resultado = GesCredito.ActualizarCredito(IdCredito, IdPedidoCred, Estado, Fecha);

                    Console.WriteLine($"Resultado de la actualización: {resultado}");

                    dataGridViewCreditos.DataSource = GesCredito.ListaTodosCreditos();

                    idcredito.Clear();
                    txtIdPedidoCred.Clear();
                    ComboBoxEstadoCredito.SelectedIndex = -1;
                    FechaCredito.Value = DateTime.Now;

                    MessageBox.Show(resultado, "Resultado de la Actualización del Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnGuardarCredito_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdCredito, txtIdPedidoCred, ComboBoxEstadoCredito, FechaCredito }))
            {
                GestionCréditos GesCreditos = new GestionCréditos();
                GesCreditos.RegistrarCredito(Convert.ToInt32(txtIdCredito.Text), Convert.ToInt32(txtIdPedidoCred.Text), ComboBoxEstadoCredito.SelectedItem.ToString(), FechaCredito.Value);
                dataGridViewCreditos.DataSource = GesCreditos.ImprimirConsulta("SELECT * FROM credito");
            }
            else
            {
                Console.WriteLine("Campos vacíos.");
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    


    private void btnEliminarCredito_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada para eliminar
            if (dataGridViewCreditos.SelectedRows.Count > 0)
            {
                // Obtener el ID del crédito seleccionado
                int idCredito = Convert.ToInt32(dataGridViewCreditos.SelectedRows[0].Cells["idCredito"].Value);

                // Confirmar con el usuario antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este crédito?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Instanciar la clase para gestionar créditos
                        GestionCréditos gesCreditos = new GestionCréditos();

                        // Llamar al método para eliminar el crédito de la base de datos
                        string mensaje = gesCreditos.EliminarCredito(idCredito);

                        // Mostrar mensaje de éxito
                        MessageBox.Show(mensaje, "Eliminar Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView con la lista actualizada de créditos
                        DataTable dt = gesCreditos.ListaTodosCreditos();
                        Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                        dataGridViewCreditos.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el crédito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un crédito para eliminar.", "Crédito no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnGuardarAbono_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdAbono, txtMonto, ComboTipoPago, txtNumComprobante, txtIdCredito, dateTimePickerAbono }))
            {
                GestionAbonos GesAbonos = new GestionAbonos();
                GesAbonos.RegistrarAbono(Convert.ToInt32(txtIdAbono.Text), Convert.ToDouble(txtMonto.Text), ComboTipoPago.Text, txtNumComprobante.Text, Convert.ToInt32(txtIdCredito.Text), dateTimePickerAbono.Value);
                dataGridViewAbonos.DataSource = GesAbonos.ImprimirConsulta("Select * from abonos");
            }
            else
            {
                Console.WriteLine("1");
            }

        }



        public static string usuario1 = "";

        private void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {
            GestionUsuario dbUsuario = new GestionUsuario();
            dbUsuario.AbrirConexion(dbUsuario.EstablecerConexion());

            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("No ingreso el nombre de usuario");
            }
            else
            {
                if (txtContraseña.Text.Equals("") || txtConfirmaContraseña.Text.Equals(""))
                {
                    MessageBox.Show("No ingresaste las contraseñas");
                }
                else
                {
                    if (!txtContraseña.Text.Equals(txtConfirmaContraseña.Text))
                    {
                        MessageBox.Show("Las contraseñas NO coinciden");
                    }
                    else
                    {
                        string usuarioRegistrar = txtUsuario.Text;
                        string password = txtContraseña.Text;




                        if (!dbUsuario.Verificar_Usuario_Contra(txtUsuario.Text, txtContraseña.Text))
                        {
                            dbUsuario.RegistrarUsuario(usuarioRegistrar, password);

                            MessageBox.Show($"Usuario: {usuarioRegistrar} creado exitosamente");
                            DialogResult respuesta = MessageBox.Show("Desea autenticarte con este usuario?", "Pregunta", MessageBoxButtons.OKCancel);
                            switch (respuesta)
                            {
                                case DialogResult.OK:
                                    usuario1 = usuarioRegistrar;
                                    this.Dispose();
                                    break;
                                case DialogResult.Cancel:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"El usuario {usuarioRegistrar} ya existe dentro de la base de datos");
                        }
                    }
                }
            }
        }

        private void btnBuscarAbono_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtBuscarAbono }))
            {
                GestionAbonos GesAbono = new GestionAbonos();
                dataGridViewAbonos.DataSource = GesAbono.BuscarAbono(txtBuscarAbono.Text);
            }
            else
            {
                Console.WriteLine("1");
            }
        }

        private void btnActualizarAbono_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            Login login = new Login();
            if (!login.CamposVacios(new object[] { txtIdAbono, txtMonto, ComboTipoPago, txtNumComprobante, txtIdCredito, dateTimePickerAbono }))
            {
                // Obtener los valores de los controles
                int IdAbono = int.Parse(txtIdAbono.Text);
                int Monto = int.Parse(txtMonto.Text);
                string TipoPago = ComboTipoPago.Text;
                string NumComprobante = txtNumComprobante.Text;
                int IdCredito = int.Parse(txtIdCredito.Text);
                DateTime Fecha = dateTimePickerAbono.Value;

                // Instanciar la clase para gestionar abonos
                GestionAbonos GesAbono = new GestionAbonos();

                // Actualizar el abono y obtener el resultado
                string resultado = GesAbono.ActualizarAbono(IdAbono, Monto, TipoPago, NumComprobante, IdCredito, Fecha);

                // Actualizar el DataGridView con la lista actualizada de abonos
                dataGridViewAbonos.DataSource = GesAbono.ListaTodosAbonos();

                // Limpiar los campos de texto
                txtIdAbono.Clear();
                txtMonto.Clear();
                txtNumComprobante.Clear();
                txtIdCredito.Clear();
                ComboTipoPago.SelectedIndex = -1; // Desseleccionar el combobox
                dateTimePickerAbono.Value = DateTime.Now; // Resetear la fecha

                // Mostrar el resultado
                MessageBox.Show(resultado, "Resultado de la Actualización del Abono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("Campos vacíos.");
            }
        }


        private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmailCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '"' || e.KeyChar == '*')
            {
                e.Handled = true; // Si es una comilla o asterisco, manejar el evento
            }
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras, números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtTelCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIDPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdPedidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialTextBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdPedidoCred_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIddeMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidadStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IDDEPROVEEDOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUnidadesCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDescuentoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar números y teclas de control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras, números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtConfirmaContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras, números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void btnEliminarAbono_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada para eliminar
            if (dataGridViewAbonos.SelectedRows.Count > 0)
            {
                // Imprimir nombres de columnas para depuración
                foreach (DataGridViewColumn column in dataGridViewAbonos.Columns)
                {
                    Console.WriteLine(column.Name);
                }

                // Usar el nombre correcto de la columna
                int idAbono = Convert.ToInt32(dataGridViewAbonos.SelectedRows[0].Cells["idAbonos"].Value); // Cambia "IdAbono" por el nombre exacto de la columna si es diferente

                // Confirmar con el usuario antes de eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este abono?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Instanciar la clase para gestionar abonos
                        GestionAbonos gesAbonos = new GestionAbonos();

                        // Llamar al método para eliminar el abono de la base de datos
                        string mensaje = gesAbonos.EliminarAbono(idAbono);

                        // Mostrar mensaje de éxito
                        MessageBox.Show(mensaje, "Eliminar Abono", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar el DataGridView con la lista actualizada de abonos
                        DataTable dt = gesAbonos.ListaTodosAbonos();
                        Console.WriteLine($"Número de filas obtenidas para mostrar: {dt.Rows.Count}");
                        dataGridViewAbonos.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el abono: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un abono para eliminar.", "Abono no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIdPedidoCred_TextChanged(object sender, EventArgs e)
        {

        }

        private void idcredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerReportFactura_Click(object sender, EventArgs e)
        {
            ReporteFacturacion reporteFacturacion = new ReporteFacturacion();
            reporteFacturacion.Show();
        }
    }
}
