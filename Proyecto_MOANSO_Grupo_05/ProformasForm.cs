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

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class ProformasForm : Form
    {
        public ProformasForm()
        {
            InitializeComponent();
            listarProforma();
        }

        public void listarProforma()
        {
            tablaProformas.DataSource = logProforma.Instancia.ListarProforma();
        }

        private void limpiarVariables()
        {

        }

        // ----- ACCIONES -----

        // Boton Añadir
        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }
    }
}
