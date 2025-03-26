using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entities
{
   public class Producto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public int documento_proveedor { get; set; }

    }
}
