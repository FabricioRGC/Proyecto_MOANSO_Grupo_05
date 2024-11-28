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
using static CapaEntidad.OrdenDeTrabajo;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenDeTrabajocs : Form
    {
        public OrdenDeTrabajocs()
        {
            InitializeComponent();
            ListarOrdenDeTrabajo();
            cargarClientes();
            cargarPersonalTecnico();
            cargarMantenimiento();
            cargarPedidoDeInstalacion();
        }
        public void ListarOrdenDeTrabajo()
        {
            dataGridViewOrden.DataSource = logOrdenDeTrabajo.Instancia.ListarOrdenDeTrabajo();
        }
        private void cargarClientes()
        {
            string consulta = "SELECT ClienteID FROM CLIENTE";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxClienteOrde.Items.Add(reader["ClienteID"].ToString());
                }

                reader.Close();

            }
        }


        private void cargarPersonalTecnico()
        {
            string consulta = "select PersonalID from personal";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxTecOrde.Items.Add(reader["PersonalID"].ToString());
                }

                reader.Close();

            }
        }
        private void cargarMantenimiento()
        {
            string consulta = "SELECT P_MantenimientoPreventivoID FROM PlanificaciónMantenimientoPreventivo";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxManteOrde.Items.Add(reader["P_MantenimientoPreventivoID"].ToString());
                }

                reader.Close();

            }
        }
        private void cargarPedidoDeInstalacion()
        {
            string consulta = "select PedidoDeInstalaciónID from PedidoDeInstalación";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxPedInstaOrde.Items.Add(reader["PedidoDeInstalaciónID"].ToString());
                }

                reader.Close();

            }
        }
     

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Crear una nueva instancia de la entidad de materiales
                entOrdenDeTrabajo mat = new entOrdenDeTrabajo
                {
                    MantenimientoPreventivoID = int.Parse(comboBoxManteOrde.SelectedItem.ToString()),
                    FechaRegistro = dateTimePicker1.Value.Date,
                    PersonalID = int.Parse(comboBoxTecOrde.SelectedItem.ToString()),
                    FechaEjecución = dateTimePicker2.Value.Date,
                    Tipo = textBox1.Text.Trim(),
                    Estado = "ACTIVO",
                    ClienteID = int.Parse(comboBoxClienteOrde.SelectedItem.ToString()),
                    PedidoDeInstalacionID = int.Parse(comboBoxPedInstaOrde.SelectedItem.ToString()),
                };

                // Llamar al método para insertar el material
                logOrdenDeTrabajo.Instancia.InsertarOrdenDeTrabajo(mat);

                // Mostrar mensaje de éxito
                MessageBox.Show("Orden de trabajo insertado correctamente.");
            }
            catch (Exception ex)
            {
                // Mostrar error en caso de que falle el proceso
                MessageBox.Show("Error al insertar Orden de trabajo: " + ex.Message);
            }
            finally
            {
                // Limpiar los campos del formulario

                // Actualizar la lista de materiales
                ListarOrdenDeTrabajo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entOrdenDeTrabajo mat = new entOrdenDeTrabajo();
                mat.OrdenDeTrabajoID = int.Parse(textBox2.Text);
                logOrdenDeTrabajo.Instancia.TerminarOrdenDeTrabajo(mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ListarOrdenDeTrabajo();
            textBox2.Text = "";
        }

        private void comboBoxClienteOrde_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = comboBoxClienteOrde.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "Select  nombre,dirección, telefono, dni, estado from Cliente where ClienteID = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        nombre.Text = reader["nombre"].ToString();
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

        private void comboBoxPedInstaOrde_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = comboBoxPedInstaOrde.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "Select  FechaRegistro,FechaFin, Estado, TipoInstalación, estado from PedidoDeInstalación where PedidoDeInstalaciónID = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        label14.Text = reader["FechaRegistro"].ToString();
                        label16.Text = reader["FechaFin"].ToString();
                        label17.Text = reader["Estado"].ToString();
                        label18.Text = reader["TipoInstalación"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxTecOrde_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = comboBoxTecOrde.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "Select Nombre,  Apellido,DNI, Télefono, Estado, Cargo from Personal where PersonalID = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        label23.Text = reader["Nombre"].ToString();
                        label24.Text = reader["Apellido"].ToString();
                        label25.Text = reader["DNI"].ToString();
                        label26.Text = reader["Télefono"].ToString();
                        label27.Text = reader["Estado"].ToString();
                        label28.Text = reader["Cargo"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxManteOrde_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = comboBoxManteOrde.SelectedItem.ToString();
            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "Select ContratoID, FechaProgramación,Frecuencia, RepuestosID from PlanificaciónMantenimientoPreventivo where P_MantenimientoPreventivoID = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        label29.Text = reader["ContratoID"].ToString();
                        label30.Text = reader["FechaProgramación"].ToString();
                        label31.Text = reader["Frecuencia"].ToString();
                        label32.Text = reader["RepuestosID"].ToString();
                     

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
