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
            public long Id { get; set; }
            public long RepuestoId { get; set; }
            public int Cantidad { get; set; }
            public DateTime Fecha { get; set; }
            public string Estado { get; set; }
        }
    }
}
