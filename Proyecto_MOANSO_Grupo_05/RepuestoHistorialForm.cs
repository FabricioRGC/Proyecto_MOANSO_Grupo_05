using CapaDatos;
using CapaEntidad;
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
using static CapaEntidad.OrdenPedidoRepuestos;
using static CapaEntidad.Repuesto;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class RepuestoHistorialForm : Form
    {
        public RepuestoHistorialForm()
        {
            InitializeComponent();
            listarRepuestos();
        }

        public void listarRepuestos()
        {
            dataGridRepuestos2.DataSource = logRepuestos.Instancia.ListarRepuestos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridRepuestos2.CurrentRow != null)
                {
                    var repuestoSeleccionado = (Repuesto.entRepuesto)dataGridRepuestos2.CurrentRow.DataBoundItem;
                    long idRepuesto = repuestoSeleccionado.id; // Asegúrate de que aquí estés obteniendo el ID correctamente

                    // Confirmación antes de anular
                    var confirmResult = MessageBox.Show("¿Está seguro de que desea anular este repuesto?",
                                                         "Confirmar Anulación",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Cambiado a pasar solo el ID del repuesto
                        datRepuestos.Instancia.DeshabilitarRepuestos(idRepuesto);
                        MessageBox.Show("Repuesto anulado exitosamente.");
                        listarRepuestos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un repuesto para anular.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtBuscarRepuesto_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarRepuesto.Text.Trim();
            List<Repuesto.entRepuesto> listaRepuestos = logRepuestos.Instancia.ListarRepuestos();
            var listaFiltrada = listaRepuestos.Where(r => r.codigo.Contains(textoBusqueda)).ToList();
            dataGridRepuestos2.DataSource = listaFiltrada;
        }
    }
}
