using System.Data.SqlClient;

namespace CRUDSHARP1
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