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
            // Limpiar valores de Labels
            codigoClienteLabel.Text = string.Empty;
            direccionClienteLabel.Text = string.Empty;
            telefonoClienteLabel.Text = string.Empty;
            estadoClienteLabel.Text = string.Empty;
            dniClienteLabel.Text = string.Empty;
            labelContratoID.Text = string.Empty;

            // Limpiar valores de DateTimePickers
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;

            // Limpiar valores de ComboBoxes
            cboCliente.SelectedIndex = -1;
            cboTecnicos.SelectedIndex = -1;
            cboTipoInstalacion.SelectedIndex = -1;

            // Reiniciar variables internas
            contratoIDSeleccionado = 0;
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
            try
            {
                // Validar Fecha de Inicio
                if (dtpInicio.Value == null || dtpInicio.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Por favor, seleccione la fecha de inicio.");
                    return;
                }

                // Validar Fecha de Fin
                if (dtpFin.Value == null || dtpFin.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Por favor, seleccione la fecha de fin.");
                    return;
                }

                // Validar Técnico
                if (cboTecnicos.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un técnico válido.");
                    return;
                }

                // Validar Tipo de Instalación
                if (string.IsNullOrEmpty(cboTipoInstalacion.Text))
                {
                    MessageBox.Show("Por favor, seleccione un tipo de instalación.");
                    return;
                }

                // Validar si hay un contrato asociado
                if (contratoIDSeleccionado == 0)
                {
                    MessageBox.Show("El cliente seleccionado no tiene un contrato asociado.");
                    return;
                }

                // Crear el objeto PedidoInstalacion y asignar los valores
                entPedidoInstalacion PedidoInstalacion = new entPedidoInstalacion
                {
                    Estado = "Pendiente", // Estado fijo como "Pendiente"
                    FechaRegistro = dtpInicio.Value,
                    FechaFin = dtpFin.Value,
                    ContratoID = contratoIDSeleccionado, // Se usa el contrato almacenado internamente
                    PersonalID = Convert.ToInt32(cboTecnicos.SelectedValue),
                    TipoInstalación = cboTipoInstalacion.Text,
                };

                // Insertar el Pedido de instalación
                logPedidoInstalacion.Instancia.InsertarPedidoInstalacion(PedidoInstalacion);
                MessageBox.Show("Pedido de instalación insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Pedido de instalación: " + ex.Message);
            }
            finally
            {
                ListarPedidosInstalacion();
                limpiarVariables();
                cargarClientes();
            }
        }

        private void txtPedidoInstalacion_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtPedidoInstalacion.Text.Trim();
            List<PedidoInstalacion.entPedidoInstalacion> listaPedidoInstalacion = logPedidoInstalacion.Instancia.ListarPedidosInstalacion();
            var listaFiltrada = listaPedidoInstalacion
                .Where(r => r.PedidoDeInstalaciónID.ToString().Contains(textoBusqueda))
                .ToList();
            dataGridOrPeInstalacion.DataSource = listaFiltrada;
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
        private int contratoIDSeleccionado = 0;
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

                        // Obtener el contrato asociado al cliente
                        string consultaContrato = @"
                        SELECT TOP 1 ContratoID 
                        FROM Contrato 
                        WHERE ClienteID = @clienteID
                        ORDER BY FechaInicio DESC";
                        SqlCommand cmdContrato = new SqlCommand(consultaContrato, cn);
                        cmdContrato.Parameters.AddWithValue("@clienteID", codigoClienteLabel.Text);

                        object contratoIdObj = cmdContrato.ExecuteScalar();

                        if (contratoIdObj == null)
                        {
                            // No hay contrato asociado
                            contratoIDSeleccionado = 0;
                            labelContratoID.Text = "Sin Contrato";
                        }
                        else
                        {
                            // Contrato asociado encontrado
                            contratoIDSeleccionado = Convert.ToInt32(contratoIdObj);
                            labelContratoID.Text = "Con Contrato";
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
            try
            {
                // Verificar que se haya seleccionado un pedido
                if (dataGridOrPeInstalacion.CurrentRow != null)
                {
                    var ordenSeleccionada = (entPedidoInstalacion)dataGridOrPeInstalacion.CurrentRow.DataBoundItem;
                    int idPedido = ordenSeleccionada.PedidoDeInstalaciónID;

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea terminar este pedido?",
                                                         "Confirmar finalización",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        logPedidoInstalacion.Instancia.TerminarPedidoRepuesto(idPedido);
                        ListarPedidosInstalacion();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila antes de intentar terminar un pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al intentar terminar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
