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
            datPedidoInstalacion.Instancia.InsertarPedidoInstalacion(pedido);
            PedidoInstalacionAgregado?.Invoke();
        }

        // Método para terminar un pedido de instalación
        public void TerminarPedidoRepuesto(int numeroOrden)
        {
            datPedidoInstalacion.Instancia.TerminarPedidoRepuesto(numeroOrden);
        }

        public int ObtenerUltimoNumeroOrden()
        {
            int ultimoNumeroOrden = 0;
            SqlCommand cmd = new SqlCommand("SELECT MAX(NumeroOrden) FROM pedidosinstalacion", Conexion.Instancia.Conectar());

            try
            {
                cmd.Connection.Open();
                object resultado = cmd.ExecuteScalar();
                ultimoNumeroOrden = resultado != DBNull.Value ? Convert.ToInt32(resultado) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el último número de orden: " + ex.Message, ex);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return ultimoNumeroOrden;
        }

    }
}
