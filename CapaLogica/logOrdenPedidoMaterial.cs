using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logOrdenPedidoMaterial
    {
        // Singleton
        private static readonly logOrdenPedidoMaterial _instancia = new logOrdenPedidoMaterial();

        public static logOrdenPedidoMaterial Instancia
        {
            get { return logOrdenPedidoMaterial._instancia; }
        }

        // Método para listar pedidos de materiales
        public List<OrdenPedidoMaterial.entOrdenPedidoMateriales> ListarPedidosMaterial()
        {
            return datOrdenPedidoMaterial.Instancia.ListarPedidosMateriales();
        }

        // Método para registrar un pedido de materiales
        public void RegistrarPedidoMaterial(OrdenPedidoMaterial.entOrdenPedidoMateriales pedido)
        {
            datOrdenPedidoMaterial.Instancia.RegistrarPedidoMaterial(pedido);
        }

        // Método para anular un pedido de materiales
        public void AnularPedidoMaterial(long idPedido)
        {
            datOrdenPedidoMaterial.Instancia.AnularPedidoMaterial(idPedido);
        }
    }
}
