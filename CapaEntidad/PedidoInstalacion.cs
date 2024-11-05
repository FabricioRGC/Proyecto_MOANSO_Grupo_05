using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PedidoInstalacion
    {
        public class entPedidoInstalacion
        {
            public int NumeroOrden { get; set; }
            public int IDInstalacion { get; set; }
            public DateTime FechaOrden { get; set; }
            public string Telefono { get; set; }
            public int IDJefeSoporteTecnico { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime? FechaFin { get; set; }
            public TimeSpan HoraInicio { get; set; }
            public TimeSpan HoraFin { get; set; }
            public string TipoInstalacion { get; set; }
            public string Ubicacion { get; set; }
            public string Descripcion { get; set; }
            public string Observaciones { get; set; }
            public string Estado { get; set; } = "Registrado";
        }
    }
}
