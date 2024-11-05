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
using static CapaEntidad.PedidoInstalacion;
using static CapaEntidad.Repuesto;
using static CapaEntidad.OrdenPedidoMaterial;
using CapaDatos;
using System.Data.SqlClient;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenesPedidoInstalacionForm : Form
    {
        public OrdenesPedidoInstalacionForm()
        {
            InitializeComponent();
            cboTipoInstalacion.Items.Add("Internet");
            cboTipoInstalacion.Items.Add("Cable");
            cboTipoInstalacion.Items.Add("Telefonía");
            cboTipoInstalacion.SelectedIndex = 0;
        }

        private void limpiarVariables()
        {
            txtNumOrden.Text = "";
            txtIdInstalacion.Text = "";
            dtpFechaOrden.Value = DateTime.Now;
            txtTelefono.Text = "";
            txtIDJefeSoporteTecnico.Text = "";
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            mtbHoraInicio.Text = "";
            mtbHoraFinal.Text = "";
            cboTipoInstalacion.SelectedIndex = 0;
            txtUbicacion.Text = "";
            txtDescripcion.Text = "";
            txtObservaciones.Text = "";
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new PedidoInstalacionHistorialForm();
            historial.Show();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtIdInstalacion.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text) ||
                    string.IsNullOrEmpty(txtIDJefeSoporteTecnico.Text) ||
                    cboTipoInstalacion.SelectedItem == null ||
                    string.IsNullOrEmpty(txtUbicacion.Text) ||
                    string.IsNullOrEmpty(txtDescripcion.Text) ||
                    string.IsNullOrEmpty(txtObservaciones.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Crear un nuevo pedido de instalación
                if (int.TryParse(txtIdInstalacion.Text, out int idInstalacion) &&
                    int.TryParse(txtIDJefeSoporteTecnico.Text, out int idJefeSoporte) &&
                    DateTime.TryParse(dtpInicio.Value.ToString(), out DateTime fechaInicio) &&
                    DateTime.TryParse(dtpFechaOrden.Value.ToString(), out DateTime fechaOrden) &&
                    DateTime.TryParse(dtpFin.Value.ToString(), out DateTime fechaFin))
                {

                    TimeSpan horaInicio;
                    TimeSpan horaFin;

                    if (!TimeSpan.TryParse(mtbHoraInicio.Text, out horaInicio))
                    {
                        MessageBox.Show("Por favor, introduzca una hora de inicio válida.");
                        return;
                    }

                    if (!TimeSpan.TryParse(mtbHoraInicio.Text, out horaFin))
                    {
                        MessageBox.Show("Por favor, introduzca una hora de fin válida.");
                        return;
                    }

                    // Crear la instancia del pedido con el estado como 'Registrado' por defecto
                    PedidoInstalacion.entPedidoInstalacion pedido = new PedidoInstalacion.entPedidoInstalacion
                    {
                        IDInstalacion = idInstalacion,
                        Telefono = txtTelefono.Text,
                        IDJefeSoporteTecnico = idJefeSoporte,
                        FechaOrden = fechaOrden,
                        FechaInicio = fechaInicio,
                        FechaFin = fechaFin,
                        HoraInicio = horaInicio,
                        HoraFin = horaFin,
                        TipoInstalacion = cboTipoInstalacion.SelectedItem.ToString(),
                        Ubicacion = txtUbicacion.Text,
                        Descripcion = txtDescripcion.Text,
                        Observaciones = txtObservaciones.Text,
                        Estado = "Registrado"
                    };

                    // Registrar el pedido
                    logPedidoInstalacion.Instancia.InsertarPedidoInstalacion(pedido);
                    MessageBox.Show("Pedido de instalación añadido exitosamente.");

                    // Limpiar variables
                    limpiarVariables();
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca valores válidos para ID de instalación, jefe de soporte y fechas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void OrdenesPedidoInstalacionForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener el último número de orden y mostrar el siguiente en el TextBox
                int ultimoNumeroOrden = logPedidoInstalacion.Instancia.ObtenerUltimoNumeroOrden();
                txtNumOrden.Text = (ultimoNumeroOrden + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }
    }
}
