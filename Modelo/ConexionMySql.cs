using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class ConexionMySql
    {
        public MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMySql()
        {
            cadenaConexion = "Database=laTiendaMasVeloz;Datasource=localhost;User Id=root;Password=2006";
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            return connection;
        }
    }
}
