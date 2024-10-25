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
        //Boton para abrir el boton que lleva a la ventana contratos
        private void button1_Click(object sender, EventArgs e)
        {
            
              //  Form formulario = new ContratosForm();
              //  formulario.Show();
          AbrirPrueba(new ContratosForm());

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Form formulario = new ClientesForm();
            //formulario.Show();
            AbrirPrueba(new ClientesForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form formulario = new PagosForm();
            //formulario.Show();
            AbrirPrueba(new PagosForm());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Form formulario = new ProformasForm();
            //formulario.Show();
            AbrirPrueba(new ProformasForm());
        }
    }
}
