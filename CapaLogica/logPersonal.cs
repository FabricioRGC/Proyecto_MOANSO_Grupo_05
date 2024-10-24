using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using static CapaEntidad.Cliente;
using static CapaEntidad.Personal;

namespace CapaLogica
{
    public class logPersonal
    {
        //sigleton
        private static readonly logPersonal _instancia = new logPersonal();

        public static logPersonal Instancia
        {
            get { return logPersonal._instancia; }
        }
        public List<entPersonal> listarPersonal()
        {
            return datPersonal.Instancia.listarPersonal();
        }
        // Metodo para añadir un cliente
        public void InsertarPersonal(entPersonal cli)
        {
            datPersonal.Instancia.InsertarPersonal(cli);
        }
        //pruebaa

        // Metodo para deshabilitar un cliente
        public void DeshabilitarPersonal(entPersonal cli)
        {
            datPersonal.Instancia.DeshabilitaPersonal(cli);
        }
    }

}
