using CapaDatos;
using CapaEntidad;
using CapaLogica;
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
using static CapaEntidad.Cliente;
using static CapaEntidad.Personal;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PlanificacionMantenimientoForm : Form
    {
        public PlanificacionMantenimientoForm()
        {
            InitializeComponent();
            Cargarcontrato();
            cargarRespuesto();
            ListarPlanificaciones();
        }
        private void PlanificacionMantenimientoForm_Load(object sender, EventArgs e)
        {
            //CargarPlanificaciones(); // Llama al método para cargar planificaciones al iniciar el formulario

        }
        public void ListarPlanificaciones()
        {
            dgvMante.DataSource = logPlanificacionMantenimiento.Instancia.ListarPlanificaciones();
        }
        private void cargarRespuesto()
        {
            string consulta = "SELECT RepuestosID FROM Repuestos";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbPersonal.Items.Add(reader["RepuestosID"].ToString());
                }

                reader.Close();

            }
        }
        private void Cargarcontrato()
        {
            string consulta = "SELECT ContratoID FROM Contrato";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["ContratoID"].ToString());
                }

                reader.Close();

            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entPlanificacionMantenimiento la = new entPlanificacionMantenimiento();
                la.Id = Convert.ToInt32(textBox2.Text);
                logPlanificacionMantenimiento.Instancia.DeshabilitarPlanificacion(la);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ListarPlanificaciones();
            textBox2.Text = "";
        }

        private void btnInhabilitar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPlanificacionMantenimiento la = new entPlanificacionMantenimiento();
                la.Id = Convert.ToInt32(textBox2.Text);
                logPlanificacionMantenimiento.Instancia.DeshabilitarPlanificacion(la);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ListarPlanificaciones();
            textBox2.Text = "";
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPlanificacionMantenimiento entContrato = new entPlanificacionMantenimiento();
                entContrato.FechaProgramacion = datePickerFecha.Value.Date;
                entContrato.Frecuencia = textBox1.Text;
                entContrato.ContratoID = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                entContrato.RepuestosID = Convert.ToInt32(cbPersonal.SelectedItem.ToString());
                entContrato.Estado = "ACTIVO";
                logPlanificacionMantenimiento.Instancia.InsertarPlanificacion(entContrato);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //LimpiarVariables();
            ListarPlanificaciones();
        }
    }
}
