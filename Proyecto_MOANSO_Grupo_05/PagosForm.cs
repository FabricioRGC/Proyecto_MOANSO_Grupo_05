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
using static CapaEntidad.Pago;
using Microsoft.VisualBasic.Logging;
using CapaDatos;
using System.Data.SqlClient;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PagosForm : Form
    {
        public PagosForm()
        {
            InitializeComponent();
        }

        public void limpiarVariables()
        {
            txtMonto.Text = "";
        }

        public void cargarClientes()
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

        // ----- ACCIONES -----

        // Botón para añadir un pago
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pag = new entPago();
                pag.monto = txtMonto.Text;
                logPago.Instancia.InsertarPago(pag);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
        }

        // Botón para anular un pago
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pag = new entPago();
                logPago.Instancia.AnularPago(pag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
