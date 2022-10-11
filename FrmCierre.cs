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
    public partial class FrmCierre : Form
    {
        public FrmCierre(double SF, double P)
        {
            m_sumafija = SF; //cargo en la variable privada el valor recibido por parámetro
            m_porcentaje = P;//cargo en la variable privada el valor recibido por parámetro
            InitializeComponent();
           
        }
        private double m_sumafija;
        private double m_porcentaje;
        private void FrmCierre_Load(object sender, EventArgs e)
        {
           // clsCalcularVentas.CalcularP(m_sumafija, m_porcentaje);
           // dtgVentas.DataSource = clsCalcularVentas.ventasxClient;
            clsCalcularVentas.Calcular(m_sumafija, m_porcentaje);
            dtgVentas.DataSource = clsCalcularVentas.ventasxVendeor;
        }

        private void btnAbrirClientes_Click(object sender, EventArgs e)
        {
            dtgVentas.DataSource = null; //Limpio el DataGredView
            clsCalcularVentas.CalcularP(m_sumafija, m_porcentaje);
            dtgVentas.DataSource = clsCalcularVentas.ventasxClient;
        }

        private void btnAbrirProductos_Click(object sender, EventArgs e)
        {
            dtgVentas.DataSource = null;
            clsCalcularVentas.CalcularPr(m_sumafija, m_porcentaje);
            dtgVentas.DataSource = clsCalcularVentas.ventasxProduct;
        }

        private void btnAbrirVendedores_Click(object sender, EventArgs e)
        {

            clsCalcularVentas.Calcular(m_sumafija, m_porcentaje);
            dtgVentas.DataSource = clsCalcularVentas.ventasxVendeor;
        }
    }
}
