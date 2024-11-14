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
using static CapaEntidad.OrdenPedidoRepuestos;
using static CapaEntidad.OrdenPedidoMaterial;
using CapaDatos;
using System.Data.SqlClient;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenPedidoRepuestoForm : Form
    {
        public OrdenPedidoRepuestoForm()
        {
            InitializeComponent();
            cargarRepuestos();
        }

        private void limpiarVariables()
        {

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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
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

    }
}
