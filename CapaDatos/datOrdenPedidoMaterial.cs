using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Windows.Forms;
using static CapaEntidad.OrdenPedidoMaterial;

namespace CapaDatos
{
    public class datOrdenPedidoMaterial
    {
        private static readonly datOrdenPedidoMaterial _instancia = new datOrdenPedidoMaterial();

        public static datOrdenPedidoMaterial Instancia
        {
            get { return datOrdenPedidoMaterial._instancia; }
        }

        // Método para registrar un pedido de materiales
        public void RegistrarPedidoMaterial(entOrdenPedidoMateriales pedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PEDIDOS_MATERIALES", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir parámetros desde el objeto pedido
                    cmd.Parameters.Add("@material_id", SqlDbType.BigInt).Value = pedido.id; // Especifica el tipo
                    cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = pedido.cantidad; // Especifica el tipo
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = pedido.fecha; // Especifica el tipo
                    cmd.Parameters.Add("@estado", SqlDbType.NVarChar, 20).Value = pedido.estado; // Especifica el tipo

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Manejo de errores SQL
                        MessageBox.Show("Error al registrar el pedido: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de otros errores
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        // Método para anular un pedido de materiales
        public void AnularPedidoMaterial(long idPedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_ANULAR_PEDIDO_MATERIALES", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", idPedido);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para listar todos los pedidos de materiales
        public List<OrdenPedidoMaterial.entOrdenPedidoMateriales> ListarPedidosMateriales()
        {
            List<OrdenPedidoMaterial.entOrdenPedidoMateriales> lista = new List<OrdenPedidoMaterial.entOrdenPedidoMateriales>();

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ordenespedidomateriales", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            OrdenPedidoMaterial.entOrdenPedidoMateriales pedido = new OrdenPedidoMaterial.entOrdenPedidoMateriales
                            {
                                id = Convert.ToInt64(dr["id"]),
                                material_id = Convert.ToInt64(dr["material_id"]),
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                fecha = Convert.ToDateTime(dr["fecha"]),
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