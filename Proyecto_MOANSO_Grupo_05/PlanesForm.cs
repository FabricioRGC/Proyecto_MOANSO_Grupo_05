using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaEntidad.Planes;
using CapaLogica;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PlanesForm : Form
    {
        public PlanesForm()
        {
            InitializeComponent();
            ListarPlanes();
        }
        public void ListarPlanes()
        {
            dataGridViewplan.DataSource = logPlanes.Instancia.ListarPlanes();
        }
        private void LimpiarVariables()
        {
            txtnomplan.Text = "";
            txtVelocidadmbps.Text = "";
            txtlimites.Text = "";
            txtpreciomen.Text = "";
            txttipser.Text = "";
            txtcaractplan.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entPlanes plan = new entPlanes();
                plan.PlanNombre = txtnomplan.Text.Trim();
                plan.VelocidadMbps = int.Parse(txtVelocidadmbps.Text);
                plan.LimiteDeDatos = int.Parse(txtlimites.Text);
                plan.PrecioMensual = float.Parse(txtpreciomen.Text);
                plan.TipoServicio = txttipser.Text.Trim();
                plan.Caracteristicas = txtcaractplan.Text.Trim();
                plan.estado = "ACTIVO";

                logPlanes.Instancia.InsertarPlanes(plan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarPlanes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entPlanes plan = new entPlanes();
                plan.PlanNombre = txtnomplan.Text.Trim();
                plan.VelocidadMbps = int.Parse(txtVelocidadmbps.Text);
                plan.LimiteDeDatos = int.Parse(txtlimites.Text);
                plan.PrecioMensual = float.Parse(txtpreciomen.Text);
                plan.TipoServicio = txttipser.Text.Trim();
                plan.Caracteristicas = txtcaractplan.Text.Trim();

                logPlanes.Instancia.EditarPlanes(plan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarPlanes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entPlanes plan = new entPlanes();
                plan.PlanNombre = txtnomplan.Text.Trim();
                logPlanes.Instancia.DeshabilitarPlanes(plan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            txtnomplan.Text = "";
            ListarPlanes();
        }
    }
}
