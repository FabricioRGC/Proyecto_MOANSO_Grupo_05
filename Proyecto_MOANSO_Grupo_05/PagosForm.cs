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
using static CapaEntidad.Pago;
using Microsoft.VisualBasic.Logging;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PagosForm : Form
    {
        public PagosForm()
        {
            InitializeComponent();
            listarPagos();
        }

        public void listarPagos()
        {
            tablaPagos.DataSource = logPago.Instancia.ListarPagos();
        }

        public void limpiarVariables()
        {
            txtContrato.Text = "";
            txtMonto.Text = "";
            txtCliente.Text = "";
            cbMetodo.SelectedIndex = -1;
        }

        // ----- ACCIONES -----

        // Botón para añadir un pago
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pag = new entPago();
                pag.contrato_id = txtContrato.Text;
                pag.monto = txtMonto.Text;
                pag.cliente_id = txtCliente.Text;
                pag.metodo_pago = cbMetodo.Text;
                logPago.Instancia.InsertarPago(pag);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
            listarPagos();
        }

        // Botón para anular un pago
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pag = new entPago();
                pag.contrato_id = txtContrato.Text;
                pag.cliente_id = txtCliente.Text;
                logPago.Instancia.AnularPago(pag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
            listarPagos();
        }
    }
}
