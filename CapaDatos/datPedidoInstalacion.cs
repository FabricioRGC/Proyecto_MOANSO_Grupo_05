using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datPedidoInstalacion
    {
        private static readonly datPedidoInstalacion _instancia = new datPedidoInstalacion();

        public static datPedidoInstalacion Instancia
        {
            get { return datPedidoInstalacion._instancia; }
        }

        // Método para listar pedidos de instalación
        public List<PedidoInstalacion.entPedidoInstalacion> ListarPedidosInstalacion()
        {
            SqlCommand cmd = null;
            List<PedidoInstalacion.entPedidoInstalacion> lista = new List<PedidoInstalacion.entPedidoInstalacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_PedidosInstalacion", cn); // Asumiendo que tienes un SP para mostrar
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PedidoInstalacion.entPedidoInstalacion pedido = new PedidoInstalacion.entPedidoInstalacion
                    {
                        id = long.Parse(dr["id"].ToString()),
                        fecha = DateTime.Parse(dr["fecha"].ToString()),
                        estado = dr["estado"].ToString()
                    };
                    lista.Add(pedido);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return lista;
        }

        // Método para añadir un pedido de instalación
        public Boolean InsertarPedidoInstalacion(PedidoInstalacion.entPedidoInstalacion pedido)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_PedidoInstalacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", pedido.fecha);
                cmd.Parameters.AddWithValue("@estado", pedido.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserto = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return inserto;
        }

        // Método para anular un pedido de instalación
        public void AnularPedidoInstalacion(long id)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_PEDIDO_INSTALACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al anular el pedido de instalación: " + ex.Message);
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }

        // Método para consultar un pedido de instalación específico
        public PedidoInstalacion.entPedidoInstalacion ConsultarPedidoInstalacion(long id)
        {
            SqlCommand cmd = null;
            PedidoInstalacion.entPedidoInstalacion pedido = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_CONSULTAR_PEDIDO_INSTALACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pedido = new PedidoInstalacion.entPedidoInstalacion
                    {
                        id = long.Parse(dr["id"].ToString()),
                        fecha = DateTime.Parse(dr["fecha"].ToString()),
                        estado = dr["estado"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return pedido;
        }

    }
}
