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
            tablaClientes.CellClick += new DataGridViewCellEventHandler(tablaClientes_CellClick);
            listarCliente();
        }

        public void listarCliente()
        {
            tablaClientes.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void LimpiarVariables()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtDni.Text = "";
        }

        // ----- ACCIONES -----

        // Boton Añadir
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cli = new entCliente();
                cli.nombre = txtNombre.Text.Trim();
                cli.direccion = txtDireccion.Text.Trim();
                cli.telefono = txtTelefono.Text.Trim();
                cli.dni = txtDni.Text.Trim();
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
                cli.nombre = txtNombre.Text.Trim();
                cli.direccion = txtDireccion.Text.Trim();
                cli.telefono = txtTelefono.Text.Trim();
                cli.dni = txtDni.Text.Trim();
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
                cli.dni = txtDni.Text.Trim();
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

        private void txtBuscarNombre_TextChanged_1(object sender, EventArgs e)
        {
            string nombresFiltrados = txtBuscarNombre.Text;

            var clientesFiltrados = logCliente.Instancia.ListarCliente()
                .Where(cliente => cliente.nombre.Contains(nombresFiltrados))
                .ToList();

            tablaClientes.DataSource = clientesFiltrados;
        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = tablaClientes.Rows[e.RowIndex];

            txtNombre.Text = Convert.ToString(fila.Cells[0].Value);
            txtDireccion.Text = Convert.ToString(fila.Cells[1].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells[2].Value);
            txtDni.Text = Convert.ToString(fila.Cells[4].Value);
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
