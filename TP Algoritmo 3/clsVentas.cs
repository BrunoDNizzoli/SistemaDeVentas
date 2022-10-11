using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmo_3
{
    public class clsVentas
    {
        public string Vendedor { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; } 
        
        public string Cliente { get; set; }
        
        public string Fecha { get; set; }

        public string Producto { get; set; }

        public int Precio { get; set; }

        public double valordeventa { get; set; }

        public double valorIVA { get; set; }

    }
}
