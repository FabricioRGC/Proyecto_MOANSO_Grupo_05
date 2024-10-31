using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OrdenPedidoMaterial
    {
        public class entOrdenPedidoMateriales
        {
            public long id { get; set; }               // ID del pedido
            public long material_id { get; set; }      // ID del material
            public long cliente_id { get; set; }       // ID del cliente
            public int cantidad_solicitada { get; set; }           // Cantidad solicitada
            public int? cantidad_entregada { get; set; } // Cantidad entregada (opcional)
            public DateTime fecha { get; set; }         // Fecha del pedido
            public DateTime? fecha_entrega { get; set; } // Fecha de entrega (opcional)
            public string estado { get; set; }
            public string observaciones { get; set; }
        }
    }
}
