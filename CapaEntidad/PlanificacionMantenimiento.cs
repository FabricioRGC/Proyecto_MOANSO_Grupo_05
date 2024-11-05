using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPlanificacionMantenimiento
    {
        public int Id { get; set; }
        public string Tipo { get; set; } // Coincide con la columna 'tipo'
        public DateTime Fecha { get; set; }
        public string Recursos_Asignados { get; set; } // Coincide con 'recursos_asignados'
        public string Estado { get; set; }

        public string NombrePersonal { get; set; }
    }
}

