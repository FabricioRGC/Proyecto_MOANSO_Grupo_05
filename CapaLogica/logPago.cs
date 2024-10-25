using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using static CapaEntidad.Pago;

namespace CapaLogica
{
    public class logPago
    {
        private static readonly logPago _instancia = new logPago();

        public static logPago Instancia
        {
            get { return logPago._instancia; }
        }

        // Método para listar pagos
        public List<entPago> ListarPagos()
        {
            return datPago.Instancia.ListarPago();
        }

        // Método para añadir un pago
        public void InsertarPago(entPago pag)
        {
            datPago.Instancia.InsertarPago(pag);
        }
    }
}
