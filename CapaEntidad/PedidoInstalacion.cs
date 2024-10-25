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
            public long id { get; set; }
            public DateTime fecha { get; set; }
            public string estado { get; set; }
        }
    }
}
