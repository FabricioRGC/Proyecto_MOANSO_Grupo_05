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
                txtApellidos.Text = "";
                txtDNI.Text = "";
                txtTelefono.Text = "";
                cbEstado.Text = "";

            }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entPersonal personal = new entPersonal();
                personal.nombre = txtNombre.Text.Trim();
                personal.apellidos = txtApellidos.Text.Trim();
                personal.dni = txtDNI.Text.Trim();
                personal.telefono = txtTelefono.Text.Trim();
                personal.disponibilidad = cbEstado.Text.Trim();
                personal.tipo_encargado = cbTipoEncargado.SelectedItem.ToString();
                personal.area_trabajo = cbAreaTrabajo.SelectedItem.ToString();


                logPersonal.Instancia.InsertarPersonal(personal);
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
            string dni = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(dni))
            {
                var personal = logPersonal.Instancia.listarPersonal()
                                .FirstOrDefault(p => p.dni == dni);

                if (personal != null)
                {
                    if (personal.disponibilidad == "Habilitado")
                    {
                        personal.disponibilidad = "Inhabilitado";
                        logPersonal.Instancia.DeshabilitarPersonal(personal);
                        MessageBox.Show("El estado del personal ha sido cambiado a Inhabilitado.");
                        listarPersonal(); // Actualiza la lista después del cambio
                    }
                    else
                    {
                        MessageBox.Show("El personal ya está Inhabilitado.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro con ese DNI.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI para inhabilitar.");
            }
        }


        private void tablaPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string dni = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(dni))
            {
                var personal = logPersonal.Instancia.listarPersonal()
                                .Where(p => p.dni == dni)
                                .ToList();

                if (personal.Count > 0)
                {
                    tablaPersonal.DataSource = personal; // Muestra los resultados en el DataGridView
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro con ese DNI.");
                    tablaPersonal.DataSource = null; // Limpia el DataGridView si no hay resultados
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI para buscar.");
            }
        }
    }

}


    


