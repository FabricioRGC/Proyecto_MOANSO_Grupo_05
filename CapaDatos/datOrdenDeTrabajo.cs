using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.OrdenDeTrabajo;


namespace CapaDatos
{
    public class datOrdenDeTrabajo
    {


        private static readonly datOrdenDeTrabajo _instancia = new datOrdenDeTrabajo();

        public static datOrdenDeTrabajo Instancia
        {
            get { return datOrdenDeTrabajo._instancia; }
        }

        // Metodo para listar los OrdenDeTrabajo
        public List<entOrdenDeTrabajo> ListarOrdenDeTrabajo()
        {

            SqlCommand cmd = null;
            List<entOrdenDeTrabajo> lista = new List<entOrdenDeTrabajo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_OrdenDeTrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOrdenDeTrabajo mat = new entOrdenDeTrabajo();
                    mat.OrdenDeTrabajoID = int.Parse(dr["OrdenDeTrabajoID"].ToString());
                    mat.MantenimientoPreventivoID = int.Parse(dr["MantenimientoPreventivoID"].ToString());
                    mat.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    mat.PersonalID = int.Parse(dr["PersonalID"].ToString());
                    mat.FechaEjecución = Convert.ToDateTime(dr["FechaEjecución"]);
                    mat.Tipo = dr["Tipo"].ToString();
                    mat.Estado = dr["Estado"].ToString();
                    mat.ClienteID = int.Parse(dr["ClienteID"].ToString());
                    mat.PedidoDeInstalacionID = int.Parse(dr["PedidoDeInstalaciónID"].ToString());
                    lista.Add(mat);
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
        //Metodo para añadir un OrdenDeTrabajo
        public Boolean InsertarOrdenDeTrabajo(entOrdenDeTrabajo ordenDeTrabajo)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_OrdenDeTrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MantenimientoPreventivoID", ordenDeTrabajo.MantenimientoPreventivoID);
                cmd.Parameters.AddWithValue("@FechaRegistro", ordenDeTrabajo.FechaRegistro);
                cmd.Parameters.AddWithValue("@PersonalID", ordenDeTrabajo.PersonalID);
                cmd.Parameters.AddWithValue("@FechaEjecucion", ordenDeTrabajo.FechaEjecución);
                cmd.Parameters.AddWithValue("@Tipo", ordenDeTrabajo.Tipo);
                cmd.Parameters.AddWithValue("@Estado", ordenDeTrabajo.Estado);
                cmd.Parameters.AddWithValue("@ClienteID", ordenDeTrabajo.ClienteID);
                cmd.Parameters.AddWithValue("@PedidoDeInstalacionID", ordenDeTrabajo.PedidoDeInstalacionID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserto = true;
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
            return inserto;


        }

        // Metodo para inhabilitar un OrdenDeTrabajo


        public Boolean TerminarOrdenDeTrabajo(entOrdenDeTrabajo mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_OrdenDeTrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDOrdenTrabajo", mat.OrdenDeTrabajoID);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilito = true;
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
            return deshabilito;
        }

    }
}
