using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AbrirPrueba(object fromprue)
       {
           //if (this.panel1.Controls.Count > 0)
           //    this.panel1.Controls.RemoveAt(0);
           //Form fh = fromprue as Form;
           //fh.TopLevel = false;
           //fh.Dock = DockStyle.Fill;
           //this.panel1.Controls.Add(fh);
           //this.panel1.Tag = fh;
           //fh.Show();

       }

        public void AbrirPrueba2(object fromprues)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fhs = fromprues as Form;
            fhs.TopLevel = false;
            fhs.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fhs);
            this.panel2.Tag = fhs;
            fhs.Show();

        }

        // Boton para abrir el formulario de clientes
        private void button13_Click(object sender, EventArgs e)
        {
            //Form formulario = new ClientesForm();
            //formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //Boton para abrir el boton que lleva a la ventana materiales
        private void button11_Click(object sender, EventArgs e)
        {
            //Form formulario = new MaterialesForm();
            //formulario.Show();
            //AbrirPrueba(new MaterialesForm());
        }


        //Boton para abrir el boton que lleva a la ventana contratos
        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new ContratosForm();
            formulario.Show();
        }

        //Boton para abrir el boton que lleva a la ventana proformas
        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new ProformasForm();
            formulario.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario = new RepuestosForm();
            formulario.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form formulario = new PersonalForm();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Form formulario = new DiagnosticoForm();
            //formulario.Show();
            //AbrirPrueba(new DiagnosticoForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new OrdenesPedidoInstalacionForm();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new PagosForm();
            formulario.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirPrueba2(new Form2());
        }

        private void buttonOrdenes_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new Form3());
        }


        private void buttonAlmyTra_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new Form4());
        }

        private void buttonMantFr_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new Form5());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
