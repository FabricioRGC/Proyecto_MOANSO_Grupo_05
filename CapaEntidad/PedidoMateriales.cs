using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PedidoMateriales
    {
        public class entPedidoMateriales
        {
            public int PedidoMaterialesID { get; set; }
            public int Stock { get; set; }
            public int MaterialID { get; set; }
            public int PersonalID { get; set; }
            public DateTime FechaRealizacion { get; set; }
            public DateTime? FechaEntrega { get; set; }
            public string Estado { get; set; }
        }
    }
}
