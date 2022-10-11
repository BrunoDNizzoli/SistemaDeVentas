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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void mensajeError(Control control)
        {
            MessageBox.Show(
                    "Error al Guardar: \n Debe completar los campos obligatorios",
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtSumaFija.Text.Length > 0)
                {
                    lblIva.Text = txtSumaFija.Text;
                }
                else
                {
                    lblIva.Text = "";
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {


            
            //textBox1.Text = frmProductos1.txt_nombre.Text;
            cmbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            //llamo al metodo que actualiza el combo de vendedores
            ActualizarProductos();
            ActualizarVendedores();
            ActualizarClientes();
            //la siguiente linea oculta la cabecera de fila de un DataGridView
            dtgVentas.RowHeadersVisible = false;
            dtgProductos.RowHeadersVisible = false;

            //Enlazo el DataGridView a una lista, de esta manera se veran reflejados los cambios en la lista
            //en el DataGredView
            dtgVentas.DataSource = clsListaVentas.ventas;
            dtgVentas.DataSource = clsListaProducto.productos;   // List<ClaseProducto1> productos = new List<ClaseProducto1>();
            //Asigno los valores por defecto a los TextBoxclsListaProducto
            dtgProductos.DataSource = clsListaProducto.productos;
            txtSumaFija.Text = "30";   
            txtPorcentaje.Text = "21";
            cmbProductos.DisplayMember = "Nombre";






        }
        private void ActualizarVendedores()
        //este método llama al formulario que permite agregar y/o quitar vendedores
        //luego limpia el combi si es que tiene algo y lo vuelve a cargar a partir de una lista
        {
            FrmVendedores frm = new FrmVendedores();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 
            cmbVendedores.Items.Clear(); //vacío el ComboBox
            cmbVendedores.Items.AddRange(cdtVendedores.vendedores.ToArray()); //cargo el ComboBox a partir de una lista
            cmbVendedores.SelectedIndex = 0; // selecciono el primer elemento del ComboBox
        }

        private void ActualizarProductos()
        {

            FrmProductos2 frm = new FrmProductos2();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 
            cmbProductos.Items.Clear(); //vacío el ComboBox
            cmbProductos.Items.AddRange(clsListaProducto.productos.ToArray()); //cargo el ComboBox a partir de una lista
            cmbProductos.SelectedIndex = 0; // selecciono el primer elemento del ComboBox


            //dtgVentas.DataSource = null; //Limpio el DataGredView
            //dtgVentas.DataSource = clsListaProducto.productos; //Enlado el DataGridView a la lista

            //Método que actualiza el DataGridView a partir de la lista de ventas

        }

        private void ActualizarClientes()
        //este método llama al formulario que permite agregar y/o quitar vendedores
        //luego limpia el combi si es que tiene algo y lo vuelve a cargar a partir de una lista
        {
            FrmClientes frm = new FrmClientes();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 
            cmbClientes.Items.Clear(); //vacío el ComboBox
            cmbClientes.Items.AddRange(cdtClientes.clientes.ToArray()); //cargo el ComboBox a partir de una lista
            cmbClientes.SelectedIndex = 0; // selecciono el primer elemento del ComboBox
        }

        private void btnAbrirFrmVendedores_Click(object sender, EventArgs e)
        {
            FrmVendedores frm = new FrmVendedores();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 
        }

        private void btnAbrirFrmClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();//instancio el formulario
            frm.ShowDialog();   
        }

        private void btnAbrirfrmProductos1_Click(object sender, EventArgs e)
        {
            FrmProductos2 frm = new FrmProductos2();//instancio el formulario
            frm.ShowDialog();   
        }

        public class CheckboxModel
        {
            public bool IVAchek { get; set; }
        }
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            //evento Click del boton para agregar una venta
            //la misma se agrega a una lista a tal fin alojada
            //en una clase de tipo estatica (de esta manera se
            //puede acceder desde cualquier lado del programa
            //sin necesidad de instanciarla   }
            clsVentas venta = new clsVentas();
            venta.Vendedor = cmbVendedores.Text;
            venta.Cantidad = Convert.ToInt32(nupCantidad.Text);
            venta.Cliente = cmbClientes.Text;
            venta.Producto = cmbProductos.Text;
            venta.Fecha = dateTimePicker1.Text;
            venta.Precio = Convert.ToInt32(txtCosto.Text);
            venta.Total = venta.Cantidad * venta.Precio;
            venta.valordeventa = venta.Total / (Convert.ToInt32(txtPorcentaje.Text));
            if (checkBoxIVA.Checked == true)
            {
                venta.valorIVA = venta.Total / Convert.ToInt32(txtSumaFija.Text);
            }
                                                //cantidad, nombre del producto,costo unitario, costo total, valor de venta, subtotal, importe iva

            clsListaVentas.ventas.Add(venta);
            /*
        {
                Vendedor = ,                  //agrego vendedor
                Cantidad = Convert.ToInt32(nupCantidad.Text),   //agrego cantidad
                Total = Convert.ToDouble(lblTotal.Text),
                Cliente = cmbClientes.Text,
                Producto = cmbProductos.Text,  //agrego cantidad total


            })

        clsListaProductos.productos1.Add(new productos()
        {
           NombreDelProducto = cmbProductos.Text,




        });

        */
            //llamo al metodo que actualiza el DataGridView de ventas
            //a partir de la lista anterior
            ActualizarVentas();
            //Llamo al metodo que limpia los controles
            LimpiarControles();

            //lblSubtotal.Text = Convert.ToString(Convert.ToDouble(txtCosto.Text) / 2);


        }

        private void ActualizarVentas()
        {
            //Método que actualiza el DataGridView a partir de la lista de ventas
            dtgVentas.DataSource = null; //Limpio el DataGredView
            dtgVentas.DataSource = clsListaVentas.ventas; //Enlado el DataGridView a la lista
        }

        private void LimpiarControles()
        {
            
            lblTotal.Text = "";
            
        }

        private void cmbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmCierre frm =
               new FrmCierre(Convert.ToDouble(txtSumaFija.Text), Convert.ToDouble(txtPorcentaje.Text));
            frm.ShowDialog(); //ejecuto el formulario
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (txtCosto.Text.Length > 0)
            {
                lblSubtotal.Text = Convert.ToString(Convert.ToDouble(txtCosto.Text) / 2);
            }
            else
            {
                lblSubtotal.Text = "";
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmOperaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea finalizar las Ventas?",
                                           "FINAL DE VENTAS (BUG ALERT!)",
                                           MessageBoxButtons.OKCancel,
                                           MessageBoxIcon.Asterisk,
                                           MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true; //Cancela el cierre del formulario
            }
        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtSumaFija_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
