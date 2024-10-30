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
            public string clienteId { get; set; }
            public DateTime fechaInicio { get; set; }
            public string duracion { get; set; }
            public string estado { get; set; }
            public string tipo_plan { get; set; }
            public string clausula { get; set; }
        }
    }
}
