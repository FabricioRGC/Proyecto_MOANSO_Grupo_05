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
    public class datOrdenPedidoRepuestos
    {
        private static readonly datOrdenPedidoRepuestos _instancia = new datOrdenPedidoRepuestos();

        public static datOrdenPedidoRepuestos Instancia
        {
            get { return datOrdenPedidoRepuestos._instancia; }
        }

        // Método para registrar un pedido de repuestos
        public void RegistrarPedidoRepuesto(OrdenPedidoRepuestos.entOrdenPedidoRepuestos pedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PEDIDO_REPUESTOS", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir parámetros desde el objeto pedido
                    cmd.Parameters.Add("@repuesto_id", SqlDbType.BigInt).Value = pedido.repuesto_id;
                    cmd.Parameters.Add("@tecnico_id", SqlDbType.BigInt).Value = pedido.tecnico_id;
                    cmd.Parameters.Add("@cantidad_solicitada", SqlDbType.Int).Value = pedido.cantidad_solicitada;
                    cmd.Parameters.Add("@cantidad_entregada", SqlDbType.Int).Value = pedido.cantidad_entregada;
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = pedido.fecha;
                    cmd.Parameters.Add("@fecha_entrega", SqlDbType.Date).Value = pedido.fecha_entrega;
                    cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar).Value = pedido.observaciones ?? (object)DBNull.Value;

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Manejo de errores SQL
                        MessageBox.Show("Error al registrar el pedido de repuestos: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de otros errores
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public void AnularPedidoRepuesto(long idPedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_ANULAR_PEDIDO_REPUESTOS", cn))
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
                        MessageBox.Show("Error al anular el pedido: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        // Método para listar todos los pedidos de repuestos
        public List<OrdenPedidoRepuestos.entOrdenPedidoRepuestos> ListarPedidosRepuestos()
        {
            List<OrdenPedidoRepuestos.entOrdenPedidoRepuestos> lista = new List<OrdenPedidoRepuestos.entOrdenPedidoRepuestos>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ordenespedidorepuestos", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            OrdenPedidoRepuestos.entOrdenPedidoRepuestos pedidoRepuesto = new OrdenPedidoRepuestos.entOrdenPedidoRepuestos
                            {
                                id = Convert.ToInt64(dr["id"]),
                                repuesto_id = Convert.ToInt64(dr["repuesto_id"]),
                                tecnico_id = Convert.ToInt64(dr["tecnico_id"]),
                                cantidad_solicitada = Convert.ToInt32(dr["cantidad_solicitada"]),
                                cantidad_entregada = dr["cantidad_entregada"] != DBNull.Value ? Convert.ToInt32(dr["cantidad_entregada"]) : (int?)null,
                                fecha = Convert.ToDateTime(dr["fecha"]),
                                fecha_entrega = dr["fecha_entrega"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_entrega"]) : (DateTime?)null,
                                estado = dr["estado"].ToString(),
                                observaciones = dr["observaciones"] != DBNull.Value ? dr["observaciones"].ToString() : null
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
