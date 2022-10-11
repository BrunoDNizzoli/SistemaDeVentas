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
    public partial class frmProductos1 : Form
    {
        public frmProductos1()
        {
            InitializeComponent();
        }

       
        List<productos> productos1 = new List<productos>(); //  List<productos> productos1 = new List<productos>();


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        public void guardarproducto()
        {
            clsListaProductos.productos1.Add(new productos()
            {
                Nombre = txt_nombre.Text,                  //agrego vendedor
                Costo = Convert.ToInt32(txt_costo.Text),   //agrego cantidad
                                                           //agrego cantidad total
            });

            productos productos = new productos(txt_nombre.Text , int.Parse(txt_costo.Text));

            productos1.Add(productos);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos1;

        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
           

            guardarproducto();
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void frmProductos1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                DialogResult resultado = MessageBox.Show("Desea finalizar la carga de Productos?",
                                                "FINAL DE CARGA",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Asterisk,
                                                MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Cancel)
                {
                    e.Cancel = true; //Cancela el cierre del formulario
                }
            
        }
    } 
}
