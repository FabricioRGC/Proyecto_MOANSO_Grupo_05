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
        public List<PedidoInstalacion.entPedidoInstalacion> ListarPedidoInstalacion()
        {
            List<PedidoInstalacion.entPedidoInstalacion> lista = new List<PedidoInstalacion.entPedidoInstalacion>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM pedidosinstalacion", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            PedidoInstalacion.entPedidoInstalacion pedidoInstalacion = new PedidoInstalacion.entPedidoInstalacion
                            {
                                NumeroOrden = Convert.ToInt32(dr["numeroOrden"]),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                nombreTecnico = dr["nombreTecnico"].ToString(),
                                TipoInstalacion = dr["tipoInstalacion"].ToString(),
                                FechaInicio = Convert.ToDateTime(dr["fechaInicio"]),
                                FechaFin = dr["fechaFin"] != DBNull.Value ? Convert.ToDateTime(dr["fechaFin"]) : (DateTime?)null,
                                Estado = dr["estado"].ToString()
                            };

                            lista.Add(pedidoInstalacion);
                        }
                    }
                }
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
                cmd = new SqlCommand("SP_AÑADIR_PedidosInstalacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetros que coinciden con la tabla 'pedidosinstalacion'
                cmd.Parameters.AddWithValue("@nombreCliente", pedido.nombreCliente);
                cmd.Parameters.AddWithValue("@nombreTecnico", pedido.nombreTecnico);
                cmd.Parameters.AddWithValue("@FechaInicio", pedido.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", (object)pedido.FechaFin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TipoInstalacion", pedido.TipoInstalacion);
                cmd.Parameters.AddWithValue("@Estado", pedido.Estado);

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



        // Método para terminar un pedido de instalación
        public void TerminarPedidoRepuesto(int numeroOrden)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_TERMINAR_PEDIDOS_INSTALACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroOrden", numeroOrden);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al terminar el pedido de instalación: " + ex.Message, ex);
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }

    }
}
