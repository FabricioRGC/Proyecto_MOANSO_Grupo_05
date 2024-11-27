using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaLogica
{
    public class logPedidoRepuestos
    {
        private static readonly logPedidoRepuestos _instancia = new logPedidoRepuestos();

        public static logPedidoRepuestos Instancia
        {
            get { return logPedidoRepuestos._instancia; }
        }

        // Método para listar pedidos de repuestos
        public List<PedidoRepuestos.entOrdenPedidoRepuestos> ListarPedidosRepuestos()
        {
            return datPedidoRepuestos.Instancia.ListarPedidosRepuestos();
        }

        // Método para añadir un pedido de repuestos
        public void InsertarPedidoRepuesto(PedidoRepuestos.entOrdenPedidoRepuestos pedido)
        {
            datPedidoRepuestos.Instancia.RegistrarPedidoRepuesto(pedido);
        }

        // Método para anular un pedido de repuestos
        public void TerminarPedidoRepuesto(long id)
        {
            datPedidoRepuestos.Instancia.TerminarPedidoRepuesto(id);
        }
    }
}
