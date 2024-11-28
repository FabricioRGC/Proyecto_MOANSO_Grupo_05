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
using static CapaEntidad.PedidoInstalacion;
using static CapaEntidad.Repuesto;
using static CapaEntidad.PedidoMateriales;
using CapaDatos;
using System.Data.SqlClient;
using static CapaEntidad.Material;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PedidoInstalacionForm : Form
    {
        public PedidoInstalacionForm()
        {
            InitializeComponent();
            ListarPedidosInstalacion();
            cargarPersonalTecnico();
            cargarClientes();
            cboTipoInstalacion.Items.Add("Internet");
            cboTipoInstalacion.Items.Add("Cable");
            cboTipoInstalacion.Items.Add("Cable + Internet");
            cboTipoInstalacion.SelectedIndex = 0;
        }

        public void ListarPedidosInstalacion()
        {
            dataGridOrPeInstalacion.DataSource = logPedidoInstalacion.Instancia.ListarPedidosInstalacion();
        }

        private void limpiarVariables()
        {

        }

        private void cargarClientes()
        {
            string consulta = "SELECT Nombre FROM Cliente";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboCliente.Items.Add(reader["Nombre"].ToString());
                }

                reader.Close();

            }
        }

        private bool cargandoDatos = false;
        private void cargarPersonalTecnico()
        {
            string consulta = "SELECT PersonalID, Nombre FROM Personal WHERE Cargo = @Cargo";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Cargo", "Jefe de soporte tecnico");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                cargandoDatos = true; // Bandera activada
                cn.Open();
                adapter.Fill(dt);

                cboTecnicos.DataSource = dt;
                cboTecnicos.DisplayMember = "Nombre";
                cboTecnicos.ValueMember = "PersonalID";
                cboTecnicos.SelectedIndex = -1; // Ningún elemento seleccionado inicialmente
                cargandoDatos = false; // Bandera desactivada
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void OrdenesPedidoInstalacionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPedidoInstalacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No hacer nada si estamos cargando datos
            if (cargandoDatos || cboTecnicos.SelectedIndex == -1)
                return;

            // Asegúrate de que hay un valor seleccionado
            if (cboTecnicos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un técnico válido.");
                return;
            }

            int personalID;
            try
            {
                // Verifica y convierte correctamente el valor seleccionado
                if (int.TryParse(cboTecnicos.SelectedValue.ToString(), out personalID))
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        string consulta = "SELECT DNI, Télefono, Estado, Cargo, AreaTrabajo FROM Personal WHERE PersonalID = @PersonalID";
                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@PersonalID", personalID);
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            dniLabel.Text = reader["DNI"].ToString();
                            telefonoLabel.Text = reader["Télefono"].ToString();
                            estadoLabel.Text = reader["Estado"].ToString();
                            tipoCargoLabel.Text = reader["Cargo"].ToString();
                            areaTrabajoLabel.Text = reader["AreaTrabajo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró información para el técnico seleccionado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El valor seleccionado no es válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)
            {
                string clienteSeleccionado = cboCliente.SelectedItem.ToString();

                try
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        // 1. Obtener los datos del cliente
                        string consultaCliente = "SELECT clienteid, direccion, telefono, dni, estado FROM Cliente WHERE nombre = @nombre";
                        SqlCommand cmdCliente = new SqlCommand(consultaCliente, cn);
                        cmdCliente.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                        cn.Open();

                        SqlDataReader reader = cmdCliente.ExecuteReader();

                        if (reader.Read())
                        {
                            // Mostrar los datos del cliente en los Labels
                            codigoClienteLabel.Text = reader["clienteid"].ToString();
                            direccionClienteLabel.Text = reader["direccion"].ToString();
                            telefonoClienteLabel.Text = reader["telefono"].ToString();
                            estadoClienteLabel.Text = reader["estado"].ToString();
                            dniClienteLabel.Text = reader["dni"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró información para el cliente seleccionado.");
                            return;
                        }

                        reader.Close();

                        // 2. Obtener el contrato asociado al cliente
                        string consultaContrato = @"
                        SELECT TOP 1 ContratoID 
                        FROM Contrato 
                        WHERE ClienteID = @clienteID
                        ORDER BY FechaInicio DESC";
                        SqlCommand cmdContrato = new SqlCommand(consultaContrato, cn);
                        cmdContrato.Parameters.AddWithValue("@clienteID", codigoClienteLabel.Text);

                        object contratoIdObj = cmdContrato.ExecuteScalar();

                        // Validar si existe un contrato asociado
                        if (contratoIdObj == null)
                        {
                            // Mostrar en el label si no hay contrato
                            labelContratoID.Text = "Sin Contrato";
                        }
                        else
                        {
                            // Mostrar el ID del contrato si existe
                            labelContratoID.Text = $"Con Contrato";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnTerminarPedido_Click(object sender, EventArgs e)
        {
            


        }
    }
}
