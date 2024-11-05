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
            public long id { get; set; }        
            public long material_id { get; set; }     
            public long tecnico_id { get; set; }       
            public int cantidad_solicitada { get; set; }          
            public int? cantidad_entregada { get; set; } 
            public DateTime fecha { get; set; }      
            public DateTime? fecha_entrega { get; set; }
            public string estado { get; set; }
            public string observaciones { get; set; }
        }
    }
}
