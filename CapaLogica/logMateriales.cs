using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Material;
using CapaDatos;

namespace CapaLogica
{
    public class logMateriales
    {
        private static readonly logMateriales _instancia = new logMateriales();

        public static logMateriales Instancia
        {
            get { return logMateriales._instancia; }
        }

        // Metodo para listar los materiales
        public List<entMateriales> ListarMateriales()
        {
            return datMateriales.Instancia.ListarMateriales();
        }
        
        // Metodo para añadir un materiales
        public void InsertarMateriales(entMateriales mat)
        {
            datMateriales.Instancia.InsertarMateriales(mat);
        }

        
        // Metodo para actualizar un materiales
        public void EditarMateriales(entMateriales mat)
        {
            datMateriales.Instancia.EditarMateriales(mat);
        }
        
        // Metodo para deshabilitar un materiales
        public void DeshabilitarMateriales(entMateriales mat)
        {
            datMateriales.Instancia.DeshabilitarMateriales(mat);
        }
        
    }
}
