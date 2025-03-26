using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entities;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {

        public int GuardarCliente(int documento, string nombre,int numero)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "CALL GURADAR_CLIENTE ("+documento+""+nombre+" "+numero+")";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public List<Cliente>  MostrarClientes()
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "select * from cliente ";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Cliente> clientes = new();
            while (reader.Read())
            {
                Cliente ClienteActual = new Cliente();
                ClienteActual.documento = reader.GetInt32(0);
                ClienteActual.nombre = reader.GetString(1);
                ClienteActual.numero = reader.GetString(2);
                clientes.Add(ClienteActual);
            }

            return clientes;

        }

        public int GuardarEmpleado(int documento, string nombre , string contraseña , int tipoEmpleado )
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "CALL GURADAR_EMPLEADO (" + documento + "" + nombre + " " + contraseña + " "+tipoEmpleado+")";
            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas; 
        }
       

        

    }
}
