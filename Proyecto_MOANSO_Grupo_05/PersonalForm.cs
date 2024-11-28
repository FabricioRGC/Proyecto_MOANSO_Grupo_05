using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
using CapaDatos;
using static CapaEntidad.Personal;
using static CapaEntidad.Cliente;
using iTextSharp.text.pdf.codec.wmf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static CapaEntidad.Material;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PersonalForm : Form
    {


        public PersonalForm()
        {
            InitializeComponent();
            listarPersonal();
        }
        public void listarPersonal()
        {
            tablaPersonal.DataSource = logPersonal.Instancia.listarPersonal();
        }

        private void LimpiarVariables()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtTelefono.Text = "";

            cbTipoEncargado.SelectedIndex = -1;
            cbAreaTrabajo.SelectedIndex = -1;

        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDNI.Text))
                {
                    MessageBox.Show("El nombre y el DNI son obligatorios.");
                    return;
                }

                entPersonal personal = new entPersonal
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellidos.Text.Trim(),
                    DNI = int.Parse(txtDNI.Text.Trim()),
                    Teléfono = int.Parse(txtTelefono.Text.Trim()), // Convertir a entero
                    Estado = "Activo",
                    Cargo = cbTipoEncargado.SelectedItem.ToString(),
                    AreaTrabajo = cbAreaTrabajo.SelectedItem.ToString()
                };

                logPersonal.Instancia.InsertarPersonal(personal);
                MessageBox.Show("Personal añadido correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir personal: " + ex.Message);
            }
            finally
            {
                LimpiarVariables();
                listarPersonal();
            }
        }


        private void btnInhabilitar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;

            var clientesfiltrados = logCliente.Instancia.ListarCliente()
                .Where(cliente => cliente.nombre.Contains(nombre))
                .ToList();

            tablaPersonal.DataSource = clientesfiltrados;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnInhabilitar_Click_1(object sender, EventArgs e)
        {

            try
            {
                entPersonal la = new entPersonal();
                la.DNI = Convert.ToInt32(txtInhabilitar.Text);
                logPersonal.Instancia.DeshabilitaPersonal(la);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarPersonal();
            txtInhabilitar.Text = "";
        }


        private void tablaPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text;

             var MaterialesFiltrados = logPersonal.Instancia.listarPersonal().Where(Mate => Mate.DNI.ToString().Contains(codigo)).ToList();

            tablaPersonal.DataSource = MaterialesFiltrados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entPersonal mat = new entPersonal();
                mat.Nombre = txtNombre.Text.Trim();
                mat.DNI = int.Parse(txtDNI.Text);
                mat.Apellido = txtApellidos.Text.Trim();
                mat.Teléfono = int.Parse(txtTelefono.Text);
                mat.Cargo = cbTipoEncargado.SelectedItem.ToString();
                mat.AreaTrabajo = cbAreaTrabajo.SelectedItem.ToString();

                logPersonal.Instancia.EDITARPersonal(mat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarPersonal();


        }
    }
}


    


