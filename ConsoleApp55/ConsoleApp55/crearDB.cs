using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace UD18
{
    public class crearDB
    {
        public crearDB(string crear, SqlConnection conexion)
        {
            try
            {
                SqlCommand comando = new SqlCommand(crear, conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("La base s'ha creat");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Console.WriteLine("La base ja existeix");
            }
        }
    }
}
