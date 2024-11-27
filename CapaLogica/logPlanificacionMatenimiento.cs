using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using CapaEntidad;
using static CapaEntidad.entPlanificacionMantenimiento;

public class logPlanificacionMantenimiento
    {
        // Singleton para garantizar una única instancia de logPlanificacionMantenimiento
        private static readonly logPlanificacionMantenimiento _instancia = new logPlanificacionMantenimiento();

        public static logPlanificacionMantenimiento Instancia
        {
            get { return _instancia; }
        }

        // Método para listar todas las planificaciones de mantenimiento
        public List<entPlanificacionMantenimiento> ListarPlanificaciones()
        {
            return datPlanificacionMantenimiento.Instancia.ListarPlanificaciones();
        }

        // Método para añadir una nueva planificación de mantenimiento
        public void InsertarPlanificacion(entPlanificacionMantenimiento planificacion)
        {
            datPlanificacionMantenimiento.Instancia.InsertarPlanificacion(planificacion);
        }

        // Método para deshabilitar una planificación de mantenimiento
        public void DeshabilitarPlanificacion(entPlanificacionMantenimiento las)
        {
            datPlanificacionMantenimiento.Instancia.DeshabilitarPlanificacion(las.Id);
        }
    }
