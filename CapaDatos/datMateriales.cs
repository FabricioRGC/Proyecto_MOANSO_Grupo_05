using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.Material;



namespace CapaDatos
{
    public class datMateriales
    {
       private static readonly datMateriales _instancia = new datMateriales();

       public static datMateriales Instancia
       {
          get { return datMateriales._instancia; }
       }
    }
}
