using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Repuesto
    {
        public class entRepuesto
        {
            public string CódigoRepuesto { get; set; }
            public string NombreRepuesto { get; set; }
            public int Stock { get; set; }
            public string Estado { get; set; }
            public string Descripcion { get; set; }
            public string CategoriaRepuestoID { get; set; }
        }
    }
}
