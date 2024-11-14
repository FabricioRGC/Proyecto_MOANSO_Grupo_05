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
using CapaDatos;
using static CapaEntidad.OrdenPedidoMaterial;
using CapaEntidad;
using static CapaEntidad.PedidoInstalacion;
using static CapaEntidad.OrdenPedidoRepuestos;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class OrdenPedidoMaterialForm : Form
    {
        public OrdenPedidoMaterialForm()
        {
            InitializeComponent();
            ListarPedidosMateriales();
        }

        private void limpiarVariables()
        {
            dtpFechaEntrega.Value = DateTime.Now;
            dtpFechaRealizacion.Value = DateTime.Now;
        }

        public void ListarPedidosMateriales()
        {
            dataGridMateriales.DataSource = logOrdenPedidoMaterial.Instancia.ListarPedidosMaterial();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (cboRepuestos.SelectedIndex == -1 || cboTecnico.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Crear la instancia del pedido con el estado como 'Pendiente' por defecto
                entOrdenPedidoRepuestos pedidoRepuestos = new entOrdenPedidoRepuestos
                {
                    nombreRepuesto = cboRepuestos.SelectedItem.ToString(),
                    nombreTecnico = cboTecnico.SelectedItem.ToString(),
                    fecha = dtpFechaRealizacion.Value.Date,
                    fecha_entrega = dtpFechaEntrega.Value.Date,
                    estado = "Pendiente"
                };

                // Registrar el pedido
                logOrdenPedidoRepuestos.Instancia.InsertarPedidoRepuesto(pedidoRepuestos);
                MessageBox.Show("Pedido de Repuesto añadido exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonHistorialPeMat_Click(object sender, EventArgs e)
        {
            Form historial = new OrPeMaterialHistorialForm();
            historial.Show();
        }
    }
}
