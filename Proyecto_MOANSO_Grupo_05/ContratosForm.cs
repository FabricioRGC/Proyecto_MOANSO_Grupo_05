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
using CapaDatos;
using CapaEntidad;
using CapaLogica;
using static CapaEntidad.Cliente;
using static CapaEntidad.Contrato;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ContratosForm : Form
    {
        public ContratosForm()
        {
            InitializeComponent();
            CargarPlanes();
            cargarClientes();
            listarContrato();
        }

        public void listarContrato()
        {
            tablaContratos.DataSource = logContrato.Instancia.ListarContrato();
        }

        public void LimpiarVariables()
        {

            cbCliente.SelectedIndex = 0;
            cbPlan.SelectedIndex = 0;
            txtDuracion.Text = "";
        }

        private void CargarPlanes()
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

        // ----- ACCIONES -----
        // Boton Añadir
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entContrato entContrato = new entContrato();
                entContrato.id_cliente = Convert.ToInt32(labelcodigocliente.Text);
                entContrato.id_servicio = Convert.ToInt32(labelCodigoServicio.Text);
                entContrato.fechaInicio = fechaPicker.Value.Date;
                entContrato.duracion = Convert.ToInt32(txtDuracion.Text);
                entContrato.estado = "ACTIVO";
                logContrato.Instancia.InsertaContrato(entContrato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarContrato();
        }

        // Actualizar Información

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string planSeleccionado = cbPlan.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT PlanDeServicioID, VelocidadMbps, precio, TipoServicio, Caracteristicas FROM PlanDeServicio WHERE NombrePlanServicio = @NombrePlanServicio";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@NombrePlanServicio", planSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labelCodigoServicio.Text = reader["PlanDeServicioID"].ToString();
                        velocidadLabel.Text = reader["VelocidadMbps"].ToString();
                        precioLabel.Text = reader["Precio"].ToString();
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

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = cbCliente.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "Select ClienteID, dirección, telefono, dni, estado from Cliente where nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labelcodigocliente.Text = reader["ClienteID"].ToString();
                        direccionLabel.Text = reader["dirección"].ToString();
                        telefonoLabel.Text = reader["telefono"].ToString();
                        estadoLabel.Text = reader["estado"].ToString();
                        dniLabel.Text = reader["dni"].ToString();
                    }           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ContratosForm_Load(object sender, EventArgs e)
        {

        }

        // Filtrar por Cliente
        //private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        //{
        //    string nombre = txtBuscarCliente.Text;

        //    var contratosFiltrados = logContrato.Instancia.ListarContrato().Where(c => c.clienteId.Contains(nombre)).ToList();

        //    tablaContratos.DataSource = contratosFiltrados;
        //}
    }
}
