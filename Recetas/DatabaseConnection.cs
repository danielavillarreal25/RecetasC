//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Recetas
//{
//    internal class DatabaseConnection
//    {


//            // Cadena de conexión a la base de datos
//            private string connectionString = @"Server=DESKTOP-NS0DOBO\SQLEXPRESS;Database=RECETASPROYECTO;Trusted_Connection=True;";

//            // Método para abrir una conexión a la base de datos
//            public SqlConnection OpenConnection()
//            {
//                try
//                {
//                    SqlConnection connection = new SqlConnection(connectionString);
//                    connection.Open();
//                    Console.WriteLine("Conexión abierta exitosamente.");
//                    return connection;
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Error al abrir la conexión: " + ex.Message);
//                    return null;
//                }
//            }

//            // Método para cerrar una conexión a la base de datos
//            public void CloseConnection(SqlConnection connection)
//            {
//                try
//                {
//                    if (connection != null && connection.State == System.Data.ConnectionState.Open)
//                    {
//                        connection.Close();
//                        Console.WriteLine("Conexión cerrada exitosamente.");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
//                }
//            }
//        }
//    }



using System;
using System.Data.SqlClient;

namespace Recetas
{
    internal class DatabaseConnection
    {
        private string connectionString = @"Server=DESKTOP-NS0DOBO\SQLEXPRESS;Database=RECETASPROYECTO;Trusted_Connection=True;";

        public SqlConnection OpenConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexión abierta exitosamente.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return null;
            }
        }

        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Conexión cerrada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}

