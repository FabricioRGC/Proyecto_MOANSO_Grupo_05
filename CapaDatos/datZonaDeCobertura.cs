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

        // Metodo para listar los clientes
       // public List<entZonas> ListarZona()
        //{
            /*
            SqlCommand cmd = null;
            List<entZonas> lista = new List<entZonas>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                //cambiar el sp
                cmd = new SqlCommand("SP_MOSTRAR_Materiales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMateriales zon = new entMateriales();
                    zon.Distrito = dr["Distrito"].ToString();
                    zon.VelocidadDeCobertura = dr["VelocidadDeCobertura"].ToString();
                    zon.TipoZona = dr["TipoZona"].ToString();
                    zon.CodigoPostal = int.Parse(dr["CodigoPostal"].ToString());
                    zon.Tipo = dr["Tipo "].ToString();
                    // mat.fechaInicio = Convert.ToDateTime(dr["fecha_Registro"]);
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

            */
        //}

    }
}
