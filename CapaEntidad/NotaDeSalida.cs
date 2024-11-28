using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class NotaDeSalida
    {
        public class entNotadesalida
        {
            public int NotadeSalidaID { get; set; }
            public int PedidiMaterialesID { get; set; }
            public int PedidiRepuestosID { get; set; }
            public DateTime FechadeEmision { get; set; }
            public string Estado { get; set; }
            public int MaterialID { get; set; }
            public int RepuestoID { get; set; }
        }
    }
}
