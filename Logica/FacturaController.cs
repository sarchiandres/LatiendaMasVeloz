using Modelo.Entities;
using Modelo;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class FacturaController
    {
        public string GuardarFactura(int id_factura, int id_producto, int id_cliente, int id_empleado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarFactura(id_factura, id_producto, id_cliente, id_empleado);

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

        public Cliente MostrarCliente()
        {
            BaseDatos db = new BaseDatos();
            UsuarioEntity usuarioActual = db.MostrarUsuario();
            return usuarioActual;

        }
        public List<LibroEntity> MostrarLibro()
        {
            BaseDatos db = new BaseDatos();
            List<LibroEntity> libros = db.MostrarLibro();
            return libros;
        }
    }
}
