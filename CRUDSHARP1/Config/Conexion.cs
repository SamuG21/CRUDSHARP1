using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSHARP1.Config
{
    class Conexion
    {
        public static SqlConnection Conetar()
        {
            SqlConnection conexion = new SqlConnection("server=SAMUELGC21\\SQLEXPRESS; database=proyect; Trusted_Connection=true;");
            conexion.Open();

            return conexion;


        }
    }
}
