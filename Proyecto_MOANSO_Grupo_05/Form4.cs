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
        //Boton para abrir el boton que lleva a la ventana materiales

        private void button11_Click(object sender, EventArgs e)
        {
            Form formulario = new MaterialesForm();
            formulario.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form formulario = new PersonalForm();
            formulario.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario = new RepuestosForm();
            formulario.Show();
        }
    }
}
