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
            public string cliente_id { get; set; }
            public string fecha_inicio { get; set; }
            public string tipo_plan { get; set; }
            public string precio { get; set; }
        }
    }
}
