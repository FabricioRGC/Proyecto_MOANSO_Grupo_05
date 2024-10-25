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
using CapaDatos;
using static CapaEntidad.OrdenPedidoMaterial;
using CapaEntidad;
using static CapaEntidad.PedidoInstalacion;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenPedidoMaterialForm : Form
    {
        public OrdenPedidoMaterialForm()
        {
            InitializeComponent();
            ListarPedidosMateriales();
            cboEstado.Items.Add("Registrada");
            cboEstado.Items.Add("Anulada");
            cboEstado.SelectedIndex = 0;
        }

        public void ListarPedidosMateriales()
        {
            dataGridOrPeMateriales.DataSource = logOrdenPedidoMaterial.Instancia.ListarPedidosMaterial();
        }

        private void limpiarVariables()
        {
            txtIDMateriales.Text = "";
            txtCantidad.Text = "";
            dtpFecha.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;
        }

        private void dataGridOrPeMateriales_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridOrPeMateriales.CurrentRow != null)
            {
                var ordenSeleccionada = (entOrdenPedidoMateriales)dataGridOrPeMateriales.CurrentRow.DataBoundItem;
                txtIDMateriales.Text = ordenSeleccionada.material_id.ToString();
                txtCantidad.Text = ordenSeleccionada.cantidad.ToString();
                dtpFecha.Value = ordenSeleccionada.fecha;
                cboEstado.SelectedItem = ordenSeleccionada.estado;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtIDMateriales.Text) ||
                    string.IsNullOrEmpty(txtCantidad.Text) ||
                    cboEstado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return; // Salir del método si hay campos vacíos
                }

                // Crear un nuevo pedido de materiales
                if (long.TryParse(txtIDMateriales.Text, out long id) &&
                    int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    entOrdenPedidoMateriales pedidoMateriales = new entOrdenPedidoMateriales
                    {
                        id = id,
                        cantidad = cantidad,
                        fecha = dtpFecha.Value.Date,
                        estado = cboEstado.SelectedItem.ToString()
                    };

                    // Registrar el pedido
                    logOrdenPedidoMaterial.Instancia.RegistrarPedidoMaterial(pedidoMateriales);
                    MessageBox.Show("Pedido de Material añadido exitosamente.");

                    // Limpiar variables y listar pedidos
                    limpiarVariables();
                    ListarPedidosMateriales();
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca valores válidos para ID y cantidad.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
    }
}
