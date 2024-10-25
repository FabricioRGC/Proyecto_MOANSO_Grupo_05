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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        /*public void AbrirPrueba(object fromprue)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = fromprue as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }*/
        private void button4_Click(object sender, EventArgs e)
        {
            //AbrirPrueba(new DiagnosticoForm());
        }
    }
}
