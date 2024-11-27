using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        //Clase1 renombrar a coneccion 
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {   
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=USUARIO\\SQLEXPRESS; Initial Catalog = Lunnys_Peru_BD;" +//"User ID=sa; Password = 123"; +
                            "Integrated Security=true";
            return cn; 
        }
    }
}
