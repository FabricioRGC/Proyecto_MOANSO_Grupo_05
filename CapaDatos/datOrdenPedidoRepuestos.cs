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
                    cmd.Parameters.Add("@repuesto_id", SqlDbType.BigInt).Value = pedido.RepuestoId; // Especifica el tipo
                    cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = pedido.Cantidad; // Especifica el tipo
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = pedido.Fecha; // Especifica el tipo
                    cmd.Parameters.Add("@estado", SqlDbType.NVarChar, 20).Value = pedido.Estado; // Especifica el tipo

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
                using (SqlCommand cmd = new SqlCommand("SP_ANULAR_PEDIDOS_REPUESTO", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idPedido);

                    cn.Open();
                    cmd.ExecuteNonQuery();
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
                            OrdenPedidoRepuestos.entOrdenPedidoRepuestos pedido = new OrdenPedidoRepuestos.entOrdenPedidoRepuestos
                            {
                                Id = Convert.ToInt64(dr["id"]),
                                RepuestoId = Convert.ToInt64(dr["repuesto_id"]),
                                Cantidad = Convert.ToInt32(dr["cantidad"]),
                                Fecha = Convert.ToDateTime(dr["fecha"]),
                                Estado = dr["estado"].ToString()
                            };
                            lista.Add(pedido);
                        }
                    }
                }
            }
            return lista;
        }
    
    }
}
