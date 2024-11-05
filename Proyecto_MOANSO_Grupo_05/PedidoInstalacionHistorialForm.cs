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
    public partial class PedidoInstalacionHistorialForm : Form
    {
        public PedidoInstalacionHistorialForm()
        {
            InitializeComponent();
            ListarPedidosInstalacion();
        }

        public void ListarPedidosInstalacion()
        {
            dataGridOrPeInstalacion.DataSource = logPedidoInstalacion.Instancia.ListarPedidosInstalacion();
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

        }
    }
}
