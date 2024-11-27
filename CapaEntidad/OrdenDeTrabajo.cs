using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class OrdenDeTrabajo
    {

        public class entOrdenDeTrabajo
        {
            public int OrdenDeTrabajoID { get; set; }
            public int MantenimientoPreventivoID { get; set; }
            public DateTime FechaRegistro { get; set; }
            public int PersonalID { get; set; }
            public DateTime FechaEjecución { get; set; }
            public string Tipo { get; set; }
            public string Estado { get; set; }
            public int ClienteID { get; set; }
            public int PedidoDeInstalacionID { get; set; }

        }
    }
}