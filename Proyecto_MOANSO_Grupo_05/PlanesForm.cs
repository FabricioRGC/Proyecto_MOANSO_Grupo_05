using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaEntidad.Planes;
using CapaLogica;
using CapaDatos;
using CapaEntidad;
using System.Data.SqlClient;
using iTextSharp.text.pdf.codec.wmf;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PlanesForm : Form
    {
        public PlanesForm()
        {
            InitializeComponent();
            ListarPlanes();
            cargarClientes();
        }

        private void cargarClientes()
        {
            string consulta = "SELECT ZonaDeCoberturaID FROM ZonaDeCobertura";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["ZonaDeCoberturaID"].ToString());
                }

                reader.Close();

            }
        }

        public void ListarPlanes()
        {
            dataGridViewplan.DataSource = logPlanes.Instancia.ListarPlanes();
        }
        private void LimpiarVariables()
        {
            txtnomplan.Text = "";
            txtVelocidadmbps.Text = "";
            txtpreciomen.Text = "";
            txttipser.Text = "";
            txtcaractplan.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entPlanes plan = new entPlanes();
                plan.PlanNombre = txtnomplan.Text.Trim();
                plan.VelocidadMbps = txtVelocidadmbps.Text;
                plan.PrecioMensual = float.Parse(txtpreciomen.Text);
                plan.TipoServicio = txttipser.Text.Trim();
                plan.Caracteristicas = txtcaractplan.Text.Trim();
                plan.Zona_de_cobertura_id = int.Parse(comboBox1.SelectedItem.ToString());
                plan.estado = checkBox1.Checked ? "ACTIVO" : "INACTIVO";

                logPlanes.Instancia.InsertarPlanes(plan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarPlanes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entPlanes plan = new entPlanes();
                plan.PlanNombre = txtnomplan.Text.Trim();
                plan.VelocidadMbps = txtVelocidadmbps.Text;
                plan.PrecioMensual = float.Parse(txtpreciomen.Text);
                plan.TipoServicio = txttipser.Text.Trim();
                plan.Caracteristicas = txtcaractplan.Text.Trim();
                plan.Zona_de_cobertura_id = int.Parse(comboBox1.SelectedItem.ToString());
                plan.estado = checkBox1.Checked ? "ACTIVO" : "INACTIVO";

                logPlanes.Instancia.EditarPlanes(plan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarPlanes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entPlanes plan = new entPlanes();
                plan.PlanNombre = txtnomplan.Text.Trim();
                logPlanes.Instancia.DeshabilitarPlanes(plan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            txtnomplan.Text = "";
            ListarPlanes();
        }
    }
}
