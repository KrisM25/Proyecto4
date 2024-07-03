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
            GestionCliente GesClientes = new GestionCliente();
            GesClientes.RegistrarCliente(txtIDCliente.Text, txtNombre.Text, txtApellidoCliente.Text, txtTelCliente.Text, txtEmailCliente.Text);
            dataGridViewClientes.DataSource = GesClientes.ImprimirConsulta("Select * from clientes");
        }

        private void btBuscarCliente_Click(object sender, EventArgs e)
        {
            GestionCliente GesClientes = new GestionCliente();

            dataGridViewClientes.DataSource = GesClientes.BuscarCliente(txtBuscarCliente.Text);
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            GestionPedidos GesPedidos = new GestionPedidos();
            GesPedidos.RegistrarPedido(Convert.ToInt32(txtIDPedido.Text), txtIdPedidoCliente.Text, ComboBoxEstadoPedido.SelectedItem.ToString(), FechaPedido.Value, txtNombreCliente.Text);
            dataGridView2Pedidos.DataSource = GesPedidos.ImprimirConsulta("Select * from pedidos");
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            GestionPedidos GesPedido = new GestionPedidos();

            dataGridView2Pedidos.DataSource = GesPedido.BuscarPedido(txtBuscarPedido.Text);
        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCredito_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCredito_Click(object sender, EventArgs e)
        {
            GestionCréditos GesCredito = new GestionCréditos();
            dataGridViewCreditos.DataSource = GesCredito.BuscarCredito(txtBuscarCredito.Text);

        }

        private void btnActualizarCredito_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCredito_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAbono_Click(object sender, EventArgs e)
        {
            GestionAbonos GesAbonos = new GestionAbonos();
            GesAbonos.RegistrarAbono(Convert.ToInt32(txtIdAbono.Text), Convert.ToDouble(txtMonto.Text), ComboTipoPago.Text, txtNumComprobante.Text, Convert.ToInt32(txtIdCredito.Text), dateTimePickerAbono.Value);
            dataGridViewAbonos.DataSource = GesAbonos.ImprimirConsulta("Select * from abonos");
        }



        public static string usuario1 = "";
        private void btnCrearUsuario_Click(object sender, EventArgs e)
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
    }
}