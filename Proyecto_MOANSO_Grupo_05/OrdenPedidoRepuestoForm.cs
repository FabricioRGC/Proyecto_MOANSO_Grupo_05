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
using static CapaEntidad.OrdenPedidoMaterial;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenPedidoRepuestoForm : Form
    {
        public OrdenPedidoRepuestoForm()
        {
            InitializeComponent();
        }

        private void limpiarVariables()
        {
            txtIDRepuesto.Text = "";
            txtCantidadEntregada.Text = "";
            txtCantidadSolicitada.Text = "";
            txtIDTecnico.Text = "";
            txtObservaciones.Text = "";
            dtpFechaEntrega.Value = DateTime.Now;
            dtpFechaRealizacion.Value = DateTime.Now;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtIDRepuesto.Text) ||
                    string.IsNullOrEmpty(txtIDTecnico.Text) || // Asegúrate de tener este campo
                    string.IsNullOrEmpty(txtCantidadSolicitada.Text) ||
                    string.IsNullOrEmpty(txtCantidadEntregada.Text) || // Asegúrate de tener este campo
                    string.IsNullOrEmpty(txtObservaciones.Text)) // Asegúrate de tener este campo
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return; // Salir del método si hay campos vacíos
                }

                // Crear un nuevo pedido de materiales
                if (long.TryParse(txtIDRepuesto.Text, out long repuestoid) &&
                    long.TryParse(txtIDTecnico.Text, out long tecnicoid) &&
                    int.TryParse(txtCantidadSolicitada.Text, out int cantidadSolicitada) &&
                    int.TryParse(txtCantidadEntregada.Text, out int cantidadEntregada))
                {
                    // Crear la instancia del pedido con el estado como 'Activado' por defecto
                    entOrdenPedidoRepuestos pedidoRepuestos = new entOrdenPedidoRepuestos
                    {
                        repuesto_id = repuestoid,
                        tecnico_id = tecnicoid,
                        cantidad_solicitada = cantidadSolicitada,
                        cantidad_entregada = cantidadEntregada,
                        fecha = dtpFechaRealizacion.Value.Date,
                        fecha_entrega = dtpFechaEntrega.Value.Date,
                        observaciones = txtObservaciones.Text
                    };

                    // Registrar el pedido
                    logOrdenPedidoRepuestos.Instancia.InsertarPedidoRepuesto(pedidoRepuestos);
                    MessageBox.Show("Pedido de Repuesto añadido exitosamente.");

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

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new OrPeRepuestoHistorialForm();
            historial.Show();
        }
    }
}
