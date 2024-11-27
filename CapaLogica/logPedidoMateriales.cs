using CapaDatos;
using static CapaEntidad.PedidoMateriales;
using System.Collections.Generic;
using System;

namespace CapaLogica
{
    public class logPedidoMateriales
    {
        // Singleton
        private static readonly logPedidoMateriales _instancia = new logPedidoMateriales();

        public static logPedidoMateriales Instancia
        {
            get { return _instancia; }
        }

        // Método para listar pedidos de materiales
        public List<entPedidoMateriales> ListarPedidosMaterial()
        {
            return datPedidoMateriales.Instancia.ListarPedidoMateriales();
        }

        // Método para registrar un pedido de materiales
        public void RegistrarPedidoMaterial(entPedidoMateriales pedido)
        {
            // Registrar el pedido
            datPedidoMateriales.Instancia.RegistrarPedidoMateriales(pedido);
        }

        // Método para terminar un pedido de materiales
        public void TerminarPedidoMateriales(int idPedido)
        {
            datPedidoMateriales.Instancia.TerminarPedidoMateriales(idPedido);
        }
    }
}

