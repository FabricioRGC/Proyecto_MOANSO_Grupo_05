using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using static CapaEntidad.Repuesto;
using static CapaEntidad.PedidoRepuestos;

namespace CapaDatos
{
    public class datPedidoRepuestos
    {
        private static readonly datPedidoRepuestos _instancia = new datPedidoRepuestos();

        public static datPedidoRepuestos Instancia
        {
            get { return datPedidoRepuestos._instancia; }
        }


        // Método para mostrar los pedidos de repuesto
        public List<PedidoRepuestos.entPedidoRepuestos> ListarPedidoRepuestos()
        {
            SqlCommand cmd = null;
            List<PedidoRepuestos.entPedidoRepuestos> lista = new List<PedidoRepuestos.entPedidoRepuestos>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_PEDIDO_REPUESTOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedidoRepuestos PedidoRepuesto = new entPedidoRepuestos();
                    PedidoRepuesto.PedidoDeRepuestosID = Convert.ToInt32(dr["PedidoDeRepuestosID"]);
                    PedidoRepuesto.Stock = Convert.ToInt32(dr["Stock"]);
                    PedidoRepuesto.FechaRealizacion = Convert.ToDateTime(dr["FechaRealizacion"]);
                    PedidoRepuesto.FechaEntrega = dr["FechaEntrega"] != DBNull.Value ? Convert.ToDateTime(dr["FechaEntrega"]) : (DateTime?)null;
                    PedidoRepuesto.Estado = dr["Estado"].ToString();
                    PedidoRepuesto.RepuestosID = Convert.ToInt32(dr["RepuestosID"]);
                    PedidoRepuesto.PersonalID = Convert.ToInt32(dr["PersonalID"]);
                    lista.Add(PedidoRepuesto);
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

        // Método para registrar un nuevo pedido de repuesto
        public bool RegistrarPedidoRepuesto(PedidoRepuestos.entPedidoRepuestos pedidoRepuesto)
        {
            SqlCommand cmd = null;
            bool registrado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_REGISTRAR_PEDIDOS_REPUESTOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir parámetros al StoredProcedure
                cmd.Parameters.AddWithValue("@Stock", pedidoRepuesto.Stock);
                cmd.Parameters.AddWithValue("@RepuestosID", pedidoRepuesto.RepuestosID);
                cmd.Parameters.AddWithValue("@PersonalID", pedidoRepuesto.PersonalID);
                cmd.Parameters.AddWithValue("@Estado", pedidoRepuesto.Estado);
                cmd.Parameters.AddWithValue("@FechaRealizacion", pedidoRepuesto.FechaRealizacion);
                cmd.Parameters.AddWithValue("@FechaEntrega", pedidoRepuesto.FechaEntrega.HasValue ? (object)pedidoRepuesto.FechaEntrega.Value : DBNull.Value);

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


        // Método para terminar un pedido de repuesto
        public void TerminarPedidoRepuesto(int idPedido)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand("SP_ANULAR_PEDIDO_REPUESTOS", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PedidoDeRepuestosID", idPedido);

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
