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
using static CapaEntidad.Personal;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PlanificacionMantenimientoForm : Form
    {
        public PlanificacionMantenimientoForm()
        {
            InitializeComponent();
            CargarPlanificaciones();
            CargarPersonalComboBox();
            CargarPersonal();
        }
        private void PlanificacionMantenimientoForm_Load(object sender, EventArgs e)
        {
            CargarPlanificaciones(); // Llama al método para cargar planificaciones al iniciar el formulario
            CargarPersonalComboBox();
        }
        private void CargarPersonalComboBox()
        {
            try
            {
                List<entPersonal> personalList = logPersonal.Instancia.listarPersonal();
                cbPersonal.Items.Clear(); // Asegúrate de limpiar antes de cargar nuevos datos

                foreach (var personal in personalList)
                {
                    cbPersonal.Items.Add(personal.nombre); // Añade solo el nombre al ComboBox
                }

                if (cbPersonal.Items.Count > 0)
                {
                    cbPersonal.SelectedIndex = 0; // Selecciona el primer ítem por defecto si hay elementos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el personal técnico: " + ex.Message);
            }
        }
        private void CargarPlanificaciones()
        {
            {
                try
                {
                    var planificaciones = logPlanificacionMantenimiento.Instancia.ListarPlanificaciones();
                    dgvMante.DataSource = planificaciones;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las planificaciones: " + ex.Message);
                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTipo.Text) || string.IsNullOrWhiteSpace(txtRecursos.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de añadir una planificación.");
                    return;
                }

                entPlanificacionMantenimiento nuevaPlanificacion = new entPlanificacionMantenimiento
                {
                    Tipo = txtTipo.Text.Trim(),
                    Fecha = datePickerFecha.Value,
                    Recursos_Asignados = txtRecursos.Text.Trim(),
                    Estado = "Planificado",
                    NombrePersonal = cbPersonal.Text // Captura el nombre seleccionado del ComboBox
                };

                logPlanificacionMantenimiento.Instancia.InsertarPlanificacion(nuevaPlanificacion);

                MessageBox.Show("La planificación de mantenimiento ha sido añadida con éxito.");
                txtTipo.Clear();
                txtRecursos.Clear();
                datePickerFecha.Value = DateTime.Now;
                CargarPlanificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir la planificación: " + ex.Message);
            }
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dgvMante.SelectedRows.Count > 0)
            {
                int idPlanificacion = Convert.ToInt32(dgvMante.SelectedRows[0].Cells["Id"].Value);

                try
                {
                    logPlanificacionMantenimiento.Instancia.DeshabilitarPlanificacion(idPlanificacion);
                    MessageBox.Show("Planificación inhabilitada exitosamente.");
                    CargarPlanificaciones(); // Refresca el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al inhabilitar la planificación: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una planificación para inhabilitar.");
            }
        }
        private void CargarPersonal()
        {
            cbPersonal.DataSource = logPersonal.Instancia.listarPersonal();
            cbPersonal.DisplayMember = "nombre"; // Campo que se muestra en el ComboBox
            cbPersonal.ValueMember = "nombre"; // Este podría ser "Id" si usas el ID como valor
        }
    }
}
