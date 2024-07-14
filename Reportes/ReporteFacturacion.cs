using Proyecto4.GestionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto4.Reportes
{
    public partial class ReporteFacturacion : Form
    {
        public ReporteFacturacion()
        {
            InitializeComponent();
        }

        private void ReporteFacturacion_Load(object sender, EventArgs e)
        {
            GestionReporte gestionReporte = new GestionReporte();
            dataFacturacionBindingSource.DataSource = gestionReporte.ReporteFacturacion().Tables[0];

            this.reportViewer1.RefreshReport();
        }
    }
}
