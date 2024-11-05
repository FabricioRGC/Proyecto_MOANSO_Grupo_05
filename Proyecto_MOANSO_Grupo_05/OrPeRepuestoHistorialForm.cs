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
using static CapaEntidad.OrdenPedidoMaterial;
using static CapaEntidad.OrdenPedidoRepuestos;
using static CapaEntidad.PedidoInstalacion;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrPeRepuestoHistorialForm : Form
    {
        public OrPeRepuestoHistorialForm()
        {
            InitializeComponent();
            ListarPedidosRepuesto();
            CenterToScreen();
        }

        public void ListarPedidosRepuesto()
        {
            dataGridRepuestos.DataSource = logOrdenPedidoRepuestos.Instancia.ListarPedidosRepuestos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un pedido
                if (dataGridRepuestos.CurrentRow != null)
                {
                    var ordenSeleccionada = (entOrdenPedidoRepuestos)dataGridRepuestos.CurrentRow.DataBoundItem;
                    long idPedido = ordenSeleccionada.id;

                    // Confirmación antes de anular
                    var confirmResult = MessageBox.Show("¿Está seguro de que desea anular este pedido?",
                                                         "Confirmar Anulación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Llamar al método para anular el pedido
                        logOrdenPedidoRepuestos.Instancia.AnularPedidoRepuesto(idPedido);
                        MessageBox.Show("Pedido anulado exitosamente.");

                        // Actualizar la lista de pedidos
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

        private void txtIdRepuestos_TextChanged(object sender, EventArgs e)
        {
            string idRepuesto = txtIdRepuestos.Text;
            if (long.TryParse(idRepuesto, out long idOrPeRepuestos))
            {
                var RepuestosFiltrados = logOrdenPedidoRepuestos.Instancia.ListarPedidosRepuestos()
                    .Where(Mate => Mate.repuesto_id == idOrPeRepuestos)
                    .ToList();

                dataGridRepuestos.DataSource = RepuestosFiltrados;
            }
            else
            {
                dataGridRepuestos.DataSource = logOrdenPedidoRepuestos.Instancia.ListarPedidosRepuestos();
            }
        }
    }
}
