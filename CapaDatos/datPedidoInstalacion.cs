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
                cmd = new SqlCommand("SP_MOSTRAR_PedidoInstalacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PedidoInstalacion.entPedidoInstalacion pedido = new PedidoInstalacion.entPedidoInstalacion
                    {
                        NumeroOrden = Convert.ToInt32(dr["NumeroOrden"]),
                        IDInstalacion = Convert.ToInt32(dr["IDInstalacion"]),
                        FechaOrden = DateTime.Parse(dr["FechaOrden"].ToString()),
                        Telefono = dr["Telefono"].ToString(),
                        IDJefeSoporteTecnico = Convert.ToInt32(dr["IDJefeSoporteTecnico"]),
                        FechaInicio = DateTime.Parse(dr["FechaInicio"].ToString()), // No puede ser NULL
                        FechaFin = dr["FechaFin"] != DBNull.Value ? DateTime.Parse(dr["FechaFin"].ToString()) : (DateTime?)null, // Manejo de FechaFin que puede ser NULL
                        HoraInicio = dr["HoraInicio"] != DBNull.Value ? TimeSpan.Parse(dr["HoraInicio"].ToString()) : TimeSpan.Zero,
                        HoraFin = dr["HoraFin"] != DBNull.Value ? TimeSpan.Parse(dr["HoraFin"].ToString()) : TimeSpan.Zero,
                        TipoInstalacion = dr["TipoInstalacion"].ToString(),
                        Ubicacion = dr["Ubicacion"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Observaciones = dr["Observaciones"].ToString(),
                        Estado = dr["Estado"].ToString()
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
                cmd = new SqlCommand("SP_AÑADIR_PedidosInstalacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroOrden", pedido.NumeroOrden);
                cmd.Parameters.AddWithValue("@IDInstalacion", pedido.IDInstalacion);
                cmd.Parameters.AddWithValue("@FechaOrden", pedido.FechaOrden);
                cmd.Parameters.AddWithValue("@Telefono", pedido.Telefono);
                cmd.Parameters.AddWithValue("@IDJefeSoporteTecnico", pedido.IDJefeSoporteTecnico);
                cmd.Parameters.AddWithValue("@FechaInicio", pedido.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", (object)pedido.FechaFin ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraInicio", pedido.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", pedido.HoraFin);
                cmd.Parameters.AddWithValue("@TipoInstalacion", pedido.TipoInstalacion);
                cmd.Parameters.AddWithValue("@Ubicacion", pedido.Ubicacion);
                cmd.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                cmd.Parameters.AddWithValue("@Observaciones", pedido.Observaciones);
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


        // Método para anular un pedido de instalación
        public void AnularPedidoInstalacion(int numeroOrden)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_PEDIDOS_INSTALACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NumeroOrden", numeroOrden);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al anular el pedido de instalación: " + ex.Message, ex);
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }

    }
}
