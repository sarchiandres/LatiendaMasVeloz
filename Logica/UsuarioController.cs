using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;

namespace Logica
{
    public class UsuarioController
    {
        public string GuardarUsuario(string name, string description)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarUsuario(name,description);

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

        public UsuarioEntity MostrarUsuario()
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
