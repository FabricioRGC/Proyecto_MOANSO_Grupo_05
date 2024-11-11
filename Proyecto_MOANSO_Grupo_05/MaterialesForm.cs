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
                entMateriales mat = new entMateriales();
                mat.codigo = txtCodigoM.Text.Trim();
                mat.nombre = txtNombreM.Text.Trim();
                mat.descripcion = txtDescripciónMateriales.Text.Trim();
                //mat.fechaInicio = dateTimePicker1.Value.Date;
                mat.stock = int.Parse(txtstockM.Text);
                mat.estado = "ACTIVO";
                mat.Categoria= comboBoxCategoriaMat.SelectedItem.ToString();
                // mat.estado = CBMateriales.SelectedItem.ToString();
                logMateriales.Instancia.InsertarMateriales(mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarMateriales();
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
            string consulta = "select Categoria from Categorias";
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxCategoriaMat.Items.Add(reader["Categoria"].ToString());
                }

                reader.Close();

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

        private void buttonModi_Click(object sender, EventArgs e)
        {
            try
            {
                entMateriales mat = new entMateriales();
                mat.codigo = txtCodigoM.Text.Trim();
                mat.nombre = txtNombreM.Text.Trim();
                mat.stock = int.Parse(txtstockM.Text);
                //mat.telefono = txtTelefono.Text.Trim();
                //mat.dni = txtDni.Text.Trim();
                logMateriales.Instancia.EditarMateriales(mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarMateriales();
        }
    }
}
