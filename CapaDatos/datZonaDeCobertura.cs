using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.ZonaDeCobertura;
using static CapaEntidad.Material;

namespace CapaDatos
{
    public class datZonaDeCobertura
    {
        private static readonly datZonaDeCobertura _instancia = new datZonaDeCobertura();

        public static datZonaDeCobertura Instancia
        {
            get { return datZonaDeCobertura._instancia; }
        }

        // Metodo para listar los Zonas
        public List<entZonas> ListarZona()
        {

            SqlCommand cmd = null;
            List<entZonas> lista = new List<entZonas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("SP_MOSTRAR_Zona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entZonas zon = new entZonas();
                    zon.Distrito = dr["Distrito"].ToString();
                    zon.Estado_zona = dr["Estado_zona"].ToString();
                    zon.TipoConexion = dr["TipoConexión"].ToString();
                    zon.TipoServicio = dr["TipoServicio"].ToString();
                    lista.Add(zon);
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
        //Metodo para añadir un Zona
        public Boolean InsertarZona(entZonas zonas)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_Zona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombredistrito", zonas.Distrito);
                cmd.Parameters.AddWithValue("@estadozon", zonas.Estado_zona);
                cmd.Parameters.AddWithValue("@tipconexion", zonas.TipoConexion);
                cmd.Parameters.AddWithValue("@tipservicio", zonas.TipoServicio);


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

        // Metodo para editar una Zona
        public Boolean EditarZona(entZonas zonas)
        {
            SqlCommand cmd = null;
            Boolean edito = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_EDITAR_Zona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombredistrito", zonas.Distrito);
                cmd.Parameters.AddWithValue("@tipconexion", zonas.TipoConexion);
                cmd.Parameters.AddWithValue("@tipservicio", zonas.TipoServicio);

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
        public Boolean DeshabilitarZona(entZonas zon)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_Zona", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombredistrito", zon.Distrito);

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
