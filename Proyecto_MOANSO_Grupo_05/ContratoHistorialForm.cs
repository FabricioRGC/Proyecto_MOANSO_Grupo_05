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
using static CapaEntidad.Contrato;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ContratoHistorialForm : Form
    {
        public ContratoHistorialForm()
        {
            InitializeComponent();
            listarContrato();
        }

        public void listarContrato()
        {
            tablaContratos.DataSource = logContrato.Instancia.ListarContrato();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                entContrato con = new entContrato();
                con.nombre_cliente = txtCodigoCliente.Text.Trim();
                logContrato.Instancia.AnularContrato(con);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarContrato();
            txtCodigoCliente.Text = "";
        }

        // Filtrar por código de cliente
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtCliente.Text;
            
            var contratosFiltrados = logContrato.Instancia.ListarContrato().Where(contrato => contrato.nombre_cliente.Contains(codigo)).ToList();

            tablaContratos.DataSource = contratosFiltrados;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
