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
using static CapaEntidad.PedidoInstalacion;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PedidoInstalacionHistorialForm : Form
    {
        public PedidoInstalacionHistorialForm()
        {
            InitializeComponent();
            ListarPedidosInstalacion();
            CenterToScreen();
        }

        public void ListarPedidosInstalacion()
        {
            dataGridOrPeInstalacion.DataSource = logPedidoInstalacion.Instancia.ListarPedidosInstalacion();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un pedido
                if (dataGridOrPeInstalacion.CurrentRow != null)
                {
                    var ordenSeleccionada = (entPedidoInstalacion)dataGridOrPeInstalacion.CurrentRow.DataBoundItem;
                    int idPedido = ordenSeleccionada.NumeroOrden;

                    // Confirmación antes de anular
                    var confirmResult = MessageBox.Show("¿Está seguro de que desea anular este pedido?",
                                                         "Confirmar Anulación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Llamar al método para anular el pedido
                        logPedidoInstalacion.Instancia.AnularPedidoInstalacion(idPedido);
                        MessageBox.Show("Pedido anulado exitosamente.");
                        ListarPedidosInstalacion();
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

        private void txtSelecId_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el texto no está vacío y si es un número válido
            if (int.TryParse(txtSelecId.Text, out int idInstalacion))
            {
                // Filtrar los materiales por ID
                var InstalacionesFiltradas = logPedidoInstalacion.Instancia.ListarPedidosInstalacion()
                    .Where(mate => mate.IDInstalacion == idInstalacion) // Buscar por ID
                    .ToList();

                dataGridOrPeInstalacion.DataSource = InstalacionesFiltradas;
            }
            else
            {
                // Si el ID no es válido o está vacío, limpiar el DataGrid o mostrar todos los materiales
                dataGridOrPeInstalacion.DataSource = logPedidoInstalacion.Instancia.ListarPedidosInstalacion(); // Mostrar todos los materiales
            }
        }
    }
}
