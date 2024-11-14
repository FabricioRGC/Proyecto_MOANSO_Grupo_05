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
using CapaDatos;
using static CapaEntidad.OrdenPedidoMaterial;
using CapaEntidad;
using static CapaEntidad.PedidoInstalacion;
using static CapaEntidad.OrdenPedidoRepuestos;
using System.Data.SqlClient;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenPedidoMaterialForm : Form
    {
        public OrdenPedidoMaterialForm()
        {
            InitializeComponent();
            ListarPedidosMateriales();
            cargarMateriales();
            cargarPersonalTecnico();
        }

        private void limpiarVariables()
        {
            dtpFechaEntrega.Value = DateTime.Now;
            dtpFechaRealizacion.Value = DateTime.Now;
        }

        private void cargarMateriales()
        {
            string consulta = "select nombre from materiales";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboMateriales.Items.Add(reader["nombre"].ToString());
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

        public void ListarPedidosMateriales()
        {
            dataGridMateriales.DataSource = logOrdenPedidoMaterial.Instancia.ListarPedidosMaterial();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (cboMateriales.SelectedIndex == -1 || cboTecnico.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Crear la instancia del pedido con el estado como 'Pendiente' por defecto
                entOrdenPedidoMateriales pedidoMateriales = new entOrdenPedidoMateriales
                {
                    nombreMaterial = cboMateriales.SelectedItem.ToString(),
                    nombreTecnico = cboTecnico.SelectedItem.ToString(),
                    fecha = dtpFechaRealizacion.Value.Date,
                    fecha_entrega = dtpFechaEntrega.Value.Date,
                    estado = "Pendiente"
                };

                // Registrar el pedido
                logOrdenPedidoMaterial.Instancia.RegistrarPedidoMaterial(pedidoMateriales);
                MessageBox.Show("Pedido de Material añadido exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        private void cboMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string repuestoSeleccionado = cboMateriales.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT codigo, stock FROM materiales WHERE nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", repuestoSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CodigoMaterial.Text = reader["codigo"].ToString();
                        stockMaterial.Text = reader["stock"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTerminarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridMateriales.CurrentRow != null)
                {
                    var ordenSeleccionada = (entOrdenPedidoMateriales)dataGridMateriales.CurrentRow.DataBoundItem;
                    long idPedido = ordenSeleccionada.id;

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea terminar este pedido?",
                                                         "Confirmar finalizacion",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        logOrdenPedidoMaterial.Instancia.TerminarPedidoMaterial(idPedido);
                        MessageBox.Show("Pedido terminado exitosamente.");
                        ListarPedidosMateriales();
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

        private void txtMateriales_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtMateriales.Text.Trim();
            List<OrdenPedidoMaterial.entOrdenPedidoMateriales> listaMateriales = logOrdenPedidoMaterial.Instancia.ListarPedidosMaterial();
            var listaFiltrada = listaMateriales.Where(r => r.nombreMaterial.Contains(textoBusqueda)).ToList();
            dataGridMateriales.DataSource = listaFiltrada;
        }
    }
}
