using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class datPlanificacionMantenimiento
    {
        // Singleton para la instancia de datPlanificacionMantenimiento
        public static readonly datPlanificacionMantenimiento _instancia = new datPlanificacionMantenimiento();

        public static datPlanificacionMantenimiento Instancia
        {
            get { return _instancia; }
        }

        public List<entPlanificacionMantenimiento> ListarPlanificaciones()
        {
            SqlCommand cmd = null;
            List<entPlanificacionMantenimiento> lista = new List<entPlanificacionMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_LISTAR_PLANIFICACIONES", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlanificacionMantenimiento planificacion = new entPlanificacionMantenimiento();
                    planificacion.Id = Convert.ToInt32(dr["id"]);
                    planificacion.Tipo = dr["tipo"].ToString();
                    planificacion.Fecha = Convert.ToDateTime(dr["fecha"]);
                    planificacion.Recursos_Asignados = dr["recursos_asignados"].ToString();
                    planificacion.Estado = dr["estado"].ToString();
                    planificacion.NombrePersonal = dr["NombrePersonal"].ToString();
                    lista.Add(planificacion);
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

        // Método para insertar una nueva planificación de mantenimiento
        public Boolean InsertarPlanificacion(entPlanificacionMantenimiento planificacion)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INSERTAR_PLANIFICACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros con sus valores, utilizando las propiedades correctas
                cmd.Parameters.AddWithValue("@Fecha", planificacion.Fecha);
                cmd.Parameters.AddWithValue("@Tipo", planificacion.Tipo);
                cmd.Parameters.AddWithValue("@Recursos_Asignados", planificacion.Recursos_Asignados);
                cmd.Parameters.AddWithValue("@Estado", "planificado"); // Estado por defecto al añadir
                cmd.Parameters.AddWithValue("@NombrePersonal", planificacion.NombrePersonal);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserto = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al añadir la planificación: " + ex.Message);
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
        // Método para deshabilitar una planificación de mantenimiento (cambia el estado a inactivo)
        public Boolean DeshabilitarPlanificacion(int idPlanificacion)
        {
            SqlCommand cmd = null;
            bool inhabilitado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_INHABILITAR_PLANIFICACION", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", idPlanificacion); // Cambiado a idPlanificacion

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilitado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al inhabilitar la planificación: " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inhabilitado;
        }
    }
}
