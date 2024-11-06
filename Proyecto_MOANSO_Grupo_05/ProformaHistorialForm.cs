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
using static CapaEntidad.ProformaVenta;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ProformaHistorialForm : Form
    {
        public ProformaHistorialForm()
        {
            InitializeComponent();
            listarProforma();
        }

        public void listarProforma()
        {
            tablaProformas.DataSource = logProforma.Instancia.ListarProforma();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                entProformaVenta pro = new entProformaVenta();
                pro.cliente_id = txtCodigoCliente.Text.Trim();
                logProforma.Instancia.DeshabilitarProforma(pro);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarProforma();
            txtCodigoCliente.Text = "";
        }
    }
}
