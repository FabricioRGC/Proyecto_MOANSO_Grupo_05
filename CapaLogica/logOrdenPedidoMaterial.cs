using CapaDatos;
using static CapaEntidad.OrdenPedidoMaterial;
using System.Collections.Generic;
using System;

namespace CapaLogica
{
    public class logOrdenPedidoMaterial
    {
        // Singleton
        private static readonly logOrdenPedidoMaterial _instancia = new logOrdenPedidoMaterial();

        public static logOrdenPedidoMaterial Instancia
        {
            get { return _instancia; }
        }

        // Evento para notificar que se ha agregado un pedido
        public event Action PedidoAgregado;

        // Método para listar pedidos de materiales
        public List<entOrdenPedidoMateriales> ListarPedidosMaterial()
        {
            return datOrdenPedidoMaterial.Instancia.ListarPedidosMateriales();
        }

        // Método para registrar un pedido de materiales
        public void RegistrarPedidoMaterial(entOrdenPedidoMateriales pedido)
        {
            // Registrar el pedido
            datOrdenPedidoMaterial.Instancia.RegistrarPedidoMaterial(pedido);
            // Disparar el evento después de registrar el pedido
            PedidoAgregado?.Invoke();
        }

        // Método para anular un pedido de materiales
        public void AnularPedidoMaterial(long idPedido)
        {
            datOrdenPedidoMaterial.Instancia.AnularPedidoMaterial(idPedido);
        }
    }
}

