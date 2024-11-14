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
        }

        // Método para terminar un pedido de materiales
        public void TerminarPedidoMaterial(long idPedido)
        {
            datOrdenPedidoMaterial.Instancia.TerminarPedidoMaterial(idPedido);
        }
    }
}

