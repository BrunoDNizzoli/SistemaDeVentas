using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Algoritmo_3
{
    public static class clsCalcularVentas1
    {
        public static List<Totales> ventasxVendeor = new List<Totales>();


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
    }
    public class Totales1
    {
        public string Vendedor { get; set; }
        public double Total { get; set; }

    }
}
