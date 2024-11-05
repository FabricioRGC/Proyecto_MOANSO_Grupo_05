using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using static CapaEntidad.OrdenPedidoRepuestos;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenPedidoRepuestoForm : Form
    {
        public OrdenPedidoRepuestoForm()
        {
            InitializeComponent();
            ListarPedidosRepuesto();
            cboEstado.Items.Add("Registrada");
            cboEstado.Items.Add("Anulada");
            cboEstado.SelectedIndex = 0;
        }

        public void ListarPedidosRepuesto()
        {
            dataGridRepuestos.DataSource = logOrdenPedidoRepuestos.Instancia.ListarPedidosRepuestos();
        }

        private void limpiarVariables()
        {
            dtpFecha.Value = DateTime.Now;
            txtIDRepuesto.Text = "";
            txtCantidad.Text = "";
            cboEstado.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenPedidoRepuestos pedidoRepuesto = new entOrdenPedidoRepuestos
                {
                    RepuestoId = string.IsNullOrEmpty(txtIDRepuesto.Text) ? 0 : long.Parse(txtIDRepuesto.Text),
                    Cantidad = int.Parse(txtCantidad.Text),
                    Fecha = dtpFecha.Value.Date,
                    Estado = cboEstado.SelectedItem.ToString()
                };
                logOrdenPedidoRepuestos.Instancia.InsertarPedidoRepuesto(pedidoRepuesto);
                MessageBox.Show("Pedido de repuesto añadido exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
            ListarPedidosRepuesto();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridRepuestos.CurrentRow != null)
                {
                    var ordenSeleccionada = (entOrdenPedidoRepuestos)dataGridRepuestos.CurrentRow.DataBoundItem;
                    long idRepuesto = ordenSeleccionada.Id; 

                    // Confirmación antes de anular
                    var confirmResult = MessageBox.Show("¿Está seguro de que desea anular este pedido?",
                                                         "Confirmar Anulación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        logOrdenPedidoRepuestos.Instancia.AnularPedidoRepuesto(idRepuesto);
                        MessageBox.Show("Repuesto anulado exitosamente.");
                        ListarPedidosRepuesto();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pedido para anular.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
