using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.datPersonal;
using CapaEntidad;
using static CapaEntidad.Personal;
using static CapaEntidad.Cliente;
namespace CapaDatos
{

    public class datPersonal
    {
        public static readonly datPersonal _instancia = new datPersonal();

        public static datPersonal Instancia
        {
            get { return datPersonal._instancia; }
        }

        // Método para listar el personal técnico
        public List<entPersonal> listarPersonal()
        {
            SqlCommand cmd = null;
            List<entPersonal> lista = new List<entPersonal>();
            SqlConnection cn = null;

            try
            {
                cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_PERSONALTECNICO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entPersonal personal = new entPersonal
                    {
                        PersonalID = Convert.ToInt32(dr["PersonalID"]),
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        DNI = Convert.ToInt32(dr["DNI"]),
                        Teléfono = Convert.ToInt32(dr["Télefono"]),
                        Estado = dr["Estado"].ToString(),
                        Cargo = dr["Cargo"].ToString(),
                        AreaTrabajo = dr["AreaTrabajo"].ToString()
                    };
                    lista.Add(personal);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return lista;
        }


        // Método para insertar personal técnico
        public Boolean InsertarPersonal(entPersonal personal)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_PERSONAL", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", personal.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", personal.Apellido);
                cmd.Parameters.AddWithValue("@DNI", personal.DNI);
                cmd.Parameters.AddWithValue("@Teléfono", personal.Teléfono);
                cmd.Parameters.AddWithValue("@Estado", personal.Estado);
                cmd.Parameters.AddWithValue("@Cargo", personal.Cargo);
                cmd.Parameters.AddWithValue("@AreaTrabajo", personal.AreaTrabajo);

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
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserto;
        }


        // Método para deshabilitar personal técnico
        public Boolean DeshabilitaPersonal(entPersonal personal)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_PERSONAL", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNI", personal.DNI);

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
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return deshabilito;
        }
        public Boolean EDITARPersonal(entPersonal personal)
        {
            SqlCommand cmd = null;
            Boolean edito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_Personal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", personal.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", personal.Apellido);
                cmd.Parameters.AddWithValue("@DNI", personal.DNI);
                cmd.Parameters.AddWithValue("@Teléfono", personal.Teléfono);
                cmd.Parameters.AddWithValue("@Cargo", personal.Cargo);
                cmd.Parameters.AddWithValue("@AreaTrabajo", personal.AreaTrabajo);

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
    }
}



