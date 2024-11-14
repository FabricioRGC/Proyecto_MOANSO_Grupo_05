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
            public string nombreCliente { get; set; }
            public string nombreTecnico { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime? FechaFin { get; set; }
            public string TipoInstalacion { get; set; }
            public string Estado { get; set; }
        }
    }
}
