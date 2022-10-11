using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Algoritmo_3
{
    public partial class frmResultados : Form
    {
       
        private double m_sumafija;
        private double m_porcentaje;

        /*
         * Este método es el CONSTRUCTOR del formulario ( ya lo trae por defecto)
         * y aquí es donde colocamos los parámetros que recibira para luego pasarlos 
         * a las variables
         */

        public frmResultados(double SF, double P)
        {
            m_sumafija = SF; //cargo en la variable privada el valor recibido por parámetro
            m_porcentaje = P;//cargo en la variable privada el valor recibido por parámetro
            InitializeComponent();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            //llamo a la clase (de tipo estática) que contiene los métodos para realizar los cálculos
            //al llamarla y seleccionar el método necesario le paso los parámetros recibidos anteriormente
            clsCalcularVentas.Calcular(m_sumafija, m_porcentaje);
            //Enlazo el DataGridView a una lista de clases para poder visualizar los resultados
            dtgResultados.DataSource = clsCalcularVentas.ventasxVendeor;
        }
    }
}
