using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmo_3
{
    public static class clsCalcularVentas
    {
        public static List<Totales> ventasxVendeor = new List<Totales>();
        public static List<Totales> ventasxClient = new List<Totales>();
        public static List<Totales> ventasxProduct = new List<Totales>();


        public static void Calcular(double MF, double Porc)
        {
            ventasxVendeor.Clear();
            int l = clsListaVentas.ventas.Count;
            for (int i = 0; i < l; i++)
            {
                string Ven = clsListaVentas.ventas[i].Vendedor;
                double Val = clsListaVentas.ventas[i].Total;
                acumular(Ven, Val);
            }
            CalcularPorcentajes(Porc, MF);
        }


        public static void CalcularP(double MF, double Porc)
        {
            ventasxClient.Clear();
            int l = clsListaVentas.ventas.Count;
            for (int i = 0; i < l; i++)
            {
                string Ven = clsListaVentas.ventas[i].Cliente;
                double Val = clsListaVentas.ventas[i].Total;
                acumularC(Ven, Val);
            }
            CalcularPorcentajesC(Porc, MF);
        }


        public static void CalcularPr(double MF, double Porc)
        {
            ventasxClient.Clear();
            int l = clsListaVentas.ventas.Count;
            for (int i = 0; i < l; i++)
            {
                string Ven = clsListaVentas.ventas[i].Producto;
                double Val = clsListaVentas.ventas[i].Total;
                acumularP(Ven, Val);
            }
            CalcularPorcentajesPro(Porc, MF);
        }


        private static void acumular(string ven, double val)
        {
            bool encontrado = false;
            int l = ventasxVendeor.Count;
            for (int i = 0; i < l; i++)
            {
                if (ventasxVendeor[i].Vendedor.Contains(ven))
                {
                    encontrado = true;
                    ventasxVendeor[i].Total = ventasxVendeor[i].Total + val;
                }
            }
            if (encontrado == false)
            {
                ventasxVendeor.Add(new Totales() { Vendedor = ven, Total = val });
            }
        }

        private static void acumularC(string ven, double val)
        {
            bool encontrado = false;
            int l = ventasxClient.Count;
            for (int i = 0; i < l; i++)
            {
                if (ventasxClient[i].Cliente.Contains(ven))
                {
                    encontrado = true;
                    ventasxClient[i].Total = ventasxClient[i].Total + val;
                }
            }
            if (encontrado == false)
            {
                ventasxClient.Add(new Totales() { Cliente = ven, Total = val });
            }
        }

        private static void acumularP(string ven, double val)
        {
            bool encontrado = false;
            int l = ventasxProduct.Count;
            for (int i = 0; i < l; i++)
            {
                if (ventasxProduct[i].Producto.Contains(ven))
                {
                    encontrado = true;
                    ventasxProduct[i].Total = ventasxProduct[i].Total + val;
                }
            }
            if (encontrado == false)
            {
                ventasxProduct.Add(new Totales() { Producto = ven, Total = val });
            }
        }

        private static void CalcularPorcentajes(double porc, double mf)
        {
            int l = ventasxVendeor.Count;
            for (int i = 0; i < l; i++)
            {
                double valor = ventasxVendeor[i].Total;
                valor = (valor * porc) / 100;
                ventasxVendeor[i].Total = valor + mf;
            }
        }
        private static void CalcularPorcentajesC(double porc, double mf)
        {
            int l = ventasxClient.Count;
            for (int i = 0; i < l; i++)
            {
                double valor = ventasxClient[i].Total;
                valor = (valor * porc) / 100;
                ventasxClient[i].Total = valor + mf;
            }
        }

        private static void CalcularPorcentajesPro(double porc, double mf)
        {
            int l = ventasxProduct.Count;
            for (int i = 0; i < l; i++)
            {
                double valor = ventasxProduct[i].Total;
                valor = (valor * porc) / 100;
                ventasxProduct[i].Total = valor + mf;
            }
        }


    }   
    public class Totales
    {
        public string Vendedor { get; set; }
        public double Total { get; set; }

        public string Cliente { get; set; }

        public string Producto { get; set; }

    }
}
