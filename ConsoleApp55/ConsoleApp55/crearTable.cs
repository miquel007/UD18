using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UD18
{
    public class crearTable
    {
        public crearTable(string cadena, SqlConnection con)
        {
            try
            {
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                Console.WriteLine("La tabla s'ha creat a la DB");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Console.WriteLine("La Tabla ja existeix");
            }
        }
    }
}
