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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
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
    }
}
