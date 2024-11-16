using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Planes;
using static CapaEntidad.Material;

namespace CapaLogica
{
    public class logPlanes
    {
        private static readonly logPlanes _instancia = new logPlanes();

        public static logPlanes Instancia
        {
            get { return logPlanes._instancia; }
        }

        // Metodo para listar los materiales
        public List<entPlanes> ListarPlanes()
        {
            return datPlanes.Instancia.ListarPlanes();
        }

        // Metodo para añadir un Planes
        public void InsertarPlanes(entPlanes plan)
        {
            datPlanes.Instancia.InsertarPlanes(plan);
        }


        // Metodo para actualizar un Planes
        public void EditarPlanes(entPlanes plan)
        {
            datPlanes.Instancia.EditarPlanes(plan);
        }

        // Metodo para deshabilitar un Planes
        public void DeshabilitarPlanes(entPlanes plan)
        {
            datPlanes.Instancia.DeshabilitarPlanes(plan);
        }
    }
}
