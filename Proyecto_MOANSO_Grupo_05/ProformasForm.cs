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
using static CapaEntidad.ProformaVenta;
using System.Data.SqlClient;
using CapaDatos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using iTextSharp.tool.xml;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ProformasForm : Form
    {
        public ProformasForm()
        {
            InitializeComponent();
            cargarClientes();
            cargarPlanes();
            cargarAsesores();
            listarProforma();
        }
        public void listarProforma()
        {
            tablaProformas.DataSource = logProforma.Instancia.ListarProforma();
        }

        public void cargarPlanes()
        {
            string consulta = "SELECT NombrePlanServicio FROM PlanDeServicio";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbPlan.Items.Add(reader["NombrePlanServicio"].ToString());
                }

                reader.Close();

            }
        }

        public void cargarAsesores()
        {
            string consulta= "SELECT Nombre from Personal where Cargo = 'Asesor de Ventas'";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbAsesor.Items.Add(reader["Nombre"].ToString());
                }

                reader.Close();

            }
        }

        // ----- ACCIONES -----

        // Boton Añadir
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                entProformaVenta pro = new entProformaVenta();
                pro.fecha_inicio = fechaInicioPicker.Value.Date;
                pro.cliente_id = Convert.ToInt32(labelcodigocliente.Text);
                pro.servicio_id = Convert.ToInt32(labelCodigoServicio.Text);
                pro.fecha_fin = fechaFinPicker.Value.Date;
                pro.personal_id = Convert.ToInt32(labelAsesorID.Text);

                logProforma.Instancia.InsertaProforma(pro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            listarProforma();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cargarClientes()
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string asesorSeleccionado = cbAsesor.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT DNI, Teléfono, PersonalID FROM Personal WHERE Nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", asesorSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labelAD.Text = reader["DNI"].ToString();
                        labelAT.Text = reader["Teléfono"].ToString();
                        labelAsesorID.Text = reader["PersonalID"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cbCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string clienteSeleccionado = cbCliente.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "Select ClienteID, dirección, telefono, dni, estado from Cliente where nombre = @nombre";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@nombre", clienteSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labelcodigocliente.Text = reader["ClienteID"].ToString();
                        direccionLabel.Text = reader["dirección"].ToString();
                        telefonoLabel.Text = reader["telefono"].ToString();
                        estadoLabel.Text = reader["estado"].ToString();
                        dniLabel.Text = reader["dni"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbPlan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string planSeleccionado = cbPlan.SelectedItem.ToString();

            try
            {
                using (SqlConnection cn = Conexion.Instancia.Conectar())
                {
                    string consulta = "SELECT PlanDeServicioID, VelocidadMbps, precio, TipoServicio, Caracteristicas FROM PlanDeServicio WHERE NombrePlanServicio = @NombrePlanServicio";
                    SqlCommand cmd = new SqlCommand(consulta, cn);
                    cmd.Parameters.AddWithValue("@NombrePlanServicio", planSeleccionado);
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labelCodigoServicio.Text = reader["PlanDeServicioID"].ToString();
                        velocidadLabel.Text = reader["VelocidadMbps"].ToString();
                        precioLabel.Text = reader["Precio"].ToString();
                        tipoLabel.Text = reader["TipoServicio"].ToString();
                        caracteristicasLabel.Text = reader["Caracteristicas"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog
            {
                FileName = "PROFORMA_" + DateTime.Now.ToString("yyyyMMdd") + "_" + cbCliente.SelectedItem.ToString(),
                Filter = "PDF Files (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true
            };

            string html = Properties.Resources.proformaventa.ToString();
            html = html.Replace("@NOMBRECLIENTE", cbCliente.SelectedItem.ToString());
            html = html.Replace("@DIRECCION", direccionLabel.Text);
            html = html.Replace("@TELEFONO", telefonoLabel.Text);
            html = html.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yy"));
            html = html.Replace("@METODOPAGO", "Efectivo");
            html = html.Replace("@SERVICIO", labelCodigoServicio.Text);
            html = html.Replace("@MONTO", precioLabel.Text);
            html = html.Replace("@SUBTOTAL", precioLabel.Text);
            html = html.Replace("@IGV", "0.18");
            double monto;
            if (double.TryParse(precioLabel.Text, out monto))
            {
                html = html.Replace("@igv", (monto * 0.18).ToString());
            }
            else
            {
                MessageBox.Show("Error: Monto no válido");
            }
            html = html.Replace("@TOTAL", (monto + (monto * 0.18)).ToString());

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.LUNNYS_PNG, System.Drawing.Imaging.ImageFormat.Png);
                    logo.ScaleToFit(120, 100);
                    logo.Alignment = iTextSharp.text.Image.UNDERLYING;
                    logo.SetAbsolutePosition(doc.LeftMargin, doc.Top - 60);
                    doc.Add(logo);

                    using (StringReader sr = new StringReader(html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, sr);
                    }

                    doc.Close();
                    fs.Close();
                }
            }
        }
    }
}
