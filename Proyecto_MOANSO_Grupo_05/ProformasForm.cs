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
using static CapaEntidad.ProformaVenta;
using System.Data.SqlClient;
using CapaDatos;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ProformasForm : Form
    {
        public ProformasForm()
        {
            InitializeComponent();
            cargarClientes();
        }

        //public void listarProforma()
        //{
        //    tablaProformas.DataSource = logProforma.Instancia.ListarProforma();
        //}

        private void limpiarVariables()
        {
            txtPrecio.Text = "";
        }

        // ----- ACCIONES -----

        // Boton Añadir
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entProformaVenta pro = new entProformaVenta();
                pro.fecha_inicio = DateTime.Now.ToString("yyyy-MM-dd");
                pro.precio = txtPrecio.Text.Trim();
                logProforma.Instancia.InsertaProforma(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new ProformaHistorialForm();
            historial.Show();
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
    }
}
