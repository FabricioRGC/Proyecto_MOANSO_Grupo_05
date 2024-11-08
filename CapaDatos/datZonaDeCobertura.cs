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
                    zon.VelocidadDeCobertura = dr["VelocidadDeCobertura"].ToString();
                    zon.TipoZona = dr["TipoZona"].ToString();
                    zon.CodigoPostal = int.Parse(dr["CodigoPostal"].ToString());
                    zon.Tipo = dr["Tipo"].ToString();
                    zon.Estado = dr["Estado"].ToString();
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
                cmd.Parameters.AddWithValue("@Distrito", zonas.Distrito);
                cmd.Parameters.AddWithValue("@VelocidadDeCobertura", zonas.VelocidadDeCobertura);
                cmd.Parameters.AddWithValue("@TipoZona", zonas.TipoZona);
                cmd.Parameters.AddWithValue("@CodigoPostal", zonas.CodigoPostal);
                cmd.Parameters.AddWithValue("@Tipo", zonas.Tipo);
                cmd.Parameters.AddWithValue("@Estado", zonas.Estado);
                // cmd.Parameters.AddWithValue("@fechaRegistro", materiales.fechaInicio);
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
                cmd.Parameters.AddWithValue("@VelocidadDeCobertura", zonas.VelocidadDeCobertura);
                cmd.Parameters.AddWithValue("@TipoZona", zonas.TipoZona);
                cmd.Parameters.AddWithValue("@CodigoPostal", zonas.CodigoPostal);
                cmd.Parameters.AddWithValue("@Tipo", zonas.Tipo);

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
                cmd.Parameters.AddWithValue("@CodigoPostal", zon.CodigoPostal);

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
