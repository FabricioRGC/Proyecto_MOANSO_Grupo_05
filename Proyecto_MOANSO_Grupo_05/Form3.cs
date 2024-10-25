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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new OrdenDeTrabajocs();
            formulario.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new OrdenesPedidoInstalacionForm();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new OrdenPedidoMaterialForm();
            formulario.Show();
        }
    }
}
