using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UD18
{
    public class descoconnexio
    {
        public descoconnexio(SqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se desconecto");
            Console.ReadKey();
        }
    }
}
