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
using System.Data.SqlClient;
using CapaDatos;

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

        // CARGAR COMBOBOX
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

        // ----- ACCIONES DE BOTONES -----

        // BOTON AÑADIR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si algún campo está vacío
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear cliente si todo está completo
                entCliente cli = new entCliente();
                cli.nombre = txtNombre.Text.Trim();
                cli.direccion = txtDireccion.Text.Trim();
                cli.telefono = txtTelefono.Text.Trim();
                cli.dni = txtDni.Text.Trim();
                logCliente.Instancia.InsertaCliente(cli);

                // Limpiar y listar
                LimpiarVariables();
                listarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTON MODIFICAR
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

        // BOTON DESHABILITAR
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


        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = tablaClientes.Rows[e.RowIndex];

            txtNombre.Text = Convert.ToString(fila.Cells[0].Value);
            txtDireccion.Text = Convert.ToString(fila.Cells[1].Value);
            txtTelefono.Text = Convert.ToString(fila.Cells[2].Value);
            txtDni.Text = Convert.ToString(fila.Cells[4].Value);
        }

        // BOTON BUSCAR

        private void txtBuscarNombre_TextChanged_1(object sender, EventArgs e)
        {
            string nombresFiltrados = txtBuscarDni.Text;

            var clientesFiltrados = logCliente.Instancia.ListarCliente()
                .Where(cliente => cliente.nombre.Contains(nombresFiltrados))
                .ToList();

            tablaClientes.DataSource = clientesFiltrados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniBuscado = txtBuscarDni.Text.Trim();

            if (string.IsNullOrEmpty(dniBuscado))
            {
                MessageBox.Show("Por favor, ingresa un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
