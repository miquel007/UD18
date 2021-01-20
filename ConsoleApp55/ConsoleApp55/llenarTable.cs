using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UD18
{
    public class llenarTable
    {
        public llenarTable(string datos, SqlConnection con )
        {
            try
            {
                SqlCommand comando = new SqlCommand(datos, con);
                comando.ExecuteNonQuery();
                Console.WriteLine("Se ha llenado la tabla");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Console.WriteLine("Los datos han fallado");
            }
        }
    }
}
