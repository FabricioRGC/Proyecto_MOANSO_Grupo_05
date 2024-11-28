using CapaEntidad;
using System;
using System.Collections.Generic;
using CapaDatos;
using System.Data.SqlClient;

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
            return datPedidoInstalacion.Instancia.ListarPedidoInstalacion();
        }

        // Método para añadir un pedido de instalación
        public void InsertarPedidoInstalacion(PedidoInstalacion.entPedidoInstalacion pedido)
        {
            datPedidoInstalacion.Instancia.RegistrarPedidoInstalacion(pedido);
            PedidoInstalacionAgregado?.Invoke();
        }

        // Método para terminar un pedido de instalación
        public void TerminarPedidoRepuesto(int numeroOrden)
        {
            datPedidoInstalacion.Instancia.TerminarPedidoInstalacion(numeroOrden);
        }

    }
}
