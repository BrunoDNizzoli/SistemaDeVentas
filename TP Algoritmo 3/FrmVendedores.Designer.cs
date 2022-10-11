namespace TP_Algoritmo_3
{
    partial class FrmVendedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstVendedores = new System.Windows.Forms.ListBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.btn_agregarVendedor = new System.Windows.Forms.Button();
            this.btn_eliminarVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregue al vendedor :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstVendedores
            // 
            this.lstVendedores.FormattingEnabled = true;
            this.lstVendedores.Location = new System.Drawing.Point(41, 89);
            this.lstVendedores.Name = "lstVendedores";
            this.lstVendedores.Size = new System.Drawing.Size(488, 108);
            this.lstVendedores.TabIndex = 1;
            this.lstVendedores.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(156, 44);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(373, 20);
            this.txtVendedor.TabIndex = 2;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            this.txtVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedor_KeyPress);
            // 
            // btn_agregarVendedor
            // 
            this.btn_agregarVendedor.Location = new System.Drawing.Point(45, 216);
            this.btn_agregarVendedor.Name = "btn_agregarVendedor";
            this.btn_agregarVendedor.Size = new System.Drawing.Size(247, 56);
            this.btn_agregarVendedor.TabIndex = 3;
            this.btn_agregarVendedor.Text = "Agregar Vendedor";
            this.btn_agregarVendedor.UseVisualStyleBackColor = true;
            this.btn_agregarVendedor.Click += new System.EventHandler(this.btn_agregarVendedor_Click);
            // 
            // btn_eliminarVendedor
            // 
            this.btn_eliminarVendedor.Location = new System.Drawing.Point(298, 216);
            this.btn_eliminarVendedor.Name = "btn_eliminarVendedor";
            this.btn_eliminarVendedor.Size = new System.Drawing.Size(231, 56);
            this.btn_eliminarVendedor.TabIndex = 4;
            this.btn_eliminarVendedor.Text = "Eliminar Vendedor";
            this.btn_eliminarVendedor.UseVisualStyleBackColor = true;
            this.btn_eliminarVendedor.Click += new System.EventHandler(this.btn_eliminarVendedor_Click);
            // 
            // FrmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 326);
            this.Controls.Add(this.btn_eliminarVendedor);
            this.Controls.Add(this.btn_agregarVendedor);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lstVendedores);
            this.Controls.Add(this.label1);
            this.Name = "FrmVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla De Vendedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVendedores_FormClosing);
            this.Load += new System.EventHandler(this.FrmVendedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstVendedores;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Button btn_agregarVendedor;
        private System.Windows.Forms.Button btn_eliminarVendedor;
    }
}