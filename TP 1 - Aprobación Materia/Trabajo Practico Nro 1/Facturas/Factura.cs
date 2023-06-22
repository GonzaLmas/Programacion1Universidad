using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturas
{
    public class Factura
    {
        public string Codigo { get; set; }
        public Factura Siguiente { get; set; }

    }
}
