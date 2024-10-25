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
            dataGridRepuestos.DataSource = logRepuestos.Instancia.ListarRepuestos();
        }

        private void LimpiarVariables()
        {
            txtIdR.Text = "";
            txtCodigoR.Text = "";
            txtNombreR.Text = "";
            txtDescripcionR.Text = "";
            txtStockR.Text = "";
            txtBuscarR.Text = "";
        }

        private void txtBuscarR_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtBuscarR.Text;
            var repuestosFiltrados = logRepuestos.Instancia.ListarRepuestos()
                .Where(repuesto => repuesto.nombre.Contains(nombre))
                .ToList();
            dataGridRepuestos.DataSource = repuestosFiltrados;
        }

        private void dataGridRepuestos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridRepuestos.CurrentRow != null)
            {
                var repuestoSeleccionado = (entRepuesto)dataGridRepuestos.CurrentRow.DataBoundItem;
                txtIdR.Text = repuestoSeleccionado.id.ToString();
                txtCodigoR.Text = repuestoSeleccionado.codigo;
                txtNombreR.Text = repuestoSeleccionado.nombre;
                txtDescripcionR.Text = repuestoSeleccionado.descripcion;
                txtStockR.Text = repuestoSeleccionado.stock.ToString();
            }
        }


        private void btnRegistrarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                entRepuesto repuesto = new entRepuesto
                {
                    codigo = txtCodigoR.Text.Trim(),
                    nombre = txtNombreR.Text.Trim(),
                    descripcion = txtDescripcionR.Text.Trim(),
                    stock = int.Parse(txtStockR.Text)
                };
                logRepuestos.Instancia.InsertarRepuesto(repuesto);
                MessageBox.Show("Repuesto añadido exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarRepuestos();
        }

        private void btnModificarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                entRepuesto repuesto = new entRepuesto();
                repuesto.id = int.Parse(txtIdR.Text.Trim());
                repuesto.codigo = txtCodigoR.Text.Trim();
                repuesto.nombre = txtNombreR.Text.Trim();
                repuesto.descripcion = txtDescripcionR.Text.Trim();
                repuesto.stock = int.Parse(txtStockR.Text);
                logRepuestos.Instancia.EditarRepuesto(repuesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarRepuestos();
        }

        private void btnInhabilitarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                long idRepuesto = long.Parse(txtIdR.Text.Trim());
                entRepuesto repuesto = new entRepuesto { id = idRepuesto };
                logRepuestos.Instancia.DeshabilitarRepuestos(repuesto);
                MessageBox.Show("Repuesto inhabilitado exitosamente.");
                listarRepuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
        }
    }
}
