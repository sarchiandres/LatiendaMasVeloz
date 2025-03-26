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
    class ProductoController
    {
        public string GuardarProducto(int id_producto, string nombre_producto, int documento_proveedor)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarProducto(id_producto, nombre_producto, documento_proveedor);

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

