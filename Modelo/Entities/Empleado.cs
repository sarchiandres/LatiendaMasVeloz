using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
   public class Empleado
    {
        public int documento_id_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public int tipo_empleado { get; set; }
    }
}
