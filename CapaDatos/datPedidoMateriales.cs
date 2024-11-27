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
using static CapaEntidad.PedidoRepuestos;

namespace CapaDatos
{
    public class datPedidoMateriales
    {
        private static readonly datPedidoMateriales _instancia = new datPedidoMateriales();

        public static datPedidoMateriales Instancia
        {
            get { return _instancia; }
        }

        // Método para mostrar los pedidos de materiales
        public List<PedidoMateriales.entPedidoMateriales> ListarPedidoMateriales()
        {
            SqlCommand cmd = null;
            List<PedidoMateriales.entPedidoMateriales> lista = new List<PedidoMateriales.entPedidoMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_PEDIDO_MATERIALES", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedidoMateriales PedidoMateriales = new entPedidoMateriales();
                    PedidoMateriales.PedidoMaterialesID = Convert.ToInt32(dr["PedidoMaterialesID"]);
                    PedidoMateriales.Stock = Convert.ToInt32(dr["Stock"]);
                    PedidoMateriales.FechaRealizacion = Convert.ToDateTime(dr["FechaRealizacion"]);
                    PedidoMateriales.FechaEntrega = dr["FechaEntrega"] != DBNull.Value ? Convert.ToDateTime(dr["FechaEntrega"]) : (DateTime?)null;
                    PedidoMateriales.Estado = dr["Estado"].ToString();
                    PedidoMateriales.MaterialID = Convert.ToInt32(dr["MaterialID"]);
                    PedidoMateriales.PersonalID = Convert.ToInt32(dr["PersonalID"]);
                    lista.Add(PedidoMateriales);
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

        // Método para registrar un nuevo pedido de materiales
        public bool RegistrarPedidoMateriales(PedidoMateriales.entPedidoMateriales pedidoMateriales)
        {
            SqlCommand cmd = null;
            bool registrado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_REGISTRAR_PEDIDOS_MATERIALES", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir parámetros al StoredProcedure
                cmd.Parameters.AddWithValue("@Stock", pedidoMateriales.Stock);
                cmd.Parameters.AddWithValue("@MaterialID", pedidoMateriales.MaterialID);
                cmd.Parameters.AddWithValue("@PersonalID", pedidoMateriales.PersonalID);
                cmd.Parameters.AddWithValue("@Estado", pedidoMateriales.Estado);
                cmd.Parameters.AddWithValue("@FechaRealizacion", pedidoMateriales.FechaRealizacion);
                cmd.Parameters.AddWithValue("@FechaEntrega", pedidoMateriales.FechaEntrega.HasValue ? (object)pedidoMateriales.FechaEntrega.Value : DBNull.Value);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registrado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pedido de repuesto: " + ex.Message);
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


        // Método para terminar un pedido de materiales
        public void TerminarPedidoMateriales(int idPedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_ANULAR_PEDIDO_MATERIALES", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoMaterialesID", idPedido);

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