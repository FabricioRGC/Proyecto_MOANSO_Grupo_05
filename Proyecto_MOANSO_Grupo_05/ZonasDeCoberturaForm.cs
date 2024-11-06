using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ZonasDeCoberturaForm : Form
    {
        public ZonasDeCoberturaForm()
        {
            InitializeComponent();
            cmbxTipoCobertura.Items.Add("Internet");
            cmbxTipoCobertura.Items.Add("Cable");
            cmbxTipoCobertura.Items.Add("Todo");
            comboBox2.Items.Add("5G");
            comboBox2.Items.Add("4G");
            comboBox2.Items.Add("3G");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbxTipoCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
