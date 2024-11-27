using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPlanificacionMantenimiento
    {
        public int Id { get; set; }  // P_MantenimientoPreventivoID
        public DateTime FechaProgramacion { get; set; }
        public string Estado { get; set; }
        public int Frecuencia { get; set; }
        public int ContratoID { get; set; }
        public int RepuestosID { get; set; }
    }
}

