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
                    mat.codigo = dr["CodigoMaterial"].ToString();
                    mat.nombre = dr["NombreMaterial"].ToString();
                    mat.descripcion = dr["Descripción"].ToString();
                    mat.stock = int.Parse(dr["Stock"].ToString());
                    mat.estado = dr["Estado"].ToString();
                    // mat.fechaInicio = Convert.ToDateTime(dr["fecha_Registro"]);
                    mat.Categoria = dr["CategoriaMaterialID"].ToString(); //int.Parse(dr["CategoriaMaterialID"].ToString());
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
                cmd.Parameters.AddWithValue("@codigomat", materiales.codigo);
                cmd.Parameters.AddWithValue("@nombremat", materiales.nombre);
                cmd.Parameters.AddWithValue("@stock", materiales.stock);
                cmd.Parameters.AddWithValue("@estado", materiales.estado);
                cmd.Parameters.AddWithValue("@descripcion", materiales.descripcion);
                cmd.Parameters.AddWithValue("@categoriaID", materiales.Categoria);
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
                cmd.Parameters.AddWithValue("@codigomat", materiales.codigo);
                cmd.Parameters.AddWithValue("@nombremat", materiales.nombre);
                cmd.Parameters.AddWithValue("@stock", materiales.stock);
                cmd.Parameters.AddWithValue("@categoriaID", materiales.Categoria);


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

        // Metodo para inhabilitar un material
        public Boolean DeshabilitarMateriales(entMateriales mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_Materiales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigomat", mat.codigo);

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
