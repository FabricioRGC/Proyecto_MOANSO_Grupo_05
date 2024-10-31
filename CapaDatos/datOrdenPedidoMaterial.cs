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
            get { return _instancia; }
        }

        // Método para registrar un pedido de materiales
        public void RegistrarPedidoMaterial(entOrdenPedidoMateriales pedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_REGISTRAR_PEDIDO_MATERIALES", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Añadir parámetros desde el objeto pedido
                    cmd.Parameters.Add("@material_id", SqlDbType.BigInt).Value = pedido.material_id; // ID del material
                    cmd.Parameters.Add("@cliente_id", SqlDbType.BigInt).Value = pedido.cliente_id; // ID del cliente
                    cmd.Parameters.Add("@cantidad_solicitada", SqlDbType.Int).Value = pedido.cantidad_solicitada; // Cantidad solicitada
                    cmd.Parameters.Add("@cantidad_entregada", SqlDbType.Int).Value = pedido.cantidad_entregada; // Cantidad entregada
                    cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = pedido.fecha; // Fecha de realización
                    cmd.Parameters.Add("@fecha_entrega", SqlDbType.Date).Value = pedido.fecha_entrega; // Fecha de entrega
                    cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar).Value = pedido.observaciones ?? (object)DBNull.Value; // Observaciones (puede ser null)

                    // El estado se establece como "Activado" en el procedimiento almacenado
                    // No es necesario añadirlo aquí ya que lo maneja el SP.

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
                    cmd.Parameters.AddWithValue("@id", idPedido); // Aquí se pasa el id del pedido que se va a anular

                    try
                    {
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Manejo de errores SQL
                        MessageBox.Show("Error al anular el pedido: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Manejo de otros errores
                        MessageBox.Show("Error: " + ex.Message);
                    }
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
                                cliente_id = Convert.ToInt64(dr["cliente_id"]), // Agregado para cliente_id
                                cantidad_solicitada = Convert.ToInt32(dr["cantidad_solicitada"]), // Cambiado a cantidad_solicitada
                                cantidad_entregada = dr["cantidad_entregada"] != DBNull.Value ? Convert.ToInt32(dr["cantidad_entregada"]) : (int?)null, // Manejo de valores nulos
                                fecha = Convert.ToDateTime(dr["fecha"]),
                                fecha_entrega = dr["fecha_entrega"] != DBNull.Value ? Convert.ToDateTime(dr["fecha_entrega"]) : (DateTime?)null, // Manejo de valores nulos
                                estado = dr["estado"].ToString(), // El estado se recupera directamente
                                observaciones = dr["observaciones"] != DBNull.Value ? dr["observaciones"].ToString() : null // Manejo de valores nulos
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