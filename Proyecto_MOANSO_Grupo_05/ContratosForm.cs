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
using CapaDatos;
using CapaEntidad;
using CapaLogica;
using static CapaEntidad.Cliente;
using static CapaEntidad.Contrato;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ContratosForm : Form
    {
        public ContratosForm()
        {
            InitializeComponent();
            listarContrato();
            CargarPlanes();
        }

        public void listarContrato()
        {
            tablaContratos.DataSource = logContrato.Instancia.ListarContrato();
        }

        public void LimpiarVariables()
        {
            txtCliente.Text = "";
            cbEstado.SelectedIndex = -1;
            cbPlan.SelectedIndex = -1;
        }

        private void CargarPlanes()
        {
            string consulta = "SELECT PlanNombre FROM PlanesInternet";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbPlan.Items.Add(reader["PlanNombre"].ToString());
                }

                reader.Close();

            }
        }

        // ----- ACCIONES -----
        // Boton Añadir
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entContrato con = new entContrato();
                con.clienteId = txtCliente.Text.Trim();
                con.duracion = txtDuracion.Text.Trim();
                con.estado = cbEstado.SelectedItem.ToString();
                con.tipo_plan = cbPlan.SelectedItem.ToString();
                logContrato.Instancia.InsertaContrato(con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarContrato();
        }

        // Boton Modificar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entContrato con = new entContrato();
                con.clienteId = txtCliente.Text.Trim();
                con.duracion = txtDuracion.Text.Trim();
                con.estado = cbEstado.SelectedItem.ToString();
                con.tipo_plan = cbPlan.SelectedItem.ToString();
                logContrato.Instancia.EditarContrato(con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarContrato();
        }

        // Boton Inhabilitar
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entContrato con = new entContrato();
                con.clienteId = txtCliente.Text.Trim();
                logContrato.Instancia.DeshabilitarContrato(con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarContrato();
        }
    }
}
