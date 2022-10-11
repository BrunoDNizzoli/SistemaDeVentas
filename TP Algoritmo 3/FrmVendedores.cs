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
    public partial class FrmVendedores : Form
    {
        public FrmVendedores()
        {
            InitializeComponent();
        }

        private void mensajeError(Control control)
        {
            MessageBox.Show(
                    "Error al Eliminar: No hay vendedores cargados",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            control.Focus();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVendedores_Load(object sender, EventArgs e)
        {
            if (cdtVendedores.vendedores.Count > 0)
            {
                ActualizarListBox();
            }
            txtVendedor.CharacterCasing = CharacterCasing.Upper; //fuerzo a que escriba en mayusculas
        }

        private void btn_agregarVendedor_Click(object sender, EventArgs e)
        {
            
            
            
            
            if (txtVendedor.Text.Length > 0)
            {
                cdtVendedores.vendedores.Add(txtVendedor.Text);
                cdtVendedores.vendedores.Sort();

                ActualizarListBox();

                txtVendedor.Clear();
                txtVendedor.Focus();
            }
            else
            {
                MessageBox.Show("No se puede cargar un vendedor en blanco.",
                    "DATO INCORRECTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVendedor.Focus();
            }
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarListBox()
        {
            lstVendedores.DataSource = null;
            lstVendedores.DataSource = cdtVendedores.vendedores;
        }

        private void txtVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_agregarVendedor.PerformClick();
            }
        }

        private void btn_eliminarVendedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lstVendedores.Text.Trim()))
            {
                mensajeError(lstVendedores);
                return;
            }



            DialogResult resultado = MessageBox.Show("Está seguro de eliminar el vendedor seleccionado?",
                                "ELIMINAR VENDEDOR",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2);

            
            if (resultado == DialogResult.OK)
            {
                cdtVendedores.vendedores.Remove(lstVendedores.SelectedValue.ToString());
                ActualizarListBox();
            }
                       
            /*if (!string.IsNullOrEmpty(lstVendedores.Text))
            {

                MessageBox.Show("Debe cargar un Vendedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                lstVendedores.Focus();


            }
            /*else 
            {
                //MessageBox.Show("Debe seleccionar un item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                lstVendedores.Focus();
            }*/
        }

        private void FrmVendedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea finalizar la carga de Vendedores?",
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
