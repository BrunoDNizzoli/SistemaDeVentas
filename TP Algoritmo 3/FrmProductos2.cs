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
    public partial class FrmProductos2 : Form
    {
        public FrmProductos2()
        {
            InitializeComponent();
        }

        private void mensajeError(Control control)
        {
            MessageBox.Show(
                    "Error al Salir: Debe cargar por lo menos 1 Producto",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            control.Focus();
        }

        private KeyPressEventArgs soloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar) |
                char.ToString(e.KeyChar) == ".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e;
        }


        private bool isNumeric(string valor)
        {
            try
            {
                // Si puede convertilo a double devuelve verdadero (es numerico)
                Convert.ToDouble(valor);
                return true;
            }
            catch (Exception)
            {
                // Al no poder convertirse y generarse una excepcion devuelve falso (no es un numero)
                return false;
            }
        }





        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                mensajeError(txtNombre);
                return;
            }
            // Verifico que el valor del txtPrecio no sea numerico
            if (!isNumeric(txtPrecio.Text))
            {
                mensajeError(txtPrecio);
                return;
            }
            



            ClaseProducto1 producto = new ClaseProducto1();   //clsVentas venta = new clsVentas(); 
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToInt32(txtPrecio.Text);   //Convert.ToInt32                              //         venta.Vendedor = cmbVendedores.Text;

            clsListaProducto.productos.Add(producto);                                     //clsListaVentas.ventas.Add(venta);

            ActualizarProducto();


            LimpiarControles();



        }
        private void LimpiarControles()
        {

            txtNombre.Text = "";
            txtPrecio.Text = "";
        }
        private void ActualizarProducto()
        {
            //Método que actualiza el DataGridView a partir de la lista de ventas
            dtgProductos.DataSource = null; //Limpio el DataGredView
            dtgProductos.DataSource = clsListaProducto.productos; //Enlado el DataGridView a la lista
        }
        private void FrmProductos2_Load(object sender, EventArgs e)
        {
            dtgProductos.DataSource = clsListaProducto.productos; // List<ClaseProducto1> productos = new List<ClaseProducto1>();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            
            Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAgregarProducto.PerformClick();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            soloNumeros(e);
            if (e.KeyChar == 13)
            {
                btnAgregarProducto.PerformClick();
            }
        }

        private void FrmProductos2_FormClosing(object sender, FormClosingEventArgs e)
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
