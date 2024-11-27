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
using static CapaEntidad.Repuesto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            string consulta = "select NombreRepuesto from Repuestos";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboNomRepuestos.Items.Add(reader["NombreRepuesto"].ToString());
                }

                reader.Close();

            }
        }

        private void cargarPersonalTecnico()
        {
            string consulta = "SELECT Nombre FROM Personal WHERE Cargo = @Cargo";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Cargo", "Jefe de soporte tecnico");

                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboTecnicoAsignado.Items.Add(reader["Nombre"].ToString());
                }

                reader.Close();
            }
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos están vacíos
                if (string.IsNullOrWhiteSpace(txtStockPedidoRep.Text))
                {
                    MessageBox.Show("Por favor, ingrese el stock del repuesto.");
                    return;
                }


                if (dtpFechaRealizacion.Value == null || dtpFechaRealizacion.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Por favor, seleccione la fecha de realización.");
                    return;
                }

                if (dtpFechaEntrega.Value == null || dtpFechaEntrega.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Por favor, seleccione la fecha de entrega.");
                    return;
                }

                // Crear el objeto PedidoRepuesto y asignar los valores
                entPedidoRepuestos PedidoRepuesto = new entPedidoRepuestos
                {
               
                    Estado = "Pendiente", // Estado fijo como "Pendiente"
                    FechaRealizacion = dtpFechaRealizacion.Value,
                    FechaEntrega = dtpFechaEntrega.Value,
                    RepuestosID = Convert.ToInt32(cboNomRepuestos.SelectedValue),
                    PersonalID = Convert.ToInt32(cboTecnicoAsignado.SelectedValue)
                };

                // Insertar el Pedido de Repuesto
                logPedidoRepuestos.Instancia.InsertarPedidoRepuesto(PedidoRepuesto);
                MessageBox.Show("Pedido Repuesto insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Pedido Repuesto: " + ex.Message);
            }
            finally
            {
                ListarPedidosRepuesto();
            }
        }


        private void cboRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string repuestoSeleccionado = cboNomRepuestos.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    // Consulta modificada para incluir el nombre de la categoría
                    string consulta = @"
                SELECT 
                    r.CódigoRepuesto, 
                    r.Stock, 
                    r.CategoriaRepuestoID, 
                    c.CategoriaRepuesto  -- Nombre de la categoría
                FROM 
                    Repuestos r
                INNER JOIN 
                    CategoriaRepuesto c ON r.CategoriaRepuestoID = c.CategoriaRepuestoID
                WHERE 
                    r.NombreRepuesto = @NombreRepuesto";

                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@NombreRepuesto", repuestoSeleccionado);

                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CodigoRepuesto.Text = reader["CódigoRepuesto"].ToString();
                        stockRepuesto.Text = reader["Stock"].ToString();
                        labelCategoriaID.Text = reader["CategoriaRepuesto"].ToString(); 
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
            string personalTecnicoSeleccionado = cboTecnicoAsignado.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT DNI, Télefono, Estado, Cargo, AreaTrabajo FROM Personal WHERE Nombre = @Nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@Nombre", personalTecnicoSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        dniLabel.Text = reader["DNI"].ToString();
                        telefonoLabel.Text = reader["Télefono"].ToString();
                        estadoLabel.Text = reader["Estado"].ToString();
                        tipoCargoLabel.Text = reader["Cargo"].ToString();
                        areaTrabajoLabel.Text = reader["AreaTrabajo"].ToString();
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
         
        }

        private void btnTerminarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un pedido
                if (dataGridRepuestos.CurrentRow != null)
                {
                    var ordenSeleccionada = (entPedidoRepuestos)dataGridRepuestos.CurrentRow.DataBoundItem;
                    int idPedido = ordenSeleccionada.PedidoDeRepuestosID;

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

        private void btnTerminarPedido_Click_1(object sender, EventArgs e)
        {

        }
    }
}
