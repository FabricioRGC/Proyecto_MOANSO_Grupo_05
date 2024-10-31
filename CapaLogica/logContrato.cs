using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Contrato;
using CapaDatos;
using static CapaEntidad.Cliente;

namespace CapaLogica
{
    public class logContrato
    {
        private static readonly logContrato _instancia = new logContrato();

        public static logContrato Instancia
        {
            get { return logContrato._instancia; }
        }

        // Método para listar los contratos
        public List<entContrato> ListarContrato()
        {
            return datContrato.Instancia.ListarContrato();
        }

        // Método para añadir un contrato
        public void InsertaContrato(entContrato con)
        {
            datContrato.Instancia.InsertarContrato(con);
        }

        // Método para actualizar un contrato
        //public void EditarContrato(entContrato con)
        //{
        //    datContrato.Instancia.ModificarContrato(con);
        //}

        public void AnularContrato (entContrato con)
        {
            datContrato.Instancia.AnularContrato(con);
        }
    }
}
