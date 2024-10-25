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
            listarProforma();
            cargarPlanes();
        }

        public void listarProforma()
        {
            tablaProformas.DataSource = logProforma.Instancia.ListarProforma();
        }

        private void limpiarVariables()
        {
            txtCliente.Text = "";
            cbPlan.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        private void cargarPlanes()
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
