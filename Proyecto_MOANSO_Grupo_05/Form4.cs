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
    public partial class Form4 : Form
    {
        public Form4()
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
        //Boton para abrir el boton que lleva a la ventana materiales

        private void button11_Click(object sender, EventArgs e)
        {
            //Form formulario = new MaterialesForm();
            //formulario.Show();
            AbrirPrueba(new MaterialesForm());

        }

        private void button14_Click(object sender, EventArgs e)
        {
           // Form formulario = new PersonalForm();
           // formulario.Show();
            AbrirPrueba(new PersonalForm());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Form formulario = new RepuestosForm();
            //formulario.Show();
            AbrirPrueba(new RepuestosForm());

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
