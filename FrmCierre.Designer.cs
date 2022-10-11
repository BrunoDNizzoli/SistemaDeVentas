namespace TP_Algoritmo_3
{
    partial class FrmCierre
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
            this.btnAbrirVendedores = new System.Windows.Forms.Button();
            this.btnAbrirClientes = new System.Windows.Forms.Button();
            this.btnAbrirProductos = new System.Windows.Forms.Button();
            this.dtgVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirVendedores
            // 
            this.btnAbrirVendedores.Location = new System.Drawing.Point(86, 70);
            this.btnAbrirVendedores.Name = "btnAbrirVendedores";
            this.btnAbrirVendedores.Size = new System.Drawing.Size(74, 52);
            this.btnAbrirVendedores.TabIndex = 0;
            this.btnAbrirVendedores.Text = "Informacion Vendedores";
            this.btnAbrirVendedores.UseVisualStyleBackColor = true;
            this.btnAbrirVendedores.Click += new System.EventHandler(this.btnAbrirVendedores_Click);
            // 
            // btnAbrirClientes
            // 
            this.btnAbrirClientes.Location = new System.Drawing.Point(86, 152);
            this.btnAbrirClientes.Name = "btnAbrirClientes";
            this.btnAbrirClientes.Size = new System.Drawing.Size(75, 57);
            this.btnAbrirClientes.TabIndex = 1;
            this.btnAbrirClientes.Text = "Informacion Clientes";
            this.btnAbrirClientes.UseVisualStyleBackColor = true;
            this.btnAbrirClientes.Click += new System.EventHandler(this.btnAbrirClientes_Click);
            // 
            // btnAbrirProductos
            // 
            this.btnAbrirProductos.Location = new System.Drawing.Point(85, 239);
            this.btnAbrirProductos.Name = "btnAbrirProductos";
            this.btnAbrirProductos.Size = new System.Drawing.Size(75, 56);
            this.btnAbrirProductos.TabIndex = 2;
            this.btnAbrirProductos.Text = "Informacion Productos";
            this.btnAbrirProductos.UseVisualStyleBackColor = true;
            this.btnAbrirProductos.Click += new System.EventHandler(this.btnAbrirProductos_Click);
            // 
            // dtgVentas
            // 
            this.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVentas.Location = new System.Drawing.Point(265, 70);
            this.dtgVentas.Name = "dtgVentas";
            this.dtgVentas.Size = new System.Drawing.Size(476, 225);
            this.dtgVentas.TabIndex = 3;
            // 
            // FrmCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 378);
            this.Controls.Add(this.dtgVentas);
            this.Controls.Add(this.btnAbrirProductos);
            this.Controls.Add(this.btnAbrirClientes);
            this.Controls.Add(this.btnAbrirVendedores);
            this.Name = "FrmCierre";
            this.Text = "FrmCierre";
            this.Load += new System.EventHandler(this.FrmCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirVendedores;
        private System.Windows.Forms.Button btnAbrirClientes;
        private System.Windows.Forms.Button btnAbrirProductos;
        private System.Windows.Forms.DataGridView dtgVentas;
    }
}