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
        public void AbrirPrueba(object fromprue)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = fromprue as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Form formulario = new OrdenDeTrabajocs();
            //formulario.Show();
            AbrirPrueba(new OrdenDeTrabajocs());


        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Form formulario = new OrdenesPedidoInstalacionForm();
            //formulario.Show();
            AbrirPrueba(new PedidoInstalacionForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form formulario = new OrdenPedidoMaterialForm();
            //formulario.Show();
            AbrirPrueba(new PedidoMaterialesForm());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Form formulario = new OrdenPedidoRepuestoForm();
            //formulario.Show();
            AbrirPrueba(new PedidoRepuestoForm());

        }
    }
}
