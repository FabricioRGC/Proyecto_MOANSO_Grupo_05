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
using static CapaEntidad.Cliente;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
            listarCliente();
        }

        public void listarCliente()
        {
            tablaClientes.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void LimpiarVariables()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cbEstado.SelectedIndex = -1;
        }

        // ----- ACCIONES -----

        // Boton Añadir
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cli = new entCliente();
                cli.codigo = txtCodigo.Text.Trim();
                cli.nombre = txtNombre.Text.Trim();
                cli.direccion = txtDireccion.Text.Trim();
                cli.telefono = txtTelefono.Text.Trim();
                cli.estado = cbEstado.SelectedItem.ToString();
                logCliente.Instancia.InsertaCliente(cli);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarCliente();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Boton Modificar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cli = new entCliente();
                cli.codigo = txtCodigo.Text.Trim();
                cli.nombre = txtNombre.Text.Trim();
                cli.direccion = txtDireccion.Text.Trim();
                cli.telefono = txtTelefono.Text.Trim();
                cli.estado = cbEstado.SelectedItem.ToString();
                logCliente.Instancia.EditarCliente(cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarCliente();
        }

        // Boton Deshabilitar
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cli = new entCliente();
                cli.codigo = txtCodigo.Text.Trim();
                logCliente.Instancia.DeshabilitarCliente(cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            LimpiarVariables();
            listarCliente();
        }

        // Filtrar por Nombre

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text;

            var clientesfiltrados = logCliente.Instancia.ListarCliente()
                .Where(cliente => cliente.nombre.Contains(nombre))
                .ToList();

            tablaClientes.DataSource = clientesfiltrados;
        }
    }
}
