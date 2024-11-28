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
using static CapaEntidad.PedidoMateriales;
using CapaEntidad;
using static CapaEntidad.PedidoInstalacion;
using static CapaEntidad.PedidoRepuestos;
using System.Data.SqlClient;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PedidoMaterialesForm : Form
    {
        public PedidoMaterialesForm()
        {
            InitializeComponent();
            ListarPedidosMateriales();
            cargarOrdenTrabajo();
            cargarMateriales();
            cargarPersonalTecnico();
        }

        public void ListarPedidosMateriales()
        {
            dataGridMateriales.DataSource = logPedidoMateriales.Instancia.ListarPedidosMaterial();
        }

        private void limpiarVariables()
        {
            dtpFechaEntrega.Value = DateTime.Now;
            dtpFechaRealizacion.Value = DateTime.Now;
        }

        private void LimpiarInformacionRepuesto()
        {
            CodigoMaterial.Text = string.Empty;
            stockMaterial.Text = string.Empty;
            labelCategoriaMat.Text = string.Empty;

            // Forzar la actualización de la interfaz si es necesario
            CodigoMaterial.Refresh();
            stockMaterial.Refresh();
            labelCategoriaMat.Refresh();
        }

        private void cargarOrdenTrabajo()
        {
            string consulta = "SELECT OrdenDeTrabajoID FROM OrdenDeTrabajo";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cboOrdenTrabajo.DataSource = dt;               // Vincula el DataTable
                    cboOrdenTrabajo.DisplayMember = "OrdenDeTrabajoID"; // Muestra el nombre
                    cboOrdenTrabajo.ValueMember = "OrdenDeTrabajoID";      // Usa el ID como valor
                    cboOrdenTrabajo.SelectedIndex = -1;              // Sin selección inicial
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar repuestos: " + ex.Message);
                }
            }
        }

        private void cargarMateriales()
        {
            string consulta = "SELECT MaterialID, NombreMaterial FROM Material";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cboMateriales.DataSource = dt;               // Vincula el DataTable
                    cboMateriales.DisplayMember = "NombreMaterial"; // Muestra el nombre
                    cboMateriales.ValueMember = "MaterialID";      // Usa el ID como valor
                    cboMateriales.SelectedIndex = -1;              // Sin selección inicial
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar repuestos: " + ex.Message);
                }
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

                cboTecnico.DataSource = dt;
                cboTecnico.DisplayMember = "Nombre";
                cboTecnico.ValueMember = "PersonalID";
                cboTecnico.SelectedIndex = -1; // Ningún elemento seleccionado inicialmente
                cargandoDatos = false; // Bandera desactivada
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos están vacíos
                if (string.IsNullOrWhiteSpace(txtStockPedidoMat.Text))
                {
                    MessageBox.Show("Por favor, ingrese el stock del material.");
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

                // Validar que el stock sea un número válido
                if (!int.TryParse(txtStockPedidoMat.Text, out int stockSolicitado))
                {
                    MessageBox.Show("El stock debe ser un número válido.");
                    return;
                }

                if (cboMateriales.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un material válido.");
                    return;
                }

                if (cboTecnico.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un técnico válido.");
                    return;
                }


                int materialID = Convert.ToInt32(cboMateriales.SelectedValue);

                // Crear el objeto PedidoMaterial y asignar los valores
                entPedidoMateriales PedidoMaterial = new entPedidoMateriales
                {
                    Estado = "Pendiente", // Estado fijo como "Pendiente"
                    FechaRealizacion = dtpFechaRealizacion.Value,
                    FechaEntrega = dtpFechaEntrega.Value,
                    Stock = stockSolicitado,
                    MaterialID = materialID,
                    PersonalID = Convert.ToInt32(cboTecnico.SelectedValue)
                };

                // Insertar el Pedido de Repuesto
                logPedidoMateriales.Instancia.RegistrarPedidoMaterial(PedidoMaterial);
                MessageBox.Show("Pedido material insertado correctamente.");
                txtStockPedidoMat.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Pedido material: " + ex.Message);
            }
            finally
            {
                ListarPedidosMateriales();
                cargarMateriales();
                LimpiarInformacionRepuesto();
            }
        }

        private void cboTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No hacer nada si estamos cargando datos
            if (cargandoDatos || cboTecnico.SelectedIndex == -1)
                return;

            // Asegúrate de que hay un valor seleccionado
            if (cboTecnico.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un técnico válido.");
                return;
            }

            int personalID;
            try
            {
                // Verifica y convierte correctamente el valor seleccionado
                if (int.TryParse(cboTecnico.SelectedValue.ToString(), out personalID))
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

        private void cboMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evitar lógica si no hay selección válida
            if (cboMateriales.SelectedIndex == -1 || cboMateriales.SelectedValue == null)
                return;

            // Obtener el ID seleccionado
            int materialID;

            try
            {

                if (int.TryParse(cboMateriales.SelectedValue.ToString(), out materialID))
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        string consulta = @"
                        SELECT 
                            m.CodigoMaterial, 
                            m.Stock, 
                            c.CategoriaMaterial
                        FROM 
                            Material m
                        INNER JOIN 
                            CategoriaMaterial c ON m.CategoriaMaterialID = c.CategoriaMaterialID
                        WHERE 
                            m.MaterialID = @MaterialID";

                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@MaterialID", materialID);
                        cn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            CodigoMaterial.Text = reader["CodigoMaterial"].ToString();
                            stockMaterial.Text = reader["Stock"].ToString();
                            labelCategoriaMat.Text = reader["CategoriaMaterial"].ToString();
                        }
                        else
                        {
                            LimpiarInformacionRepuesto();
                            MessageBox.Show("No se encontró información para el repuesto seleccionado.");
                        }
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
                // Verificar que se haya seleccionado un pedido
                if (dataGridMateriales.CurrentRow != null)
                {
                    var ordenSeleccionada = (entPedidoMateriales)dataGridMateriales.CurrentRow.DataBoundItem;
                    int idPedido = ordenSeleccionada.PedidoMaterialesID;

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea terminar este pedido?",
                                                         "Confirmar finalización",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        logPedidoMateriales.Instancia.TerminarPedidoMateriales(idPedido);
                        ListarPedidosMateriales();
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

        private void txtMateriales_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtMateriales.Text.Trim();
            List<PedidoMateriales.entPedidoMateriales> listaPedidoMateriales = logPedidoMateriales.Instancia.ListarPedidosMaterial();
            var listaFiltrada = listaPedidoMateriales
                .Where(r => r.PedidoMaterialesID.ToString().Contains(textoBusqueda))
                .ToList();
            dataGridMateriales.DataSource = listaFiltrada;
        }
    }
}
