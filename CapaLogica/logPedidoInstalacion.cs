using CapaEntidad;
using System;
using System.Collections.Generic;
using CapaDatos;

namespace CapaLogica
{
    public class logPedidoInstalacion
    {
        private static readonly logPedidoInstalacion _instancia = new logPedidoInstalacion();

        public static logPedidoInstalacion Instancia
        {
            get { return logPedidoInstalacion._instancia; }
        }

        public event Action PedidoInstalacionAgregado;

        // Método para listar pedidos de instalación
        public List<PedidoInstalacion.entPedidoInstalacion> ListarPedidosInstalacion()
        {
            return datPedidoInstalacion.Instancia.ListarPedidosInstalacion();
        }

        // Método para añadir un pedido de instalación
        public void InsertarPedidoInstalacion(PedidoInstalacion.entPedidoInstalacion pedido)
        {
            datPedidoInstalacion.Instancia.InsertarPedidoInstalacion(pedido);
            PedidoInstalacionAgregado?.Invoke();
        }

        // Método para anular un pedido de instalación
        public void AnularPedidoInstalacion(int numeroOrden)
        {
            datPedidoInstalacion.Instancia.AnularPedidoInstalacion(numeroOrden);
        }
    }
}
