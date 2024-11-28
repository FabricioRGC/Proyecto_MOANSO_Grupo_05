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
using static CapaEntidad.Material;
using CapaDatos;
using System.Data.SqlClient;
using static CapaEntidad.Cliente;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class MaterialesForm : Form
    {
        public MaterialesForm()
        {
            InitializeComponent();
            listarMateriales();
            CargarCategorias();
        }

        public void listarMateriales()
        {
            dataGriMateriales.DataSource = logMateriales.Instancia.ListarMateriales();
        }

        private void LimpiarVariables()
        {
            txtCodigoM.Text = "";
            txtNombreM.Text = "";
            txtDescripciónMateriales.Text = "";
            txtstockM.Text = "";
          //  CBMateriales.SelectedIndex = -1;
        }
        //Añadir
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva instancia de la entidad de materiales
                entMateriales mat = new entMateriales
                {
                    codigo = txtCodigoM.Text.Trim(),
                    nombre = txtNombreM.Text.Trim(),
                    descripcion = txtDescripciónMateriales.Text.Trim(),
                    stock = int.Parse(txtstockM.Text),
                    estado = "ACTIVO", // Estado fijo como "ACTIVO"
                    Categoria = comboBoxCategoriaMat.SelectedValue.ToString() // Clave foránea seleccionada del ComboBox
                };

                // Llamar al método para insertar el material
                logMateriales.Instancia.InsertarMateriales(mat);

                // Mostrar mensaje de éxito
                MessageBox.Show("Material insertado correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar error en caso de que falle el proceso
                MessageBox.Show("Error al insertar material: " + ex.Message);
            }
            finally
            {
                // Limpiar los campos del formulario
                LimpiarVariables();

                // Actualizar la lista de materiales
                listarMateriales();
            }

        }
        //Modificar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entMateriales mat = new entMateriales();
                mat.codigo = txtCodigoM.Text.Trim();
                mat.nombre = txtNombreM.Text.Trim();
                mat.descripcion = txtDescripciónMateriales.Text.Trim();
                mat.stock = int.Parse(txtstockM.Text);
              //  mat.estado = CBMateriales.SelectedItem.ToString();
                logMateriales.Instancia.EditarMateriales(mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarMateriales();
        }
        //inhabilitar
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarMa_TextChanged(object sender, EventArgs e)
        {

          /*  string nombre = txtBuscarMa.Text;

            var Materialesfiltrados = logMateriales.Instancia.ListarMateriales()
                .Where(materiales => materiales.nombre.Contains(nombre))
                .ToList();

            dataGriMateriales.DataSource = Materialesfiltrados;*/
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonHistorialMat_Click(object sender, EventArgs e)
        {
            Form historial = new MaterialesHistorialForm();
            historial.Show();
        }
        private void CargarCategorias()
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                cn.Open();

                using (SqlCommand command = new SqlCommand("SELECT CategoriaMaterialID, CategoriaMaterial FROM CategoriaMaterial", cn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBoxCategoriaMat.DataSource = dataTable;
                    comboBoxCategoriaMat.DisplayMember = "CategoriaMaterial";
                    comboBoxCategoriaMat.ValueMember = "CategoriaMaterialID";
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;

            var MaterialesFiltrados = logMateriales.Instancia.ListarMateriales().Where(Mate => Mate.nombre.Contains(codigo)).ToList();

            dataGriMateriales.DataSource = MaterialesFiltrados;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                entMateriales mat = new entMateriales();
                mat.codigo = textBox2.Text.Trim();
                logMateriales.Instancia.DeshabilitarMateriales(mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarMateriales();
            textBox2.Text = "";

        }
        //modificar materiales
        private void buttonModi_Click(object sender, EventArgs e)
        {
            try
            {
                entMateriales mat = new entMateriales();
                mat.codigo = txtCodigoM.Text.Trim();
                mat.nombre = txtNombreM.Text.Trim();
                mat.stock = int.Parse(txtstockM.Text);
                mat.Categoria = comboBoxCategoriaMat.SelectedValue.ToString(); // Clave foránea seleccionada del ComboBox




                logMateriales.Instancia.EditarMateriales(mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarMateriales();

        }

        private void MaterialesForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGriMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                 DataGridViewRow fila = dataGriMateriales.Rows[e.RowIndex];

             txtCodigoM.Text = Convert.ToString(fila.Cells[0].Value);
             txtNombreM.Text = Convert.ToString(fila.Cells[1].Value);
             txtstockM.Text = Convert.ToString(fila.Cells[3].Value);
             txtDescripciónMateriales.Text = Convert.ToString(fila.Cells[2].Value);
             comboBoxCategoriaMat.Text = Convert.ToString(fila.Cells[5].Value);
          
        }
    }
}
