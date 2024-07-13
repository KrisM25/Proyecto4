using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Proyecto4.Clases;
using Proyecto4.GestionBD;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Collections.Specialized.BitVector32;

namespace Proyecto4.Formularios
{
    public partial class Login : MaterialForm
    {
        public int intentos = 3;

        public Login()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            //aca vamos a configurar el color
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Pink300, Primary.Pink400,
                Primary.Pink100, Accent.Pink700,
                TextShade.WHITE);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GestionUsuario bdUsuario = new GestionUsuario();
            bdUsuario.AbrirConexion(bdUsuario.EstablecerConexion());



            if (!CamposVacios(new object[] { txtUsuario, txtContraseña }))

                if (bdUsuario.Verificar_Usuario_Contra(txtUsuario.Text, txtContraseña.Text) == true)
                {
                    Menú_Admin menuAdminForm = new Menú_Admin();
                    menuAdminForm.Show();
                    this.Hide();
                }
                else
                {
                    intentos--;

                    if (intentos > 0)
                    {
                        MessageBox.Show($"Usuario o contraseña incorrecta. Te quedan {intentos} intentos");
                    }
                    else if (intentos == 0)
                    {
                        MessageBox.Show("Has agotado todos los intentos. El sistema se cerrará.");
                        Application.Exit();
                    }
                }
        }
        public bool CamposVacios(object[] campos)
        {
            bool vacios = false;

            for (int i = 0; i < campos.Length; i++)
            {
                if (campos[i] is TextBox textBox)
                {
                    Console.WriteLine($"Verificando campo: {textBox.Name}, Valor: {textBox.Text}");
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show($"El campo {textBox.Name} está vacío.");
                        vacios = true;
                        break;
                    }
                }
                else if (campos[i] is MaterialTextBox2 materialTextBox)
                {
                    Console.WriteLine($"Verificando campo: {materialTextBox.Name}, Valor: {materialTextBox.Text}");
                    if (string.IsNullOrEmpty(materialTextBox.Text))
                    {
                        MessageBox.Show($"El campo {materialTextBox.Name} está vacío.");
                        vacios = true;
                        break;
                    }
                }
                else if (campos[i] is MaterialTextBox materialTextBox1)
                {
                    Console.WriteLine($"Verificando campo: {materialTextBox1.Name}, Valor: {materialTextBox1.Text}");
                    if (string.IsNullOrEmpty(materialTextBox1.Text))
                    {
                        MessageBox.Show($"El campo {materialTextBox1.Name} está vacío.");
                        vacios = true;
                        break;
                    }
                }
                else if (campos[i] is ComboBox comboBox)
                {
                    Console.WriteLine($"Verificando campo: {comboBox.Name}, Valor: {comboBox.Text}");
                    if (string.IsNullOrEmpty(comboBox.Text))
                    {
                        MessageBox.Show($"El campo {comboBox.Name} está vacío.");
                        vacios = true;
                        break;
                    }
                }
                else if (campos[i] is DateTimePicker dateTimePicker)
                {
                    Console.WriteLine($"Verificando campo: {dateTimePicker.Name}, Valor: {dateTimePicker.Value}");
                    if (dateTimePicker.Value == DateTime.MinValue)
                    {
                        MessageBox.Show("La fecha seleccionada es inválida.");
                        vacios = true;
                        break;
                    }
                }
                else
                {
                    MessageBox.Show($"El tipo de campo no es compatible para la validación: {campos[i].GetType().Name}");
                    vacios = true;
                    break;
                }
            }

            return vacios;
        }






        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo pueden ingresar letras, números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
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
    }
}
