using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaEntidad.Cliente;
using static CapaEntidad.NotaDeSalida;

namespace CapaLogica
{
    public class LogNotaDeSalida
    {
        // Patron Singleton
        private static readonly LogNotaDeSalida _instancia = new LogNotaDeSalida();

        public static LogNotaDeSalida Instancia
        {
            get { return LogNotaDeSalida._instancia; }
        }

        // Metodo para listar los clientes
        public List<entNotadesalida> ListarNotadeSalida()
        {
            return datNotaDeSalida.Instancia.ListarNotadeSalida();
        }

        public void InsertarNotaSalidaMateriales(entNotadesalida cli)
        {
            datNotaDeSalida.Instancia.InsertarNotaSalidaMateriales(cli);
        }

        public void InsertarNotaSalidaRepuestos(entNotadesalida cli)
        {
            datNotaDeSalida.Instancia.InsertarNotaSalidaRepuestos(cli);
        }

        public void DeshabilitarNotadeSalida(entNotadesalida cli)
        {
            datNotaDeSalida.Instancia.DeshabilitarNotadeSalida(cli);
        }
        public void ReducirStockMateriales(entNotadesalida cli)
        {
            datNotaDeSalida.Instancia.ReducirStockMateriales(cli);
        }
        public void ReducirStockRepuestos(entNotadesalida cli)
        {
            datNotaDeSalida.Instancia.ReducirStockRepuestos(cli);
        }
    }
}
