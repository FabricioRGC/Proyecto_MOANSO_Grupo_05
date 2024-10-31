using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using static CapaEntidad.Cliente;
using static CapaEntidad.Personal;
using CapaEntidad;

namespace CapaLogica
{
    public class logPersonal
    {
        // Singleton
        private static readonly logPersonal _instancia = new logPersonal();

        public static logPersonal Instancia
        {
            get { return logPersonal._instancia; }
        }

        // Método para listar el personal técnico
        public List<entPersonal> listarPersonal()
        {
            return datPersonal.Instancia.listarPersonal();
        }

        // Método para añadir un personal
        public void InsertarPersonal(entPersonal personal)
        {
            datPersonal.Instancia.InsertarPersonal(personal);
        }

        // Método para deshabilitar un personal
        public void DeshabilitarPersonal(entPersonal personal)
        {
            datPersonal.Instancia.DeshabilitaPersonal(personal);
        }
    }
}

