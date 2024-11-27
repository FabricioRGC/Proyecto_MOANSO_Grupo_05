using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaEntidad.Material;
using static CapaEntidad.Repuesto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class RepuestosForm : Form
    {
        public RepuestosForm()
        {
            InitializeComponent();
            listarRepuestos();
            CargarCategoriasRepuesto();
        }

        public void listarRepuestos()
        {
            dataGridRepuestos2.DataSource = logRepuestos.Instancia.ListarRepuestos();
        }

        private void CargarCategoriasRepuesto()
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("SELECT CategoriaRepuestoID, CategoriaRepuesto FROM CategoriaRepuesto", cn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxCategoriaRep.DataSource = dataTable;
                    comboBoxCategoriaRep.DisplayMember = "CategoriaRepuesto";
                    comboBoxCategoriaRep.ValueMember = "CategoriaRepuestoID";
                }
            }
        }

        private void dataGridRepuestos2_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar que haya al menos una fila seleccionada
            if (dataGridRepuestos2.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridRepuestos2.SelectedRows[0];

                // Asignar los valores de las celdas a los cuadros de texto
                txtCodigoRepuesto.Text = selectedRow.Cells["CódigoRepuesto"].Value.ToString();
                txtNombreRepuesto.Text = selectedRow.Cells["NombreRepuesto"].Value.ToString();
                txtDescripción.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                txtStockR.Text = selectedRow.Cells["Stock"].Value.ToString();

                // Asignar el valor del ComboBox desde el código de categoría de la fila
                comboBoxCategoriaRep.SelectedValue = selectedRow.Cells["CategoriaRepuestoID"].Value.ToString();
            }
        }


        private void LimpiarVariables()
        {
            txtCodigoRepuesto.Text = "";
            txtNombreRepuesto.Text = "";
            txtDescripción.Text = "";
            txtStockR.Text = "";
        }
        

        private void txtBuscarRepuesto_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarRepuesto.Text.Trim();
            List<Repuesto.entRepuesto> listaRepuestos = logRepuestos.Instancia.ListarRepuestos();
            var listaFiltrada = listaRepuestos.Where(r => r.CódigoRepuesto.Contains(textoBusqueda)).ToList();
            dataGridRepuestos2.DataSource = listaFiltrada;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entRepuesto repuesto = new entRepuesto
                {
                    CódigoRepuesto = txtCodigoRepuesto.Text.Trim(),
                    NombreRepuesto = txtNombreRepuesto.Text.Trim(),
                    Descripcion = txtDescripción.Text.Trim(),
                    Stock = int.Parse(txtStockR.Text),
                    Estado = "ACTIVO", // Estado fijo como "ACTIVO"
                    CategoriaRepuestoID = comboBoxCategoriaRep.SelectedValue.ToString()
                };

                logRepuestos.Instancia.InsertarRepuesto(repuesto);
                MessageBox.Show("Repuesto insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Repuesto: " + ex.Message);
            }
            finally
            {
                LimpiarVariables();
                listarRepuestos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entRepuesto repuesto = new entRepuesto();
                repuesto.CódigoRepuesto = txtCodigoRepuesto.Text.Trim();
                repuesto.NombreRepuesto = txtNombreRepuesto.Text.Trim();
                repuesto.Stock = int.Parse(txtStockR.Text);
                repuesto.Descripcion = txtDescripción.Text.Trim();
                repuesto.CategoriaRepuestoID = comboBoxCategoriaRep.SelectedValue.ToString();
                logRepuestos.Instancia.EditarRepuestos(repuesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarRepuestos();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entRepuesto repuesto = new entRepuesto();
                repuesto.CódigoRepuesto = txtCodRepInhabilitar.Text.Trim();
                logRepuestos.Instancia.DeshabilitarRepuestos(repuesto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarRepuestos();
            txtCodRepInhabilitar.Text = "";
        }
    }
}
