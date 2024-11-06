using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Material
    {
        public class entMateriales 
        {

            public string codigo { get; set; }

          //  public DateTime fechaInicio { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public int stock { get; set; }
            public string estado { get; set; }

            public string Categoria { get; set; }

            
        }
    }
}
