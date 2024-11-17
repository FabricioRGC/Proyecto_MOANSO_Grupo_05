using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ProformaVenta
    {
        public class entProformaVenta
        {
            public int cliente_id { get; set; }
            public DateTime fecha_inicio { get; set; }
            public DateTime fecha_fin { get; set; }
            public int servicio_id { get; set; }
            public int personal_id { get; set; }
        }
    }
}
