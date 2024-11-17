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
using static CapaEntidad.ProformaVenta;
using System.Data.SqlClient;
using CapaDatos;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ProformasForm : Form
    {
        public ProformasForm()
        {
            InitializeComponent();
            cargarClientes();
            cargarPlanes();
            cargarAsesores();
            listarProforma();
        }
        public void listarProforma()
        {
            tablaProformas.DataSource = logProforma.Instancia.ListarProforma();
        }


        private void limpiarVariables()
        {
        }

        public void cargarPlanes()
        {
            string consulta = "SELECT NombrePlanServicio FROM PlanDeServicio";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbPlan.Items.Add(reader["NombrePlanServicio"].ToString());
                }

                reader.Close();

            }
        }

        public void cargarAsesores()
        {
            string consulta= "SELECT Nombre from Personal where Cargo = 'Asesor de Ventas'";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbAsesor.Items.Add(reader["Nombre"].ToString());
                }

                reader.Close();

            }
        }

        // ----- ACCIONES -----

        // Boton Añadir
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entProformaVenta pro = new entProformaVenta();
                pro.cliente_id = codigoLabel.Text;
                pro.fecha_inicio = DateTime.Now;
                pro.tipo_plan = cbPlan.SelectedItem.ToString();
                pro.precio = float.Parse(precioLabel.Text);
                pro.estado = "ACTIVO";
                pro.asesor = cbAsesor.SelectedItem.ToString();

                logProforma.Instancia.InsertaProforma(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
            listarProforma();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new ProformaHistorialForm();
            historial.Show();
        }

        private void cargarClientes()
        {
            string consulta = "SELECT NOMBRE FROM CLIENTE";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbCliente.Items.Add(reader["NOMBRE"].ToString());
                }

                reader.Close();

            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = cbCliente.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "Select codigo, direccion, telefono, dni, estado from Clientes where nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        codigoLabel.Text = reader["codigo"].ToString();
                        direccionLabel.Text = reader["direccion"].ToString();
                        telefonoLabel.Text = reader["telefono"].ToString();
                        estadoLabel.Text = reader["estado"].ToString();
                        dniLabel.Text = reader["dni"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string planSeleccionado = cbPlan.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT VelocidadMbps, LimiteDatosGB, PrecioMensualSoles, TipoServicio, Caracteristicas FROM PlanesInternet WHERE PlanNombre = @planNombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@planNombre", planSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        velocidadLabel.Text = reader["VelocidadMbps"].ToString();
                        limiteLabel.Text = reader["LimiteDatosGB"].ToString();
                        precioLabel.Text = reader["PrecioMensualSoles"].ToString();
                        tipoLabel.Text = reader["TipoServicio"].ToString();
                        caracteristicasLabel.Text = reader["Caracteristicas"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string asesorSeleccionado = cbAsesor.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT DNI, Telefono FROM PersonalTecnico WHERE Nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", asesorSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labelAD.Text = reader["DNI"].ToString();
                        labelAT.Text = reader["Telefono"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
