using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaEntidad.ZonaDeCobertura;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ZonasDeCoberturaForm : Form
    {
        public ZonasDeCoberturaForm()
        {
            InitializeComponent();
            ListarZona();
            comboBoxVelocidad.Items.Add("Fibra óptica");
            comboBoxVelocidad.Items.Add("Conexión inalámbrica");
            comboBoxVelocidad.Items.Add("Conexión utp");
            cmbxTipoCobertura.Items.Add("Internet");
            cmbxTipoCobertura.Items.Add("Cable");
            cmbxTipoCobertura.Items.Add("TODO");
        }
        private void LimpiarVariables()
        {
           /* textBoxDistritos.Text = "";
            textBoxPostal.Text = "";
            comboBoxVelocidad.SelectedIndex = -1;
            cmbxTipoCobertura.SelectedIndex = -1;
            comboBoxTipozon.SelectedIndex = -1;

            //  CBMateriales.SelectedIndex = -1;*/
        }
        public void ListarZona()
        {
            dataGridView1.DataSource = logZonaDeCobertura.Instancia.ListarZona();
        }

        private void btnAñadirZon_Click(object sender, EventArgs e)
        {
            try
            {
             /*   entZonas zon = new entZonas();
                zon.Distrito = textBoxDistritos.Text.Trim();
                zon.VelocidadDeCobertura = comboBoxVelocidad.SelectedItem.ToString();
                zon.TipoZona = cmbxTipoCobertura.SelectedItem.ToString();
                //mat.fechaInicio = dateTimePicker1.Value.Date;
                zon.CodigoPostal = int.Parse(textBoxPostal.Text);
                zon.Estado = "ACTIVO";
                zon.Tipo = comboBoxTipozon.SelectedItem.ToString();
                // mat.estado = CBMateriales.SelectedItem.ToString();
                logZonaDeCobertura.Instancia.InsertarZona(zon);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ListarZona();
            //  listarMateriales();
        }

        private void cmbxTipoCobertura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInhabilitarZon_Click(object sender, EventArgs e)
        {
            try
            {
                entZonas zon = new entZonas();
                zon.CodigoPostal = int.Parse(textBox5.Text);
                logZonaDeCobertura.Instancia.DeshabilitarZona(zon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ListarZona();
            textBox5.Text = "";
        }

        private void btnModificarZon_Click(object sender, EventArgs e)
        {
            try
            {
               /* entZonas zon = new entZonas();
                zon.CodigoPostal = int.Parse(textBoxPostal.Text);
                zon.VelocidadDeCobertura = comboBoxVelocidad.SelectedItem.ToString();
                zon.TipoZona = cmbxTipoCobertura.SelectedItem.ToString();
                zon.Tipo = comboBoxTipozon.SelectedItem.ToString();
                logZonaDeCobertura.Instancia.EditarZona(zon);*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarZona();
        }

        private void textBoxPostal_TextChanged(object sender, EventArgs e)
        {
            string Dist = buscarTxt.Text;

            var ZonaFiltrados = logZonaDeCobertura.Instancia.ListarZona().Where(zon => zon.Distrito.Contains(Dist)).ToList();

            dataGridView1.DataSource = ZonaFiltrados;
        }

        private void buscarTxt_TextChanged(object sender, EventArgs e)
        {
            string Dist = buscarTxt.Text;

            var ZonaFiltrados = logZonaDeCobertura.Instancia.ListarZona().Where(zon => zon.Distrito.Contains(Dist)).ToList();

            dataGridView1.DataSource = ZonaFiltrados;
        }
    }
}
