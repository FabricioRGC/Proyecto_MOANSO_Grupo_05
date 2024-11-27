using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Windows.Forms;
using static CapaEntidad.PedidoMateriales;

namespace CapaDatos
{
    public class datPedidoMateriales
    {
        private static readonly datPedidoMateriales _instancia = new datPedidoMateriales();

        public static datPedidoMateriales Instancia
        {
            get { return _instancia; }
        }

        // Método para registrar un pedido de materiales
        public void RegistrarPedidoMaterial(entPedidoMateriales pedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PEDIDO_MATERIALES", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nombreMaterial", SqlDbType.NVarChar, 30).Value = pedido.nombreMaterial;
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
                        MessageBox.Show("Error al registrar el pedido de material: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        // Método para terminar un pedido de materiales
        public void TerminarPedidoMaterial(long idPedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_TERMINAR_PEDIDO_MATERIALES", cn))
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


        // Método para listar todos los pedidos de materiales
        public List<PedidoMateriales.entPedidoMateriales> ListarPedidosMateriales()
        {
            List<PedidoMateriales.entPedidoMateriales> lista = new List<PedidoMateriales.entPedidoMateriales>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ordenespedidomateriales", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            PedidoMateriales.entPedidoMateriales pedido = new PedidoMateriales.entPedidoMateriales
                            {
                                id = Convert.ToInt64(dr["id"]),
                                nombreMaterial = dr["nombreMaterial"].ToString(),
                                nombreTecnico = dr["nombreTecnico"].ToString(),
                                fecha = Convert.ToDateTime(dr["fecha"]),
                                fecha_entrega = dr["fecha_entrega"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_entrega"]) : (DateTime?)null,
                                estado = dr["estado"].ToString()
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