using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
   public class Factura
    {
        public int id_factura { get; set; }
        public int id_producto { get; set; }

        public int id_cliente { get; set; }
        public int id_empleado { get; set; }

    }
}
