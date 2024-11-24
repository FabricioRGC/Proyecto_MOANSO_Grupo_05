using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Planes;

namespace CapaDatos
{
    public class datPlanes
    {
        private static readonly datPlanes _instancia = new datPlanes();

        public static datPlanes Instancia
        {
            get { return datPlanes._instancia; }
        }
        // Metodo para listar los planes
        public List<entPlanes> ListarPlanes()
        {

            SqlCommand cmd = null;
            List<entPlanes> lista = new List<entPlanes>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_Planes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlanes plan = new entPlanes();
                    plan.PlanNombre = dr["NombrePlanServicio"].ToString();
                    plan.VelocidadMbps = dr["VelocidadMbps"].ToString();
                    plan.PrecioMensual = Convert.ToInt32(dr["Precio"]);
                    plan.TipoServicio = dr["TipoServicio"].ToString();
                    plan.Caracteristicas = dr["Caracteristicas"].ToString();
                    plan.estado = dr["estado"].ToString();
                    plan.Zona_de_cobertura_id = Convert.ToInt32(dr["ZonaDeCoberturaID"]);


                    lista.Add(plan);
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
        //Metodo para añadir un planes
        public Boolean InsertarPlanes(entPlanes planes)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_Planes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@planNombre", planes.PlanNombre);
                cmd.Parameters.AddWithValue("@velocidadMbps", planes.VelocidadMbps);
                cmd.Parameters.AddWithValue("@precioMen", planes.PrecioMensual);
                cmd.Parameters.AddWithValue("@tipoSer", planes.TipoServicio);
                cmd.Parameters.AddWithValue("@caracteristicas", planes.Caracteristicas);
                cmd.Parameters.AddWithValue("@estado", planes.estado);
                cmd.Parameters.AddWithValue("@zona_de_covertura", planes.Zona_de_cobertura_id);
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
        // Metodo para editar un cliente
        public Boolean EditarPlanes(entPlanes planes)
        {
            SqlCommand cmd = null;
            Boolean edito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_Planes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@planNombre", planes.PlanNombre);
                cmd.Parameters.AddWithValue("@velocidadMbps", planes.VelocidadMbps);
                cmd.Parameters.AddWithValue("@precioMen", planes.PrecioMensual);
                cmd.Parameters.AddWithValue("@tipoSer", planes.TipoServicio);
                cmd.Parameters.AddWithValue("@caracteristicas", planes.Caracteristicas);
                cmd.Parameters.AddWithValue("@estado", planes.estado);
                cmd.Parameters.AddWithValue("@zona_de_covertura", planes.Zona_de_cobertura_id);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edito = true;
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
            return edito;
        }
        // Metodo para inhabilitar un planes
        public Boolean DeshabilitarPlanes(entPlanes pla)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_Planes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", pla.PlanNombre);

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
