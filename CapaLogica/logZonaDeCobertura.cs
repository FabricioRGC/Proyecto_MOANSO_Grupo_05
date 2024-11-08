using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.ZonaDeCobertura;

namespace CapaLogica
{
    public class logZonaDeCobertura
    {
        private static readonly logZonaDeCobertura _instancia = new logZonaDeCobertura();

        public static logZonaDeCobertura Instancia
        {
            get { return logZonaDeCobertura._instancia; }
        }


        // Metodo para listar los zonas
        public List<entZonas> ListarZona()
        {
            return datZonaDeCobertura.Instancia.ListarZona();
        }
        // Metodo para añadir un materiales
        public void InsertarZona(entZonas zon)
        {
            datZonaDeCobertura.Instancia.InsertarZona(zon);
        }
        // Metodo para actualizar una zona
        public void EditarZona(entZonas zon)
        {
            datZonaDeCobertura.Instancia.EditarZona(zon);
        }

        // Metodo para deshabilitar una zona
        public void DeshabilitarZona(entZonas zon)
        {
            datZonaDeCobertura.Instancia.DeshabilitarZona(zon);
        }

    }
}
