using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4.Clases
{
    public class UsuarioLogin
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswdUsuario { get; set; }

        public UsuarioLogin() { }

        public UsuarioLogin(int Id_p, string nombreUsuario_p, string passwdUsuario_p)
        {
            this.Id = Id_p;
            this.NombreUsuario = nombreUsuario_p;
            this.PasswdUsuario = passwdUsuario_p;
        }
    }
}
