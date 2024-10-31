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
        }

        private void limpiarVariables()
        {
            txtIDMateriales.Text = "";
            txtCantidadSolicitada.Text = "";
            dtpFechaRealizacion.Value = DateTime.Now;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtIDMateriales.Text) ||
                    string.IsNullOrEmpty(txtIDCliente.Text) || // Asegúrate de tener este campo
                    string.IsNullOrEmpty(txtCantidadSolicitada.Text) ||
                    string.IsNullOrEmpty(txtCantidadEntregada.Text) || // Asegúrate de tener este campo
                    string.IsNullOrEmpty(txtObservaciones.Text)) // Asegúrate de tener este campo
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return; // Salir del método si hay campos vacíos
                }

                // Crear un nuevo pedido de materiales
                if (long.TryParse(txtIDMateriales.Text, out long materialId) &&
                    long.TryParse(txtIDCliente.Text, out long clienteId) &&
                    int.TryParse(txtCantidadSolicitada.Text, out int cantidadSolicitada) &&
                    int.TryParse(txtCantidadEntregada.Text, out int cantidadEntregada))
                {
                    // Crear la instancia del pedido con el estado como 'Activado' por defecto
                    entOrdenPedidoMateriales pedidoMateriales = new entOrdenPedidoMateriales
                    {
                        material_id = materialId,
                        cliente_id = clienteId,
                        cantidad_solicitada = cantidadSolicitada,
                        cantidad_entregada = cantidadEntregada,
                        fecha = dtpFechaRealizacion.Value.Date,
                        fecha_entrega = dtpFechaEntrega.Value.Date,
                        observaciones = txtObservaciones.Text
                    };

                    // Registrar el pedido
                    logOrdenPedidoMaterial.Instancia.RegistrarPedidoMaterial(pedidoMateriales);
                    MessageBox.Show("Pedido de Material añadido exitosamente.");

                    // Limpiar variables
                    limpiarVariables();
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca valores válidos para ID, cantidad solicitada y cantidad entregada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonHistorialPeMat_Click(object sender, EventArgs e)
        {
            Form historial = new OrPeMaterialHistorialForm();
            historial.Show();
        }
    }
}
