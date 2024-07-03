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

namespace Proyecto4.Formularios
{
    public partial class Detalle_Pedido : MaterialForm
    {
        public Detalle_Pedido()
        {
            InitializeComponent();
        }

        private void Detalle_Pedido_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Menú_Admin NewMenú = new Menú_Admin();
            NewMenú.Show();
        }
    }
}
