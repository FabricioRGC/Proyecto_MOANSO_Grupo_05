using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using static CapaEntidad.NotaDeSalida;

namespace CapaDatos
{
    public class datNotaDeSalida
    {
        public static readonly datNotaDeSalida _instancia = new datNotaDeSalida();

        public static datNotaDeSalida Instancia
        {
            get { return datNotaDeSalida._instancia; }
        }
        public List<entNotadesalida> ListarNotadeSalida()
        {

            SqlCommand cmd = null;
            List<entNotadesalida> lista = new List<entNotadesalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_NOTADESALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNotadesalida mat = new entNotadesalida();
                    mat.NotadeSalidaID = int.Parse(dr["NotaDeSalidaID"].ToString());
                    mat.FechadeEmision = Convert.ToDateTime(dr["FechaEmisión"]);
                    mat.Estado = dr["Estado"].ToString();

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
        public Boolean InsertarNotaSalidaMateriales(entNotadesalida nota)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_REGISTRAR_NOTADESALIDAMATERIALES", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechadeEmision", nota.FechadeEmision);
                cmd.Parameters.AddWithValue("@PedidiMaterialesID", nota.PedidiMaterialesID);
                cmd.Parameters.AddWithValue("@Estado", nota.Estado);
                cmd.Parameters.AddWithValue("@MaterialID", nota.MaterialID);
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

        public Boolean InsertarNotaSalidaRepuestos(entNotadesalida nota)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_REGISTRAR_NOTADESALIDAREPUESTOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechadeEmision", nota.FechadeEmision);
                cmd.Parameters.AddWithValue("@PedidiRepuestosID", nota.PedidiRepuestosID);
                cmd.Parameters.AddWithValue("@Estado", nota.Estado);
                cmd.Parameters.AddWithValue("@RepuestosID", nota.RepuestoID);
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


        // Metodo para inhabilitar
        public Boolean DeshabilitarNotadeSalida(entNotadesalida mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_NOTADESALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NotadeSalidaID", mat.NotadeSalidaID);

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

        public Boolean ReducirStockRepuestos(entNotadesalida mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("reducir_stock_Repuestos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pedidorepuestos", mat.PedidiRepuestosID);

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

        public Boolean ReducirStockMateriales(entNotadesalida mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("reducir_stock_Materiales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_pedidomateriales", mat.PedidiMaterialesID);

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
