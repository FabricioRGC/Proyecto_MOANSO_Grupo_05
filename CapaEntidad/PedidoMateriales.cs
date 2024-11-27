using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PedidoMateriales
    {
        public class entOrdenPedidoMateriales
        {
            public long id { get; set; }
            public string nombreMaterial { get; set; }
            public string nombreTecnico { get; set; }
            public DateTime fecha { get; set; }
            public DateTime? fecha_entrega { get; set; }
            public string estado { get; set; }
        }
    }
}
