using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaLogica
{
    public class logOrdenPedidoRepuestos
    {
        private static readonly logOrdenPedidoRepuestos _instancia = new logOrdenPedidoRepuestos();

        public static logOrdenPedidoRepuestos Instancia
        {
            get { return logOrdenPedidoRepuestos._instancia; }
        }

        public event Action PedidoAgregado;

        // Método para listar pedidos de repuestos
        public List<OrdenPedidoRepuestos.entOrdenPedidoRepuestos> ListarPedidosRepuestos()
        {
            return datOrdenPedidoRepuestos.Instancia.ListarPedidosRepuestos();
        }

        // Método para añadir un pedido de repuestos
        public void InsertarPedidoRepuesto(OrdenPedidoRepuestos.entOrdenPedidoRepuestos pedido)
        {
            datOrdenPedidoRepuestos.Instancia.RegistrarPedidoRepuesto(pedido);
            PedidoAgregado?.Invoke();
        }

        // Método para anular un pedido de repuestos
        public void AnularPedidoRepuesto(long id)
        {
            datOrdenPedidoRepuestos.Instancia.AnularPedidoRepuesto(id);
        }
    }
}
