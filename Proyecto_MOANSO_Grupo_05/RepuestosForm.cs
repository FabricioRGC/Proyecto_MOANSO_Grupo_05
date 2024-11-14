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
using static CapaEntidad.Repuesto;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class RepuestosForm : Form
    {
        public RepuestosForm()
        {
            InitializeComponent();
            listarRepuestos();
        }

        public void listarRepuestos()
        {
            dataGridRepuestos2.DataSource = logRepuestos.Instancia.ListarRepuestos();
        }

        private void LimpiarVariables()
        {
            txtCodigoRepuesto.Text = "";
            txtNombreRepuesto.Text = "";
            txtDescripción.Text = "";
            txtStockR.Text = "";
            dtpRepuestos.Value = DateTime.Now;
        }


        private void btnRegistrarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo_repuesto = txtCodigoRepuesto.Text;

                if (!string.IsNullOrEmpty(codigo_repuesto) &&
                    !string.IsNullOrEmpty(txtDescripción.Text) &&
                    !string.IsNullOrEmpty(txtNombreRepuesto.Text) &&
                    int.TryParse(txtStockR.Text, out int stock))
                {
                    // Obtener la fecha seleccionada
                    DateTime fechaSeleccionada = dtpRepuestos.Value;

                    entRepuesto repuesto = new entRepuesto
                    {
                        codigo = txtCodigoRepuesto.Text,
                        nombre = txtNombreRepuesto.Text,
                        descripcion = txtDescripción.Text,
                        stock = stock,
                        estado = "Registrado",
                        fecha_registro = fechaSeleccionada // Asignar la fecha seleccionada
                    };

                    // Llamar al procedimiento almacenado con el parámetro de fecha
                    logRepuestos.Instancia.InsertarRepuesto(repuesto);
                    MessageBox.Show("Repuesto añadido exitosamente.");
                    listarRepuestos();
                    LimpiarVariables();
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca valores válidos para los campos.");
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
                if (dataGridRepuestos2.CurrentRow != null)
                {
                    var repuestoSeleccionado = (Repuesto.entRepuesto)dataGridRepuestos2.CurrentRow.DataBoundItem;
                    long idRepuesto = repuestoSeleccionado.id;

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
