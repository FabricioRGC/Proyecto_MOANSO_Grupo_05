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
            textBoxDistritos.Text = "";
            comboBoxVelocidad.SelectedIndex = -1;
            cmbxTipoCobertura.SelectedIndex = -1;

            //  CBMateriales.SelectedIndex = -1;
        }
        public void ListarZona()
        {
            dataGridView1.DataSource = logZonaDeCobertura.Instancia.ListarZona();
        }

        private void btnAñadirZon_Click(object sender, EventArgs e)
        {
            try
            {
                entZonas zon = new entZonas();
                zon.Distrito = textBoxDistritos.Text.Trim();
                zon.TipoConexion = comboBoxVelocidad.SelectedItem.ToString();
                zon.TipoServicio = cmbxTipoCobertura.SelectedItem.ToString();
                zon.Estado_zona = "ACTIVO";
                logZonaDeCobertura.Instancia.InsertarZona(zon);
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
                zon.Distrito = txtInhabilitarZon.Text.Trim();
                logZonaDeCobertura.Instancia.DeshabilitarZona(zon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ListarZona();
        }

        private void btnModificarZon_Click(object sender, EventArgs e)
        {
            try
            {
                entZonas zon = new entZonas();
                zon.Distrito = textBoxDistritos.Text.Trim();
                zon.TipoConexion = comboBoxVelocidad.SelectedItem.ToString();
                zon.TipoServicio = cmbxTipoCobertura.SelectedItem.ToString();
                logZonaDeCobertura.Instancia.EditarZona(zon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            ListarZona();
        }

        private void buscarTxt_TextChanged(object sender, EventArgs e)
        {
            string Dist = buscarTxt.Text;

            var ZonaFiltrados = logZonaDeCobertura.Instancia.ListarZona().Where(zon => zon.Distrito.Contains(Dist)).ToList();

            dataGridView1.DataSource = ZonaFiltrados;
        }
    }
}
