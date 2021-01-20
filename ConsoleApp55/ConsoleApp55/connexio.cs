using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UD18
{
    public class connexio
    {
        SqlConnection conexion;
        SqlConnection conecionDB;
        public connexio()
        {
            try
            {
                conexion = new SqlConnection("Data Source = 192.168.5.157; Persist Security Info = True; User ID=sa; Password = Cursroot1;");
                conexion.Open();
                Console.WriteLine("Se conecto");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Console.WriteLine("La base ja existeix");
            }

        }
        public connexio(SqlConnection con)
        {
            try { 
                conexion = con;
                conexion.Open();
                Console.WriteLine("Se conecto a la BD");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Console.WriteLine("La base ja existeix");
            }
}

        public SqlConnection getConnexion()
        {
            return conexion;
        }

        public SqlConnection getConnexionDB(string DB)
        {
            string cadena = "Data Source = 192.168.5.157; Initial Catalog = "+DB+"; Persist Security Info = True; User ID=sa; Password = Cursroot1;";

            conecionDB = new SqlConnection(cadena);

            return conecionDB;
        }

        public SqlConnection getConnexionDB()
        {
            return conecionDB;
        }
    }
}
