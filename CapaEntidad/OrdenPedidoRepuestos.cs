using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OrdenPedidoRepuestos
    {
        public class entOrdenPedidoRepuestos
        {
            public long id { get; set; }
            public string nombreRepuesto { get; set; }
            public string nombreTecnico { get; set; }
            public DateTime fecha { get; set; }
            public DateTime? fecha_entrega { get; set; }
            public string estado { get; set; }
        }
    }
}
