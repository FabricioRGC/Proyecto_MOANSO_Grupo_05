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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrPeMaterialHistorialForm : Form
    {
        public OrPeMaterialHistorialForm()
        {
            InitializeComponent();
            logOrdenPedidoMaterial.Instancia.PedidoAgregado += ActualizarListaPedidos;
            ListarPedidosMateriales();
        }

        public void ListarPedidosMateriales()
        {
            dataGridOrPeMateriales.DataSource = logOrdenPedidoMaterial.Instancia.ListarPedidosMaterial();
            dataGridOrPeMateriales.ClearSelection(); // Limpiar la selección después de cargar los datos
        }

        private void ActualizarListaPedidos()
        {
            ListarPedidosMateriales();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un pedido
                if (dataGridOrPeMateriales.CurrentRow != null)
                {
                    var ordenSeleccionada = (entOrdenPedidoMateriales)dataGridOrPeMateriales.CurrentRow.DataBoundItem;
                    long idPedido = ordenSeleccionada.id; // Asegúrate de que el ID esté disponible

                    // Confirmación antes de anular
                    var confirmResult = MessageBox.Show("¿Está seguro de que desea anular este pedido?",
                                                         "Confirmar Anulación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Llamar al método para anular el pedido
                        logOrdenPedidoMaterial.Instancia.AnularPedidoMaterial(idPedido);
                        MessageBox.Show("Pedido anulado exitosamente.");

                        // Actualizar la lista de pedidos
                        ListarPedidosMateriales();
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

        private void txtIdMateriales_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtIdMateriales.Text;

            // Verifica si el texto no está vacío y si es un número válido
            if (long.TryParse(codigo, out long idOrPeMaterial))
            {
                // Filtrar los materiales por ID
                var MaterialesFiltrados = logOrdenPedidoMaterial.Instancia.ListarPedidosMaterial()
                    .Where(Mate => Mate.material_id == idOrPeMaterial) // Cambié a buscar por ID
                    .ToList();

                dataGridOrPeMateriales.DataSource = MaterialesFiltrados;
            }
            else
            {
                // Si el ID no es válido o está vacío, puedes limpiar el DataGrid o mostrar todos los materiales
                dataGridOrPeMateriales.DataSource = logOrdenPedidoMaterial.Instancia.ListarPedidosMaterial(); // Mostrar todos los materiales
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridOrPeMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
