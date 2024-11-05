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
using static CapaEntidad.Pago;
using Microsoft.VisualBasic.Logging;
using CapaDatos;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PagosForm : Form
    {
        public PagosForm()
        {
            InitializeComponent();
            cargarClientes();
        }

        public void limpiarVariables()
        {
            cbCliente.SelectedIndex = -1;
            txtMonto.Text = "";
            labelDireccion.Text = "";
            labelTelefono.Text = "";
            labelEstado.Text = "";
            labelDni.Text = "";
            labelCodigo.Text = "";
            labelPlan.Text = "";
            labelFechaContrato.Text = "";
        }

        public void cargarClientes()
        {
            string consulta = "SELECT NOMBRE FROM CLIENTES";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbCliente.Items.Add(reader["NOMBRE"].ToString());
                }

                reader.Close();

            }
        }

        // ----- ACCIONES -----

        // Botón para añadir un pago
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pag = new entPago();
                pag.monto = txtMonto.Text;
                logPago.Instancia.InsertarPago(pag);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
        }

        // Botón para anular un pago
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                entPago pag = new entPago();
                logPago.Instancia.AnularPago(pag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            try
            {
                entPago pag = new entPago();
                pag.contrato_id = labelCodigo.Text;
                pag.monto = txtMonto.Text;
                pag.fecha = fechaPicker.Value.Date;
                pag.metodo_pago = cbPago.SelectedItem.ToString();
                pag.nombre_cliente = cbCliente.SelectedItem.ToString();
                pag.estado = "ACTIVO";
                logPago.Instancia.InsertarPago(pag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cbCliente.SelectedIndex != -1)
            {
                string clienteSeleccionado = cbCliente.SelectedItem.ToString();

                try
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        string consulta = "SELECT codigo, direccion, telefono, dni, estado FROM Clientes WHERE nombre = @nombre";
                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            labelCodigo.Text = reader["codigo"].ToString();
                            labelDireccion.Text = reader["direccion"].ToString();
                            labelTelefono.Text = reader["telefono"].ToString();
                            labelEstado.Text = reader["estado"].ToString();
                            labelDni.Text = reader["dni"].ToString();
                        }

                        reader.Close();

                        string consultaContrato = "SELECT fecha_inicio, tipo_plan FROM Contratos WHERE cliente_nombre = @nombreCliente";
                        SqlCommand cmdContrato = new SqlCommand(consultaContrato, cn);
                        cmdContrato.Parameters.AddWithValue("@nombreCliente", clienteSeleccionado);
                        SqlDataReader readerContrato = cmdContrato.ExecuteReader();

                        if (readerContrato.Read())
                        {
                            labelPlan.Text = readerContrato["tipo_plan"].ToString();

                            // Formateo de la fecha para que solo muestre la fecha sin la hora
                            DateTime fechaInicio = (DateTime)readerContrato["fecha_inicio"];
                            labelFechaContrato.Text = fechaInicio.ToString("dd/MM/yyyy"); // Ajusta el formato según tus necesidades
                        }

                        readerContrato.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            
        }

        // Boton para generar comprobante de pago
        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new PagosHistorialForm();
            historial.Show();
        }
    }
}
