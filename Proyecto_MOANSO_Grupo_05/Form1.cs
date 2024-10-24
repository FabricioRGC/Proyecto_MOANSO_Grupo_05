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

        // Boton para abrir el formulario de clientes
        private void button13_Click(object sender, EventArgs e)
        {
            Form formulario = new ClientesForm();
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Boton para abrir el boton que lleva a la ventana materiales
        private void button11_Click(object sender, EventArgs e)
        {
            Form formulario = new MaterialesForm();
            formulario.Show();
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
    }
}
