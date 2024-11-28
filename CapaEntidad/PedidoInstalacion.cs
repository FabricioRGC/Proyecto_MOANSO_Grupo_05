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
            public int PedidoDeInstalaciónID { get; set; }
            public int ContratoID { get; set; }
            public int PersonalID { get; set; }
            public DateTime FechaRegistro { get; set; }
            public DateTime? FechaFin { get; set; }
            public string TipoInstalacion { get; set; }
            public string Estado { get; set; }
        }
    }
}
