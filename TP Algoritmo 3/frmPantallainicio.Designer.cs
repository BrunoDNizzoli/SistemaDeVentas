namespace TP_Algoritmo_3
{
    partial class frmPantallainicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_abrirClientes = new System.Windows.Forms.Button();
            this.btn_abrirVendedores = new System.Windows.Forms.Button();
            this.btn_abrirProductos = new System.Windows.Forms.Button();
            this.btn_abrirOperaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_abrirClientes
            // 
            this.btn_abrirClientes.Location = new System.Drawing.Point(55, 118);
            this.btn_abrirClientes.Name = "btn_abrirClientes";
            this.btn_abrirClientes.Size = new System.Drawing.Size(152, 86);
            this.btn_abrirClientes.TabIndex = 0;
            this.btn_abrirClientes.Text = "Clientes";
            this.btn_abrirClientes.UseVisualStyleBackColor = true;
            this.btn_abrirClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_abrirVendedores
            // 
            this.btn_abrirVendedores.Location = new System.Drawing.Point(254, 249);
            this.btn_abrirVendedores.Name = "btn_abrirVendedores";
            this.btn_abrirVendedores.Size = new System.Drawing.Size(152, 86);
            this.btn_abrirVendedores.TabIndex = 1;
            this.btn_abrirVendedores.Text = "Vendedores";
            this.btn_abrirVendedores.UseVisualStyleBackColor = true;
            this.btn_abrirVendedores.Click += new System.EventHandler(this.btn_abrirVendedores_Click);
            // 
            // btn_abrirProductos
            // 
            this.btn_abrirProductos.Location = new System.Drawing.Point(254, 118);
            this.btn_abrirProductos.Name = "btn_abrirProductos";
            this.btn_abrirProductos.Size = new System.Drawing.Size(152, 86);
            this.btn_abrirProductos.TabIndex = 2;
            this.btn_abrirProductos.Text = "Productos";
            this.btn_abrirProductos.UseVisualStyleBackColor = true;
            this.btn_abrirProductos.Click += new System.EventHandler(this.btn_abrirProductos_Click);
            // 
            // btn_abrirOperaciones
            // 
            this.btn_abrirOperaciones.Location = new System.Drawing.Point(55, 249);
            this.btn_abrirOperaciones.Name = "btn_abrirOperaciones";
            this.btn_abrirOperaciones.Size = new System.Drawing.Size(152, 86);
            this.btn_abrirOperaciones.TabIndex = 3;
            this.btn_abrirOperaciones.Text = "Operaciones";
            this.btn_abrirOperaciones.UseVisualStyleBackColor = true;
            this.btn_abrirOperaciones.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "!Bienvenido al sistema! escoge una opcion";
            // 
            // frmPantallainicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_abrirOperaciones);
            this.Controls.Add(this.btn_abrirProductos);
            this.Controls.Add(this.btn_abrirVendedores);
            this.Controls.Add(this.btn_abrirClientes);
            this.Name = "frmPantallainicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla De Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPantallainicio_FormClosing);
            this.Load += new System.EventHandler(this.frmPantallainicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_abrirClientes;
        private System.Windows.Forms.Button btn_abrirVendedores;
        private System.Windows.Forms.Button btn_abrirProductos;
        private System.Windows.Forms.Button btn_abrirOperaciones;
        private System.Windows.Forms.Label label1;
    }
}

