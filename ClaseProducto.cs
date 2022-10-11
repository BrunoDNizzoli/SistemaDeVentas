using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmo_3
{
    public  class productos
    {
        public string NombreDelProducto { get; set; }
        public int Costo { get; set; }
    
        
        
        
        public productos()
        {
            NombreDelProducto = string.Empty;
            Costo = 0;
        }
    
        public string Nombre
        {
            get { return NombreDelProducto; }
            set { NombreDelProducto = value; }
        }
    

        public int costo
        {
            get { return Costo;}
            set { Costo = value; }  
        }


        public productos( string nom,  int cost)
        {
            Nombre = nom;
            Costo = cost;
        }
   
       
    
    }
}
