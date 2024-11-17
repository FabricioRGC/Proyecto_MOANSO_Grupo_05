using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using static CapaEntidad.ProformaVenta;
using CapaDatos;

namespace CapaLogica
{
    public class logProforma
    {
        // Patron Singleton
        private static readonly logProforma _instancia = new logProforma();

        public static logProforma Instancia
        {
            get { return logProforma._instancia; }
        }

        // Metodo para listar las proformas
        public List<entProformaVenta> ListarProforma()
        {
            return datProforma.Instancia.ListarProforma();
        }

        // Metodo para añadir una proforma
        public void InsertaProforma(entProformaVenta pro)
        {
            //datProforma.Instancia.InsertarProforma(pro);
        } 

        // Metodo para inhabilitar una proforma
        public void DeshabilitarProforma(entProformaVenta pro)
        {
            datProforma.Instancia.InhabilitarProforma(pro);
        }
    }
}
