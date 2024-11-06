using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.ProformaVenta;
using System.Drawing;

namespace CapaDatos
{
    public class datProforma
    {
        private static readonly datProforma _instancia = new datProforma();

        public static datProforma Instancia
        {
            get { return datProforma._instancia; }
        }

        // Método para listar proformas
        public List<entProformaVenta> ListarProforma()
        {

            SqlCommand cmd = null;
            List<entProformaVenta> lista = new List<entProformaVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_PROFORMA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProformaVenta pro = new entProformaVenta();
                    pro.cliente_id = dr["cliente_id"].ToString();
                    pro.fecha_inicio = Convert.ToDateTime(dr["fecha_inicio"]);
                    pro.precio = Convert.ToInt32(dr["precio"]);
                    pro.tipo_plan = dr["tipo_plan"].ToString();
                    pro.estado = dr["estado"].ToString();
                    lista.Add(pro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        // Método para añadir una proforma
        public Boolean InsertarProforma(entProformaVenta proforma)
        {
            SqlCommand cmd = null;
            Boolean insertar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_PROFORMA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@clienteId", proforma.cliente_id);
                cmd.Parameters.AddWithValue("@tipoPlan", proforma.tipo_plan);
                cmd.Parameters.AddWithValue("@precio", proforma.precio);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    insertar = true;
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
            return insertar;
        }

        // Método para inhabilitar una proforma
        public Boolean InhabilitarProforma(entProformaVenta proforma)
        {
            SqlCommand cmd = null;
            Boolean inhabilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_PROFORMAS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoCliente", proforma.cliente_id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilitar = true;
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
            return inhabilitar;
        }
    }
}
