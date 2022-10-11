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
    public partial class FrmPantalla : Form
    {
        public FrmPantalla()
        {
            InitializeComponent();
        }

        private void btn_abrirClientes_Click(object sender, EventArgs e)
        {
            ActualizarVendedores();
            ActualizarProductos();

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            
            txtPrecio.Clear();
            lblTotal.Text = "";
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        //Evento TextChanged (Mientras esta cambiando el texto)
        //del TextBox del precio. Lo utilizo en este caso para
        //que se actualice el Label donde muestro el total de la venta
        {
            if (txtPrecio.Text.Length > 0)
            {
                lblTotal.Text = Convert.ToString(Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text));
            }
            else
            {
                lblTotal.Text = "";
            }
        }
        private void ActualizarVentas()
        {
            
            
            
            //Método que actualiza el DataGridView a partir de la lista de ventas
            dtgVentas.DataSource = null; //Limpio el DataGredView
            dtgVentas.DataSource = clsListaVentas.ventas; //Enlado el DataGridView a la lista
        }
        private void FrmPantalla_Load(object sender, EventArgs e)
        {
            // para que no se pueda escribir en el combobox
            cmbVendedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            //llamo al metodo que actualiza el combo de vendedores
            ActualizarProductos();
            ActualizarVendedores();
            //la siguiente linea oculta la cabecera de fila de un DataGridView
            dtgVentas.RowHeadersVisible = false;
            //Enlazo el DataGridView a una lista, de esta manera se veran reflejados los cambios en la lista
            //en el DataGredView
            dtgVentas.DataSource = clsListaVentas.ventas;
            dtgVentas.DataSource = clsListaProductos.productos1;
            //Asigno los valores por defecto a los TextBox
            txtSumaFija.Text = "30";
            txtPorcentaje.Text = "21";
          
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            {
                //Verifico que los TextBox de Suma Fija y Porcentaje no esten vacios
                //si lo están informo y mando el foco al TextBox
                if (string.IsNullOrEmpty(txtSumaFija.Text) || string.IsNullOrEmpty(txtPorcentaje.Text))
                {
                    MessageBox.Show("La suma fija y/o el porcentaje no pueden ser nulos");
                    txtSumaFija.Focus(); //Mando el foco (cursor) al TextBox
                    return; //corto el proceso
                }
                /*
                 * en la siguiente linea instancio el Formulario donde se realizarán las operaciones de cierre
                 * pero prestar atención que dicho formulario recibe dos datos (Monto Fijo y Porcentaje) como 
                 * parámetros
                 * */
                frmResultados frm =
                    new frmResultados(Convert.ToDouble(txtSumaFija.Text), Convert.ToDouble(txtPorcentaje.Text));
                frm.ShowDialog(); //ejecuto el formulario
            }
        }

        private void f(object sender, ControlEventArgs e)
        {

        }

        private void FrmPantalla_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de CERRAR el sistema?",
                               "FINALIZAR SISTEMA",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Asterisk,
                               MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true; //Cancela el cierre del formulario
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //evento Click del boton para agregar una venta
            //la misma se agrega a una lista a tal fin alojada
            //en una clase de tipo estatica (de esta manera se
            //puede acceder desde cualquier lado del programa
            //sin necesidad de instanciarla   
            clsListaVentas.ventas.Add(new clsVentas()
            {
                Vendedor = cmbVendedores.Text,                  //agrego vendedor
                Cantidad = Convert.ToInt32(txtCantidad.Text),   //agrego cantidad
                Total = Convert.ToDouble(lblTotal.Text),  
                Fecha = dateTimePicker1.Text//agrego cantidad total
                
            });


            clsListaProductos.productos1.Add(new productos()
            {
                NombreDelProducto = cmbProductos.Text,                  //agrego vendedor
                Costo = Convert.ToInt32(txtPrecio.Text),   //agrego cantidad
               
                
            });
            
            
            
            
            //llamo al metodo que actualiza el DataGridView de ventas
            //a partir de la lista anterior
            ActualizarVentas();
            //Llamo al metodo que limpia los controles

            ActualizarProductos();


            LimpiarControles();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarProductos()
        {
            
            frmProductos1 frm = new frmProductos1();//instancio el formulario
            frm.ShowDialog();   //abro el formulario 
            cmbProductos.Items.Clear(); //vacío el ComboBox
            cmbProductos.Items.AddRange(clsListaProductos.productos1.ToArray()); //cargo el ComboBox a partir de una lista
            cmbProductos.SelectedIndex = 0; // selecciono el primer elemento del ComboBox


            //Método que actualiza el DataGridView a partir de la lista de ventas
            dtgVentas.DataSource = null; //Limpio el DataGredView
            dtgVentas.DataSource = clsListaProductos.productos1; //Enlado el DataGridView a la lista
        }

        private void cmbVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
