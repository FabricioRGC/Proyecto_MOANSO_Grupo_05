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
        }

        public void LimpiarVariables()
        {

            cbCliente.SelectedIndex = 0;
            cbPlan.SelectedIndex = 0;
            txtDuracion.Text = "";
            txtDescripcionTrabajo.Text = "";
        }

        private void CargarPlanes()
        {
            string consulta = "SELECT PlanNombre FROM PlanesInternet";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbPlan.Items.Add(reader["PlanNombre"].ToString());
                }

                reader.Close();

            }
        }

        private void cargarClientes()
        {
            string consulta = "SELECT NOMBRE FROM CLIENTES";

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
                entContrato.clienteId = cbCliente.SelectedItem.ToString();
                entContrato.tipo_plan = cbPlan.SelectedItem.ToString();
                entContrato.fechaInicio = fechaPicker.Value.Date;
                entContrato.duracion = txtDuracion.Text;
                entContrato.estado = "ACTIVO";
                entContrato.clausula = txtDescripcionTrabajo.Text;
                logContrato.Instancia.InsertaContrato(entContrato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
        }

        // Boton Historial
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new ContratoHistorialForm();
            historial.Show();
        }


        // Actualizar Información

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
