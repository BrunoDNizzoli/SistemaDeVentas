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
    public partial class frmPantallainicio : Form
    {
        public frmPantallainicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirClientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirOperaciones();
        }

        private void AbrirOperaciones()
        //este método llama al formulario que permite agregar y/o quitar vendedores
        //luego limpia el combi si es que tiene algo y lo vuelve a cargar a partir de una lista
        {
            FrmOperaciones frm = new FrmOperaciones();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 

        }


        private void AbrirClientes()
        //este método llama al formulario que permite agregar y/o quitar vendedores
        //luego limpia el combi si es que tiene algo y lo vuelve a cargar a partir de una lista
        {
            FrmClientes frm = new FrmClientes();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 

        }

        private void btn_abrirVendedores_Click(object sender, EventArgs e)
        {
            AbrirVendedores();
        }

        private void AbrirVendedores()
        //este método llama al formulario que permite agregar y/o quitar vendedores
        //luego limpia el combi si es que tiene algo y lo vuelve a cargar a partir de una lista
        {
            FrmVendedores frm = new FrmVendedores();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 

        }

        private void btn_abrirProductos_Click(object sender, EventArgs e)
        {
            AbrirProductos();
        }

        private void AbrirProductos()
        //este método llama al formulario que permite agregar y/o quitar vendedores
        //luego limpia el combi si es que tiene algo y lo vuelve a cargar a partir de una lista
        {
            FrmProductos2 frm = new FrmProductos2();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 

        }

        private void frmPantallainicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Espero que esta app te haya hecho decir SAPBEEE.Desea finalizar la aventura",
                                           "FINAL DE LA APP",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Asterisk,
                                           MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true; //Cancela el cierre del formulario
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
