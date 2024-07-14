using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Proyecto4.GestionBD;

namespace Proyecto4.Formularios
{
    public partial class Apii : MaterialForm
    {
        string mensaje;
        string AppiKey = "ba36a60161e5338a0e8ee42cde9c3300";
        Random random = new Random();


        public Apii()
        {
            InitializeComponent();
        }

        private void Apii_Load(object sender, EventArgs e)
        {

        }

        private async void SolicitarCodigo_Click(object sender, EventArgs e)
        {
            GestionUsuario gestionUsuario = new GestionUsuario();
            DataTable Usuario = gestionUsuario.AppiUsuario(txtUsuario.Text);

            if (Usuario.Rows.Count > 0)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string telefono = txtTelefono.Text;
                        mensaje = random.Next(100000).ToString();
                        var Respuesta = await client.GetAsync($"http://api.sms506.com/sms/{AppiKey}/t={telefono}&m={mensaje}");
                        Respuesta.EnsureSuccessStatusCode();
                        string Estado = await Respuesta.Content.ReadAsStringAsync();
                        MessageBox.Show("Se ha enviado el codigo correctamente");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("No existe el usuario");
            }
        }

        private void VerificarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                GestionUsuario gestionUsers = new GestionUsuario();
                DataTable Usuario = gestionUsers.AppiUsuario(txtUsuario.Text);

                if (Usuario.Rows.Count > 0)
                {
                    if (mensaje == txtCodigo.Text)
                    {


                        gestionUsers.ActualizarContrasenia(Usuario.Rows[0][0].ToString(), txtContraseña.Text);
                        MessageBox.Show("Se actualizo la contraseña");
                        //se llama al procedimiento almacenado de actualizar contraseña
                    }
                    else
                    {
                        MessageBox.Show("Cuerpo incorrecto");
                    }
                }
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message); }
        }
        
    }
}

        
      

