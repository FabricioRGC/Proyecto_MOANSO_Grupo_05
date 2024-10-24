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
            public List<entPersonal> listarPersonal()
            {
                SqlCommand cmd = null;
                List<entPersonal> lista = new List<entPersonal>();
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("SP_MOSTRAR_PERSONALTECNICO", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        entPersonal cli = new entPersonal();
                        cli.nombre = dr["nombre"].ToString();
                        cli.disponibilidad = dr["disponibilidad"].ToString();
                        lista.Add(cli);

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
                    cmd.Parameters.AddWithValue("@disponibilidad", personal.disponibilidad);

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


            // Metodo para inhabilitar un cliente
            public Boolean DeshabilitaPersonal(entPersonal personal)
            {
                SqlCommand cmd = null;
                Boolean deshabilito = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("SP_DESHABILITAR_PERSONAL", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", personal.nombre);

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

