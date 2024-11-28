using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PedidoRepuestos
    {
        public class entPedidoRepuestos
        {
            public int PedidoDeRepuestosID { get; set; }
            public int Stock { get; set; }
            public int RepuestosID { get; set; }
            public int PersonalID { get; set; }
            public int OrdenDeTrabajoID { get; set; }
            public DateTime FechaRealizacion { get; set; }
            public DateTime? FechaEntrega { get; set; }
            public string Estado { get; set; }
        }
    }
}
