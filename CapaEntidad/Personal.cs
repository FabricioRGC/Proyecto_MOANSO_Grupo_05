using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{


    public class Personal
    {
        public class entPersonal
        {
            public int PersonalID { get; set; } // ID único de la persona
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int DNI { get; set; }
            public int Teléfono { get; set; }
            public string Estado { get; set; }
            public string Cargo { get; set; }
            public string AreaTrabajo { get; set; }
        }
    }

}
