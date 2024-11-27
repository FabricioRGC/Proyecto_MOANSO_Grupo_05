using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using static CapaEntidad.entPlanificacionMantenimiento;

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
                cmd = new SqlCommand("SP_MOSTRAR_PLANIFICACION_MANTENIMIENTO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPlanificacionMantenimiento planificacion = new entPlanificacionMantenimiento();
                    planificacion.Id = Convert.ToInt32(dr["P_MantenimientoPreventivoID"]);
                    planificacion.FechaProgramacion = Convert.ToDateTime(dr["FechaProgramación"]);
                    planificacion.Estado = dr["Estado"].ToString();
                    planificacion.ContratoID = Convert.ToInt32(dr["ContratoID"]);
                    planificacion.RepuestosID = Convert.ToInt32(dr["RepuestosID"]);
                    planificacion.Frecuencia = Convert.ToInt32(dr["Frecuencia"]);
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
                cmd = new SqlCommand("SP_AÑADIR_PLANIFICACION_MANTENIMIENTO", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Añadir los parámetros con sus valores, utilizando las propiedades correctas
                cmd.Parameters.AddWithValue("@FechaProgramacion", planificacion.FechaProgramacion);
                cmd.Parameters.AddWithValue("@Estado", "planificado"); // Estado por defecto al añadir
                cmd.Parameters.AddWithValue("@ContratoID", planificacion.ContratoID);
                cmd.Parameters.AddWithValue("@RepuestosID", planificacion.RepuestosID);
                cmd.Parameters.AddWithValue("@Frecuencia", planificacion.Frecuencia);

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
                cmd = new SqlCommand("SP_DESHABILITAR_PLANIFICACION_MANTENIMIENTO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_MantenimientoPreventivoID", idPlanificacion); // Cambiado a idPlanificacion

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


