using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Contrato
    {
        public class entContrato
        {
            public int id_cliente { get; set; }
            public DateTime fechaInicio { get; set; }
            public int duracion { get; set; }
            public string estado { get; set; }
            public int id_servicio { get; set; }
        }
    }
}
