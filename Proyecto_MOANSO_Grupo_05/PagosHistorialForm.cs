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
using static CapaEntidad.Pago;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PagosHistorialForm : Form
    {
        public PagosHistorialForm()
        {
            InitializeComponent();
            listarPagos();
        }

        public void listarPagos()
        {
            tablaPagos.DataSource = logPago.Instancia.ListarPagos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pago = new entPago();
                pago.contrato_id = txtCodigoCliente.Text.Trim();
                logPago.Instancia.AnularPago(pago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarPagos();
            txtCliente.Text = "";
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtCliente.Text;

            //var nombresFiltrados = logPago.Instancia.ListarPagos().Where(pago => pago.nombre_cliente.Contains(nombre)).ToList();

            //tablaPagos.DataSource = nombresFiltrados;
        }
    }
}
