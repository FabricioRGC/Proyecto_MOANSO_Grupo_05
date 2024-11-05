using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
using static CapaEntidad.PedidoInstalacion;
using static CapaEntidad.Repuesto;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenesPedidoInstalacionForm : Form
    {
        public OrdenesPedidoInstalacionForm()
        {
            InitializeComponent();
            cboTipoInstalacion.Items.Add("Internet");
            cboTipoInstalacion.Items.Add("Cable");
            cboTipoInstalacion.Items.Add("Telefonía");
            cboTipoInstalacion.SelectedIndex = 0;
        }

        private void limpiarVariables()
        {
            txtNumOrden.Text = "";
            txtIdInstalacion.Text = "";
            dtpFechaOrden.Value = DateTime.Now;
            txtTelefono.Text = "";
            txtIDJefeSoporteTecnico.Text = "";
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            mtbHoraInicio.Text = "";
            mtbHoraFinal.Text = "";
            cboTipoInstalacion.SelectedIndex = 0;
            txtUbicacion.Text = "";
            txtDescripcion.Text = "";
            txtObservaciones.Text = "";
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new PedidoInstalacionHistorialForm();
            historial.Show();
        }
    }
}
