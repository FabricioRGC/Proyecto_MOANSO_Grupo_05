using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Planes
    {
        public class entPlanes
        {

            public string PlanNombre { get; set; }
            public string VelocidadMbps { get; set; }
            public float PrecioMensual { get; set; }
            public string estado { get; set; }
            public string TipoServicio { get; set; }
            public string Caracteristicas { get; set; }
            public int Zona_de_cobertura_id { get; set; }



        }

    }
}
