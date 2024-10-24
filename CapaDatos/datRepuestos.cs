using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Repuesto;

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
                    Repuesto.entRepuesto repuesto = new Repuesto.entRepuesto
                    {
                        id = long.Parse(dr["id"].ToString()),
                        codigo = dr["codigo"].ToString(),
                        nombre = dr["nombre"].ToString(),
                        descripcion = dr["descripcion"].ToString(),
                        stock = int.Parse(dr["stock"].ToString()),
                    };
                    lista.Add(repuesto);
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
                cmd.Parameters.AddWithValue("@codigo", repuesto.codigo);
                cmd.Parameters.AddWithValue("@nombre", repuesto.nombre);
                cmd.Parameters.AddWithValue("@descripcion", repuesto.descripcion);
                cmd.Parameters.AddWithValue("@stock", repuesto.stock);
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

        // Método para editar un repuesto
        public bool EditarRepuesto(Repuesto.entRepuesto repuesto)
        {
            SqlCommand cmd = null;
            bool edito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MODIFICAR_Repuesto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", repuesto.id);
                cmd.Parameters.AddWithValue("@codigo", repuesto.codigo);
                cmd.Parameters.AddWithValue("@nombre", repuesto.nombre);
                cmd.Parameters.AddWithValue("@descripcion", repuesto.descripcion);
                cmd.Parameters.AddWithValue("@stock", repuesto.stock);
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
                if (cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return edito;
        }


        // Método para inhabilitar un repuesto
        public void DeshabilitarRepuestos(entRepuesto repuesto)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarRepuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRepuesto", repuesto.id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inhabilitar el repuesto: " + ex.Message);
            }
            finally
            {
                cmd?.Connection.Close();
            }
        }

    }
}
