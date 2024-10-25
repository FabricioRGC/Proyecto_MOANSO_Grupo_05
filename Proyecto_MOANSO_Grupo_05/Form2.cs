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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Boton para abrir el boton que lleva a la ventana contratos
        private void button1_Click(object sender, EventArgs e)
        {
            
                Form formulario = new ContratosForm();
                formulario.Show();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form formulario = new ClientesForm();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new PagosForm();
            formulario.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new ProformasForm();
            formulario.Show();
        }
    }
}
