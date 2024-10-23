using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Cliente;
using CapaDatos;

namespace CapaLogica
{
    public class logCliente
    {
        // Patron Singleton
        private static readonly logCliente _instancia = new logCliente();

        public static logCliente Instancia
        {
            get { return logCliente._instancia; }
        }

        // Metodo para listar los clientes
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        // Metodo para añadir un cliente
        public void InsertaCliente(entCliente cli)
        {
            datCliente.Instancia.InsertarCliente(cli);
        }

        // Metodo para actualizar un cliente
        public void EditarCliente(entCliente cli)
        {
            datCliente.Instancia.EditarCliente(cli);
        }

        // Metodo para deshabilitar un cliente
        public void DeshabilitarCliente(entCliente cli)
        {
            datCliente.Instancia.DeshabilitaCliente(cli);
        }
    }
}
