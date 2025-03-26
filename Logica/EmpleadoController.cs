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
    class EmpleadoController
    {
        public string GuardarEmpleado(int documento_id_empleado, string nombre_empleado, string contraseña,int tipo_empleado)
        {
            string resultado;
            BaseDatos db = new BaseDatos();
            int filasInsertadas = db.GuardarEmpleado(documento_id_empleado, nombre_empleado,contraseña ,tipo_empleado);

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

        
    }
}
