using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaEntidad.Repuesto;


namespace Proyecto_MOANSO_Grupo_05
{
    public partial class RepuestosForm : Form
    {
        public RepuestosForm()
        {
            InitializeComponent();
        }

        private void LimpiarVariables()
        {
            txtCodigoRepuesto.Text = "";
            txtNombreRepuesto.Text = "";
            txtDescripción.Text = "";
            txtStockR.Text = "";
            dtpRepuestos.Value = DateTime.Now;
        }


        private void btnRegistrarRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo repuesto
                if (long.TryParse(txtCodigoRepuesto.Text, out long codigo_repuesto) &&
                    !string.IsNullOrEmpty(txtDescripción.Text) &&
                    !string.IsNullOrEmpty(txtNombreRepuesto.Text) &&
                    int.TryParse(txtStockR.Text, out int stock))
                {

                    entRepuesto repuesto = new entRepuesto
                    {
                        codigo = txtCodigoRepuesto.Text,
                        nombre = txtNombreRepuesto.Text,
                        descripcion = txtDescripción.Text,
                        stock = stock,
                        estado = "Registrado",
                        fecha_registro = DateTime.Now
                    };

                    // Registrar el repuesto
                    logRepuestos.Instancia.InsertarRepuesto(repuesto);
                    MessageBox.Show("Repuesto añadido exitosamente.");
                    LimpiarVariables();
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca valores válidos para los campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHistorial_Click_1(object sender, EventArgs e)
        {
            Form historial = new RepuestoHistorialForm();
            historial.Show();
        }
    }
}
