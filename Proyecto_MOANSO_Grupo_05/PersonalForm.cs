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
                txtDisponibilidad.Text = "";

            }

            private void btnAñadir_Click(object sender, EventArgs e)
            {
                try
                {
                    entPersonal cli = new entPersonal();
                    cli.nombre = txtNombre.Text.Trim();
                    cli.disponibilidad = txtDisponibilidad.Text.Trim();
                    logPersonal.Instancia.InsertarPersonal(cli);

            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                LimpiarVariables();
                listarPersonal();
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
                entPersonal cli = new entPersonal();
                cli.nombre = txtNombre.Text.Trim();
                logPersonal.Instancia.DeshabilitarPersonal(cli);
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


