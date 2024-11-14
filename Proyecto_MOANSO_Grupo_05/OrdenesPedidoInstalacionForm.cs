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
using static CapaEntidad.OrdenPedidoMaterial;
using CapaDatos;
using System.Data.SqlClient;
using static CapaEntidad.Material;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenesPedidoInstalacionForm : Form
    {
        public OrdenesPedidoInstalacionForm()
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
            string consulta = "SELECT NOMBRE FROM CLIENTES";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboCliente.Items.Add(reader["NOMBRE"].ToString());
                }

                reader.Close();

            }
        }

        private void cargarPersonalTecnico()
        {
            string consulta = "select nombre from personaltecnico";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboTecnico.Items.Add(reader["nombre"].ToString());
                }

                reader.Close();

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                // Validar que los campos no estén vacíos
                if (cboTecnico.SelectedIndex == -1 || cboCliente.SelectedIndex == -1 || cboTipoInstalacion.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }
                
                // Crear la instancia del pedido con el estado como 'Pendiente' por defecto
                entPedidoInstalacion pedidoInstalacion = new entPedidoInstalacion
                {
                    nombreCliente = cboCliente.SelectedItem.ToString(),
                    nombreTecnico = cboTecnico.SelectedItem.ToString(),
                    TipoInstalacion = cboTipoInstalacion.SelectedItem.ToString(),
                    FechaInicio = dtpInicio.Value.Date,
                    FechaFin = dtpFin.Value.Date,
                    Estado = "Pendiente"
                };

                // Registrar el pedido
                logPedidoInstalacion.Instancia.InsertarPedidoInstalacion(pedidoInstalacion);
                MessageBox.Show("Pedido de instalacion añadido exitosamente.");
                ListarPedidosInstalacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void OrdenesPedidoInstalacionForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener el último número de orden y mostrar el siguiente en el TextBox
                int ultimoNumeroOrden = logPedidoInstalacion.Instancia.ObtenerUltimoNumeroOrden();
                txtNumOrden.Text = (ultimoNumeroOrden + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void txtPedidoInstalacion_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el texto no está vacío y si es un número válido
            if (int.TryParse(txtPedidoInstalacion.Text, out int idInstalacion))
            {
                // Filtrar los materiales por ID
                var InstalacionesFiltradas = logPedidoInstalacion.Instancia.ListarPedidosInstalacion()
                    .Where(mate => mate.NumeroOrden == idInstalacion)
                    .ToList();

                dataGridOrPeInstalacion.DataSource = InstalacionesFiltradas;
            }
            else
            {
                // Si el ID no es válido o está vacío, limpiar el DataGrid o mostrar todos los materiales
                dataGridOrPeInstalacion.DataSource = logPedidoInstalacion.Instancia.ListarPedidosInstalacion(); // Mostrar todos los materiales
            }
        }

        private void cboTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            String personalTecnicoSeleccionado = cboTecnico.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT dni, telefono, disponibilidad, tipo_encargado, area_trabajo FROM personaltecnico WHERE nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", personalTecnicoSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dniLabel.Text = reader["dni"].ToString();
                        telefonoLabel.Text = reader["telefono"].ToString();
                        estadoLabel.Text = reader["disponibilidad"].ToString();
                        tipoCargoLabel.Text = reader["tipo_encargado"].ToString();
                        areaTrabajoLabel.Text = reader["area_trabajo"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = cboCliente.SelectedItem.ToString();

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
                        codigoClienteLabel.Text = reader["codigo"].ToString();
                        direccionClienteLabel.Text = reader["direccion"].ToString();
                        telefonoClienteLabel.Text = reader["telefono"].ToString();
                        estadoClienteLabel.Text = reader["estado"].ToString();
                        dniClienteLabel.Text = reader["dni"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTerminarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridOrPeInstalacion.CurrentRow != null)
                {
                    var ordenSeleccionada = (entPedidoInstalacion)dataGridOrPeInstalacion.CurrentRow.DataBoundItem;
                    int idPedido = ordenSeleccionada.NumeroOrden;

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea terminar este pedido?",
                                                         "Confirmar finalizacion",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        logPedidoInstalacion.Instancia.TerminarPedidoRepuesto(idPedido);
                        MessageBox.Show("Pedido instalacion terminado exitosamente.");
                        ListarPedidosInstalacion();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pedido para terminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
