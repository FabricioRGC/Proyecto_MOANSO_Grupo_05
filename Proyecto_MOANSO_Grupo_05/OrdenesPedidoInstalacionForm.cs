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
            ListarPedidosInstalacion();
            cmbEstado.Items.Add("Registrado");
            cmbEstado.Items.Add("Anulado");
            cmbEstado.SelectedIndex = 0;
        }

        public void ListarPedidosInstalacion()
        {
            dataGridOrPeInstalacion.DataSource = logPedidoInstalacion.Instancia.ListarPedidosInstalacion();
        }

        private void limpiarVariables()
        {
            txtId.Text = "";
            dtpFecha.Value = DateTime.Now;
            cmbEstado.SelectedIndex = 0;
        }

        private void dataGridOrPeInstalacion_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridOrPeInstalacion.CurrentRow != null)
            {
                var ordenSeleccionada = (entPedidoInstalacion)dataGridOrPeInstalacion.CurrentRow.DataBoundItem;
                txtId.Text = ordenSeleccionada.id.ToString();
                dtpFecha.Text = ordenSeleccionada.fecha.ToString("yyyy-MM-dd");
                cmbEstado.SelectedItem = ordenSeleccionada.estado;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                entPedidoInstalacion pedido = new entPedidoInstalacion
                {
                    id = string.IsNullOrEmpty(txtId.Text) ? 0 : long.Parse(txtId.Text),
                    fecha = dtpFecha.Value.Date,
                    estado = cmbEstado.SelectedItem.ToString()
                };
                logPedidoInstalacion.Instancia.InsertarPedidoInstalacion(pedido);
                MessageBox.Show("Pedido de Instalacion añadido exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
            ListarPedidosInstalacion();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que txtId no esté vacío y contenga un valor numérico
                if (string.IsNullOrWhiteSpace(txtId.Text) || !long.TryParse(txtId.Text.Trim(), out long idOrPeInstalacion))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido para anular el pedido.");
                    return;
                }

                // Llamar al método para anular el pedido con el ID
                logPedidoInstalacion.Instancia.AnularPedidoInstalacion(idOrPeInstalacion);
                MessageBox.Show("Orden inhabilitada exitosamente.");
                ListarPedidosInstalacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Pedir el ID
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el ID del pedido a buscar:", "Consultar Pedido");

            if (long.TryParse(input, out long idBuscar))
            {
                // Consultar el pedido usando el procedimiento almacenado
                PedidoInstalacion.entPedidoInstalacion pedido = logPedidoInstalacion.Instancia.ConsultarPedidoInstalacion(idBuscar);

                if (pedido != null)
                {
                    // Asignar los datos al formulario
                    txtId.Text = pedido.id.ToString();
                    dtpFecha.Value = pedido.fecha;
                    cmbEstado.SelectedItem = pedido.estado;

                    // Seleccionar la fila en el DataGrid
                    foreach (DataGridViewRow row in dataGridOrPeInstalacion.Rows)
                    {
                        if (row.Cells["id"].Value != null && (long)row.Cells["id"].Value == pedido.id)
                        {
                            row.Selected = true;
                            dataGridOrPeInstalacion.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID no encontrado en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }
    }
}
