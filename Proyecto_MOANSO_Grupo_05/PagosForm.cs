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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using iTextSharp.tool.xml;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PagosForm : Form
    {
        public PagosForm()
        {
            InitializeComponent();
            cargarClientes();
            listarPagos();
        }

        public void listarPagos()
        {
            tablaPagos.DataSource = logPago.Instancia.ListarPagos();
        }

        public void limpiarVariables()
        {
            cbCliente.SelectedIndex = -1;
            txtMonto.Text = "";
            labelDireccion.Text = "";
            labelTelefono.Text = "";
            labelEstado.Text = "";
            labelDni.Text = "";
            labelPlan.Text = "";
            labelFechaContrato.Text = "";
        }

        public void cargarClientes()
        {
            string consulta = "SELECT NOMBRE FROM CLIENTE";

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
                pag.contrato_id = labelCodigoContrato.Text;
                pag.monto = txtMonto.Text;
                pag.fecha = fechaPicker.Value.Date;
                pag.metodo_pago = cbPago.SelectedItem.ToString();
                //pag.nombre_cliente = cbCliente.SelectedItem.ToString();
                pag.estado = "ACTIVO";
                logPago.Instancia.InsertarPago(pag);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            limpiarVariables();
            listarPagos();
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
                        string consulta = "SELECT clienteid, direccion, telefono, dni, estado FROM Cliente WHERE nombre = @nombre";
                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            codigoClientelabel.Text = reader["clienteid"].ToString();
                            labelDireccion.Text = reader["direccion"].ToString();
                            labelTelefono.Text = reader["telefono"].ToString();
                            labelEstado.Text = reader["estado"].ToString();
                            labelDni.Text = reader["dni"].ToString();
                        }

                        reader.Close();

                        string consultaContrato = "SELECT fechaInicio, plandeservicioID, contratoID FROM Contrato WHERE clienteid = @nombreCliente";
                        SqlCommand cmdContrato = new SqlCommand(consultaContrato, cn);
                        cmdContrato.Parameters.AddWithValue("@nombreCliente", codigoClientelabel.Text);
                        SqlDataReader readerContrato = cmdContrato.ExecuteReader();

                        if (readerContrato.Read())
                        {
                            labelPlan.Text = readerContrato["plandeservicioID"].ToString();
                            DateTime fechaInicio = (DateTime)readerContrato["fechaInicio"];
                            labelFechaContrato.Text = fechaInicio.ToString("dd/MM/yyyy");
                            labelCodigoContrato.Text = readerContrato["contratoID"].ToString();
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

            SaveFileDialog guardar = new SaveFileDialog
            {
                FileName = "COMPROBANTE_PAGO_" + DateTime.Now.ToString("yyyyMMdd") + "_" + cbCliente.SelectedItem.ToString(),
                Filter = "PDF Files (*.pdf)|*.pdf",
                DefaultExt = "pdf",        
                AddExtension = true        
            };

           string html = Properties.Resources.plantilla.ToString();
            html = html.Replace("@CLIENTE", cbCliente.SelectedItem.ToString());
            html = html.Replace("@DOCUMENTO", labelDni.Text);
            html = html.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yy"));
            html = html.Replace("@codigocliente", labelCodigo.Text);
            html = html.Replace("@direccioncliente", labelDireccion.Text);
            html = html.Replace("@telefonocliente", labelTelefono.Text);
            html = html.Replace("@contratoid", labelCodigoContrato.Text);
            double monto;
            if (double.TryParse(txtMonto.Text, out monto))
            {
                html = html.Replace("@igv", (monto * 0.18).ToString());
            }
            else
            {
                MessageBox.Show("Error: Monto no válido");
            }
            html = html.Replace("@tipoplan", labelPlan.Text);
            html = html.Replace("@pago", txtMonto.Text);
            html = html.Replace("@TOTAL", (monto + (monto * 0.18)).ToString());

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdf, fs);
                    pdf.Open();
                    pdf.Add(new Phrase(""));

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.LUNNYS_PNG, System.Drawing.Imaging.ImageFormat.Png);
                    logo.ScaleToFit(120, 100);
                    logo.Alignment = iTextSharp.text.Image.UNDERLYING;
                    logo.SetAbsolutePosition(pdf.LeftMargin, pdf.Top - 80);
                    pdf.Add(logo);

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, sr);
                    }


                    pdf.Close();
                    fs.Close();
                }
            }
            
        }

        // 18% igv

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new PagosHistorialForm();
            historial.Show();
        }
    }
}
