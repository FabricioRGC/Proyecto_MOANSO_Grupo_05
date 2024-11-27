using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Repuesto;
using static CapaEntidad.Material;

namespace CapaDatos
{
    public class datRepuestos
    {
        private static readonly datRepuestos _instancia = new datRepuestos();

        public static datRepuestos Instancia
        {
            get { return datRepuestos._instancia; }
        }

        // Método para listar los repuestos
        public List<Repuesto.entRepuesto> ListarRepuestos()
        {
            SqlCommand cmd = null;
            List<Repuesto.entRepuesto> lista = new List<Repuesto.entRepuesto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_Repuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRepuesto repuesto = new entRepuesto();
                    repuesto.CódigoRepuesto = dr["CódigoRepuesto"].ToString();
                    repuesto.NombreRepuesto = dr["NombreRepuesto"].ToString();
                    repuesto.Descripcion = dr["Descripción"].ToString();
                    repuesto.Stock = int.Parse(dr["Stock"].ToString());
                    repuesto.Estado = dr["Estado"].ToString();
                    repuesto.CategoriaRepuestoID = dr["CategoriaRepuestoID"].ToString();
                    lista.Add(repuesto);
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


        // Método para añadir un repuesto
        public Boolean InsertarRepuesto(Repuesto.entRepuesto repuesto)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_Repuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoRepuesto", repuesto.CódigoRepuesto);
                cmd.Parameters.AddWithValue("@NombreRepuesto", repuesto.NombreRepuesto);
                cmd.Parameters.AddWithValue("@Descripcion", repuesto.Descripcion);
                cmd.Parameters.AddWithValue("@Estado", repuesto.Estado);
                cmd.Parameters.AddWithValue("@Stock", repuesto.Stock);
                cmd.Parameters.AddWithValue("@CategoriaRepuestoID", repuesto.CategoriaRepuestoID);

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

        // Metodo para editar un repuesto
        public Boolean EditarRepuestos(entRepuesto repuesto)
        {
            SqlCommand cmd = null;
            Boolean edito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_Repuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CódigoRepuesto", repuesto.CódigoRepuesto);
                cmd.Parameters.AddWithValue("@NombreRepuesto", repuesto.NombreRepuesto);
                cmd.Parameters.AddWithValue("@Stock", repuesto.Stock);
                cmd.Parameters.AddWithValue("@Descripción", repuesto.Descripcion);
                cmd.Parameters.AddWithValue("@CategoriaRepuestoID", repuesto.CategoriaRepuestoID);


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

        // Método para inhabilitar un repuesto
        public Boolean DeshabilitarRepuestos(entRepuesto repuesto)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_Repuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CódigoRepuesto", repuesto.CódigoRepuesto);

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
