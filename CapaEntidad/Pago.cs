using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pago
    {
        public class entPago
        {
            public string contrato_id { get; set; }
            public string monto { get; set; }
            public string fecha { get; set; }
            public string metodo_pago { get; set; }
            public string cliente_id { get; set; }
        }
    }
}
