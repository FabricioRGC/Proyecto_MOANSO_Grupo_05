using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using static CapaEntidad.PedidoRepuestos;
using static CapaEntidad.PedidoMateriales;
using CapaDatos;
using System.Data.SqlClient;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PedidoRepuestoForm : Form
    { 
        public PedidoRepuestoForm()
        {
            InitializeComponent();
            ListarPedidosRepuesto();
            cargarRepuestos();
            cargarPersonalTecnico();
        }

        public void ListarPedidosRepuesto()
        {
            dataGridRepuestos.DataSource = logPedidoRepuestos.Instancia.ListarPedidosRepuestos();
        }

        private void cargarRepuestos()
        {
            string consulta = "select nombre from repuestos";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboRepuestos.Items.Add(reader["nombre"].ToString());
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (cboRepuestos.SelectedIndex == -1 || cboTecnico.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Crear la instancia del pedido con el estado como 'Pendiente' por defecto
                entOrdenPedidoRepuestos pedidoRepuestos = new entOrdenPedidoRepuestos
                {
                    nombreRepuesto = cboRepuestos.SelectedItem.ToString(),
                    nombreTecnico = cboTecnico.SelectedItem.ToString(),
                    fecha = dtpFechaRealizacion.Value.Date,
                    fecha_entrega = dtpFechaEntrega.Value.Date,
                    estado = "Pendiente"
                };

                // Registrar el pedido
                logPedidoRepuestos.Instancia.InsertarPedidoRepuesto(pedidoRepuestos);
                MessageBox.Show("Pedido de Repuesto añadido exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cboRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string repuestoSeleccionado = cboRepuestos.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT codigo, fecha_registro, stock FROM repuestos WHERE nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", repuestoSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CodigoRepuesto.Text = reader["codigo"].ToString();

                        DateTime fechaRegistro;
                        if (DateTime.TryParse(reader["fecha_registro"].ToString(), out fechaRegistro))
                        {
                            dtpFechaRegistroRepuesto.Value = fechaRegistro;
                        }
                        else
                        {
                            MessageBox.Show("Fecha de registro no válida.");
                        }

                        // Asigna el valor de stock
                        stockRepuesto.Text = reader["stock"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string personalTecnicoSeleccionado = cboTecnico.SelectedItem.ToString();

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

        private void txtIdRepuestos_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtRepuestos.Text.Trim();
            List<PedidoRepuestos.entOrdenPedidoRepuestos> listaRepuestos = logPedidoRepuestos.Instancia.ListarPedidosRepuestos();
            var listaFiltrada = listaRepuestos.Where(r => r.nombreRepuesto.Contains(textoBusqueda)).ToList();
            dataGridRepuestos.DataSource = listaFiltrada;
        }

        private void btnTerminarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un pedido
                if (dataGridRepuestos.CurrentRow != null)
                {
                    var ordenSeleccionada = (entOrdenPedidoRepuestos)dataGridRepuestos.CurrentRow.DataBoundItem;
                    long idPedido = ordenSeleccionada.id;

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea terminar este pedido?",
                                                         "Confirmar finalizacion",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        logPedidoRepuestos.Instancia.TerminarPedidoRepuesto(idPedido);
                        MessageBox.Show("Pedido terminado exitosamente.");
                        ListarPedidosRepuesto();
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
