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
                    entPersonal personal = new entPersonal();
                    personal.nombre = dr["nombre"].ToString();
                    personal.apellidos = dr["apellidos"].ToString();
                    personal.dni = dr["dni"].ToString();
                    personal.telefono = dr["telefono"].ToString();
                    personal.disponibilidad = dr["disponibilidad"].ToString();
                    personal.tipo_encargado = dr["tipo_encargado"].ToString(); 
                    personal.area_trabajo = dr["area_trabajo"].ToString();
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
                cmd.Parameters.AddWithValue("@nombre", personal.nombre);
                cmd.Parameters.AddWithValue("@apellidos", personal.apellidos);
                cmd.Parameters.AddWithValue("@dni", personal.dni);
                cmd.Parameters.AddWithValue("@telefono", personal.telefono);
                cmd.Parameters.AddWithValue("@disponibilidad", personal.disponibilidad);
                cmd.Parameters.AddWithValue("@tipo_encargado", personal.tipo_encargado);
                cmd.Parameters.AddWithValue("@area_trabajo", personal.area_trabajo);

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
                cmd.Parameters.AddWithValue("@dni", personal.dni);

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
    }
}



