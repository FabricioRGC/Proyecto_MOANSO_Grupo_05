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

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class RepuestoHistorialForm : Form
    {
        public RepuestoHistorialForm()
        {
            InitializeComponent();
            listarRepuestos();
        }

        public void listarRepuestos()
        {
            dataGridRepuestos.DataSource = logRepuestos.Instancia.ListarRepuestos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }
    }
}
