namespace TP_Algoritmo_3
{
    partial class FrmOperaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAbrirFrmVendedores = new System.Windows.Forms.Button();
            this.btnAbrirFrmClientes = new System.Windows.Forms.Button();
            this.btnAbrirfrmProductos1 = new System.Windows.Forms.Button();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.txtSumaFija = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxIVA = new System.Windows.Forms.CheckBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.sape = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(127, 66);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(121, 21);
            this.cmbVendedores.TabIndex = 0;
            this.cmbVendedores.SelectedIndexChanged += new System.EventHandler(this.cmbVendedores_SelectedIndexChanged);
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(127, 112);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 1;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(127, 157);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 21);
            this.cmbProductos.TabIndex = 2;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnAbrirFrmVendedores
            // 
            this.btnAbrirFrmVendedores.Location = new System.Drawing.Point(273, 64);
            this.btnAbrirFrmVendedores.Name = "btnAbrirFrmVendedores";
            this.btnAbrirFrmVendedores.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirFrmVendedores.TabIndex = 4;
            this.btnAbrirFrmVendedores.Text = "+";
            this.btnAbrirFrmVendedores.UseVisualStyleBackColor = true;
            this.btnAbrirFrmVendedores.Click += new System.EventHandler(this.btnAbrirFrmVendedores_Click);
            // 
            // btnAbrirFrmClientes
            // 
            this.btnAbrirFrmClientes.Location = new System.Drawing.Point(273, 110);
            this.btnAbrirFrmClientes.Name = "btnAbrirFrmClientes";
            this.btnAbrirFrmClientes.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirFrmClientes.TabIndex = 5;
            this.btnAbrirFrmClientes.Text = "+";
            this.btnAbrirFrmClientes.UseVisualStyleBackColor = true;
            this.btnAbrirFrmClientes.Click += new System.EventHandler(this.btnAbrirFrmClientes_Click);
            // 
            // btnAbrirfrmProductos1
            // 
            this.btnAbrirfrmProductos1.Location = new System.Drawing.Point(273, 157);
            this.btnAbrirfrmProductos1.Name = "btnAbrirfrmProductos1";
            this.btnAbrirfrmProductos1.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirfrmProductos1.TabIndex = 6;
            this.btnAbrirfrmProductos1.Text = "+";
            this.btnAbrirfrmProductos1.UseVisualStyleBackColor = true;
            this.btnAbrirfrmProductos1.Click += new System.EventHandler(this.btnAbrirfrmProductos1_Click);
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(127, 203);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(120, 20);
            this.nupCantidad.TabIndex = 7;
            // 
            // dtgVentas
            // 
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Location = new System.Drawing.Point(107, 253);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.Size = new System.Drawing.Size(515, 100);
            this.dtgVentas.TabIndex = 8;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(488, 224);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(134, 23);
            this.btnAgregarVenta.TabIndex = 9;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // txtSumaFija
            // 
            this.txtSumaFija.Location = new System.Drawing.Point(148, 394);
            this.txtSumaFija.Name = "txtSumaFija";
            this.txtSumaFija.Size = new System.Drawing.Size(100, 20);
            this.txtSumaFija.TabIndex = 10;
            this.txtSumaFija.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSumaFija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSumaFija_KeyPress);
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(147, 446);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje.TabIndex = 11;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(519, 526);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(433, 397);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Subt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "IVA%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Gan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "IVA";
            // 
            // checkBoxIVA
            // 
            this.checkBoxIVA.AutoSize = true;
            this.checkBoxIVA.Location = new System.Drawing.Point(18, 396);
            this.checkBoxIVA.Name = "checkBoxIVA";
            this.checkBoxIVA.Size = new System.Drawing.Size(75, 17);
            this.checkBoxIVA.TabIndex = 26;
            this.checkBoxIVA.Text = "Aplicable?";
            this.checkBoxIVA.UseVisualStyleBackColor = true;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(469, 158);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 27;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // sape
            // 
            this.sape.AutoSize = true;
            this.sape.Location = new System.Drawing.Point(391, 160);
            this.sape.Name = "sape";
            this.sape.Size = new System.Drawing.Size(66, 13);
            this.sape.TabIndex = 28;
            this.sape.Text = "Costo actual";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtotal.Location = new System.Drawing.Point(516, 396);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(28, 13);
            this.lblSubtotal.TabIndex = 29;
            this.lblSubtotal.Text = ".......";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIva.Location = new System.Drawing.Point(510, 436);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(34, 13);
            this.lblIva.TabIndex = 30;
            this.lblIva.Text = ".........";
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(408, 50);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(259, 83);
            this.dtgProductos.TabIndex = 31;
            // 
            // FrmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 576);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.sape);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.checkBoxIVA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtSumaFija);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.dtgVentas);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.btnAbrirfrmProductos1);
            this.Controls.Add(this.btnAbrirFrmClientes);
            this.Controls.Add(this.btnAbrirFrmVendedores);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.cmbVendedores);
            this.Name = "FrmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla De Operaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOperaciones_FormClosing);
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAbrirFrmVendedores;
        private System.Windows.Forms.Button btnAbrirFrmClientes;
        private System.Windows.Forms.Button btnAbrirfrmProductos1;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.DataGridView dtgVentas;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.TextBox txtSumaFija;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxIVA;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label sape;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.DataGridView dtgProductos;
    }
}