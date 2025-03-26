using Modelo.Entities;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class ClienteController
    {
        public string GuardarCliente(int documento, string nombre, int numero)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarCliente(documento, nombre, numero);

            if (filasInsertadas > 0)
            {
                resultado = "Guardado";
            }
            else
            {
                resultado = "No Guardado";
            }
            return resultado;
        }

        public List<Cliente> VerClientes()
        {
            BaseDatos db = new BaseDatos();
            List<Cliente> clienteActual = db.MostrarClientes();
            return clienteActual;

        }
        
    }
}
