using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.OrdenDeTrabajo;
using CapaDatos;

namespace CapaLogica
{
    public class logOrdenDeTrabajo
    {
        private static readonly logOrdenDeTrabajo _instancia = new logOrdenDeTrabajo();

        public static logOrdenDeTrabajo Instancia
        {
            get { return logOrdenDeTrabajo._instancia; }
        }


        // Metodo para listar los ordendetrabajo
        public List<entOrdenDeTrabajo> ListarOrdenDeTrabajo()
        {
            return datOrdenDeTrabajo.Instancia.ListarOrdenDeTrabajo();
        }

        // Metodo para añadir un ordendetrabajo
        public void InsertarOrdenDeTrabajo(entOrdenDeTrabajo mat)
        {
            datOrdenDeTrabajo.Instancia.InsertarOrdenDeTrabajo(mat);
        }



        // Metodo para deshabilitar un ordendetrabajoriales
        public void TerminarOrdenDeTrabajo(entOrdenDeTrabajo mat)
        {
            datOrdenDeTrabajo.Instancia.TerminarOrdenDeTrabajo(mat);
        }




    }
}
