using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.ProformaVenta;

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
                while (dr.Read()) {
                    entProformaVenta pro = new entProformaVenta();
                    pro.cliente_id = dr["cliente_id"].ToString();
                    pro.fecha_inicio = dr["fecha_inicio"].ToString();
                    pro.tipo_plan = dr["tipo_plan"].ToString();
                    pro.precio = dr["precio"].ToString();
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
    }
}
