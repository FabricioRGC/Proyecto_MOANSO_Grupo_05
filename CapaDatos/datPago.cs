using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.Pago;

namespace CapaDatos
{
    public class datPago
    {
        private static readonly datPago _instancia = new datPago();

        public static datPago Instancia
        {
            get { return datPago._instancia; }
        }

        // Método para listar pagos
        public List<entPago> ListarPago()
        {
            List<entPago> lista = new List<entPago>();
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_PAGOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPago pag = new entPago();
                    pag.cliente_id = dr["cliente_id"].ToString();
                    pag.contrato_id = dr["contrato_id"].ToString();
                    pag.fecha = dr["fecha"].ToString();
                    pag.monto = dr["monto"].ToString();
                    pag.metodo_pago = dr["metodo_pago"].ToString();
                    pag.estado = dr["estado"].ToString();
                    lista.Add(pag);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        // Método para añadir un pago
        public Boolean InsertarPago(entPago pago)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_PAGOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@contratoID", pago.contrato_id);
                cmd.Parameters.AddWithValue("monto", pago.monto);
                cmd.Parameters.AddWithValue("@metodoPago", pago.metodo_pago);
                cmd.Parameters.AddWithValue("@clienteId", pago.cliente_id);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserto = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserto;
        }

        // Método para anular un pago
        public Boolean AnularPago(entPago pago)
        {
            SqlCommand cmd = null;
            Boolean anulado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_PAGO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoContrato", pago.contrato_id);
                cmd.Parameters.AddWithValue("@codigoCliente", pago.cliente_id);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    anulado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return anulado;
        }
    }
}
