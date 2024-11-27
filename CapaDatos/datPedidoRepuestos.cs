using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDatos
{
    public class datPedidoRepuestos
    {
        private static readonly datPedidoRepuestos _instancia = new datPedidoRepuestos();

        public static datPedidoRepuestos Instancia
        {
            get { return datPedidoRepuestos._instancia; }
        }


        // Método para registrar un pedido de repuestos
        public void RegistrarPedidoRepuesto(PedidoRepuestos.entOrdenPedidoRepuestos pedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PEDIDO_REPUESTOS", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nombreRepuesto", SqlDbType.NVarChar, 30).Value = pedido.nombreRepuesto;
                    cmd.Parameters.Add("@nombreTecnico", SqlDbType.NVarChar, 30).Value = pedido.nombreTecnico;
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = pedido.fecha == DateTime.MinValue ? (object)DBNull.Value : pedido.fecha;
                    cmd.Parameters.Add("@fecha_entrega", SqlDbType.Date).Value = pedido.fecha_entrega == DateTime.MinValue ? (object)DBNull.Value : pedido.fecha_entrega;
                    cmd.Parameters.Add("@estado", SqlDbType.NVarChar, 20).Value = "Pendiente";

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al registrar el pedido de repuestos: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        public void TerminarPedidoRepuesto(long idPedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_TERMINAR_PEDIDO_REPUESTOS", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idPedido);

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al terminar el pedido: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        public List<PedidoRepuestos.entOrdenPedidoRepuestos> ListarPedidosRepuestos()
        {
            List<PedidoRepuestos.entOrdenPedidoRepuestos> lista = new List<PedidoRepuestos.entOrdenPedidoRepuestos>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ordenespedidorepuestos", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            PedidoRepuestos.entOrdenPedidoRepuestos pedidoRepuesto = new PedidoRepuestos.entOrdenPedidoRepuestos
                            {
                                id = Convert.ToInt64(dr["id"]),
                                nombreRepuesto = dr["nombreRepuesto"].ToString(),
                                nombreTecnico = dr["nombreTecnico"].ToString(),
                                fecha = Convert.ToDateTime(dr["fecha"]),
                                fecha_entrega = dr["fecha_entrega"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_entrega"]) : (DateTime?)null,
                                estado = dr["estado"].ToString()
                            };

                            lista.Add(pedidoRepuesto);
                        }
                    }
                }
            }
            return lista;
        }

    }
}
