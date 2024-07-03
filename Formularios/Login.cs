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
                    MessageBox.Show("***Ingreso Exitoso***");
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

        public bool CamposVacios(Object[] campos)
        {
            bool vacios = false;

            for (int i = 0; i < campos.Length; i++)
            {
                // Aquí convertimos la posicion actual del campo texbox
                MaterialTextBox campo = (MaterialTextBox)campos[i];
                if (string.IsNullOrEmpty(campo.Text))
                {
                    MessageBox.Show($"El campo {campo.Hint} está vacío");
                    vacios = true;
                    break;
                }

            }
            return vacios;
        }


    }
}
