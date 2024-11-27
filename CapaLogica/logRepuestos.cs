using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Material;

namespace CapaLogica
{
    public class logRepuestos
    {
        private static readonly logRepuestos _instancia = new logRepuestos();

        public static logRepuestos Instancia
        {
            get { return logRepuestos._instancia; }
        }

        // Método para listar los repuestos
        public List<Repuesto.entRepuesto> ListarRepuestos()
        {
            return datRepuestos.Instancia.ListarRepuestos();
        }

        // Método para añadir un repuesto
        public void InsertarRepuesto(Repuesto.entRepuesto repuesto)
        {
            datRepuestos.Instancia.InsertarRepuesto(repuesto);
        }

        // Metodo para actualizar un repuesto
        public void EditarRepuestos(Repuesto.entRepuesto repuesto)
        {
            datRepuestos.Instancia.EditarRepuestos(repuesto);
        }

        // Método para deshabilitar un repuesto
        public void DeshabilitarRepuestos(Repuesto.entRepuesto repuesto)
        {
            datRepuestos.Instancia.DeshabilitarRepuestos(repuesto);
        }
    }
}
