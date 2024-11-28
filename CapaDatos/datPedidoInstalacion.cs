using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.PedidoMateriales;
using static CapaEntidad.PedidoInstalacion;
using System.Windows.Forms;

namespace CapaDatos
{
    public class datPedidoInstalacion
    {
        private static readonly datPedidoInstalacion _instancia = new datPedidoInstalacion();

        public static datPedidoInstalacion Instancia
        {
            get { return datPedidoInstalacion._instancia; }
        }

        // Método para mostrar los pedidos de instalaciones
        public List<PedidoInstalacion.entPedidoInstalacion> ListarPedidoInstalacion()
        {
            SqlCommand cmd = null;
            List<PedidoInstalacion.entPedidoInstalacion> lista = new List<PedidoInstalacion.entPedidoInstalacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_PEDIDOS_INSTALACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedidoInstalacion PedidoInstalacion = new entPedidoInstalacion();
                    PedidoInstalacion.PedidoDeInstalaciónID = Convert.ToInt32(dr["PedidoDeInstalaciónID"]);
                    PedidoInstalacion.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    PedidoInstalacion.FechaFin = dr["FechaFin"] != DBNull.Value ? Convert.ToDateTime(dr["FechaFin"]) : (DateTime?)null;
                    PedidoInstalacion.Estado = dr["Estado"].ToString();
                    PedidoInstalacion.TipoInstalacion = dr["TipoInstalacion"].ToString();
                    PedidoInstalacion.PersonalID = Convert.ToInt32(dr["PersonalID"]);
                    PedidoInstalacion.ContratoID = Convert.ToInt32(dr["ContratoID"]);
                    lista.Add(PedidoInstalacion);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }


        // Método para registrar un nuevo pedido de instalacion
        public bool RegistrarPedidoInstalacion(PedidoInstalacion.entPedidoInstalacion pedidoInstalacion)
        {
            SqlCommand cmd = null;
            bool registrado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_REGISTRAR_PEDIDO_INSTALACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir parámetros al StoredProcedure
                cmd.Parameters.AddWithValue("@ContratoID", pedidoInstalacion.ContratoID);
                cmd.Parameters.AddWithValue("@PersonalID", pedidoInstalacion.PersonalID);
                cmd.Parameters.AddWithValue("@Estado", pedidoInstalacion.Estado);
                cmd.Parameters.AddWithValue("@TipoInstalación", pedidoInstalacion.TipoInstalacion);
                cmd.Parameters.AddWithValue("@FechaRegistro", pedidoInstalacion.FechaRegistro);
                cmd.Parameters.AddWithValue("@FechaFin", pedidoInstalacion.FechaFin.HasValue ? (object)pedidoInstalacion.FechaFin.Value : DBNull.Value);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registrado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pedido de instalacion: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }

            return registrado;
        }



        // Método para terminar un pedido de instalacion
        public void TerminarPedidoInstalacion(int idPedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_ANULAR_PEDIDO_INSTALACION", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoDeInstalaciónID", idPedido);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Pedido finalizado correctamente.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al finalizar el pedido: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

    }
}
