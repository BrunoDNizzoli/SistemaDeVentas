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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            if (cdtClientes.clientes.Count > 0)
            {
                ActualizarListBox();
            }
            txtCliente.CharacterCasing = CharacterCasing.Upper; //fuerzo a que escriba en mayusculas
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Length > 0)
            {
                cdtClientes.clientes.Add(txtCliente.Text);
                cdtClientes.clientes.Sort();

                ActualizarListBox();

                txtCliente.Clear();
                txtCliente.Focus();
            }
            else
            {
                MessageBox.Show("No se puede cargar un vendedor en blanco.",
                    "DATO INCORRECTO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCliente.Focus();
            }
        }

        private void ActualizarListBox()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = cdtClientes.clientes;
        }

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Está seguro de eliminar la razon social seleccionada?",
                                "ELIMINAR RAZON SOCIAL",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2);

            if (resultado == DialogResult.OK)
            {
                cdtClientes.clientes.Remove(lstClientes.SelectedValue.ToString());
                ActualizarListBox();
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_agregarCliente.PerformClick();
            }
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea finalizar la carga de RAZONES SOCIALES?",
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
