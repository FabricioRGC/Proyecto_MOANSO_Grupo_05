using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.Material;



namespace CapaDatos
{
    public class datMateriales
    {
       private static readonly datMateriales _instancia = new datMateriales();

       public static datMateriales Instancia
       {
          get { return datMateriales._instancia; }
       }
        // Metodo para listar los clientes
        public List<entMateriales> ListarMateriales()
        {

            SqlCommand cmd = null;
            List<entMateriales> lista = new List<entMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_Materiales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMateriales mat = new entMateriales();
                    mat.codigo = dr["codigo"].ToString();
                    mat.nombre = dr["nombre"].ToString();
                    mat.descripcion = dr["descripcion"].ToString();
                    mat.stock = int.Parse(dr["stock"].ToString());
                    mat.estado = dr["estado"].ToString();
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
        //Metodo para añadir un mateial
        public Boolean InsertarMateriales(entMateriales materiales)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_Materiales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", materiales.codigo);
                cmd.Parameters.AddWithValue("@nombre", materiales.nombre);
                cmd.Parameters.AddWithValue("@descripcion", materiales.descripcion);
                cmd.Parameters.AddWithValue("@stock", materiales.stock);
                cmd.Parameters.AddWithValue("@estado", materiales.estado);
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
        public Boolean EditarMateriales(entMateriales materiales)
        {
            SqlCommand cmd = null;
            Boolean edito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_Materiales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", materiales.codigo);
                cmd.Parameters.AddWithValue("@nombre", materiales.nombre);
                cmd.Parameters.AddWithValue("@descripcion", materiales.descripcion);
                cmd.Parameters.AddWithValue("@stock", materiales.stock);
                cmd.Parameters.AddWithValue("@estado", materiales.estado);
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

        // Metodo para inhabilitar un cliente
        public Boolean DeshabilitarMateriales(entMateriales mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_Materiales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", mat.codigo);

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
