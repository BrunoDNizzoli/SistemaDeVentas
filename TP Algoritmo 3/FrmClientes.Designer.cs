namespace TP_Algoritmo_3
{
    partial class FrmClientes
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btn_agregarCliente = new System.Windows.Forms.Button();
            this.btn_eliminarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Razon social del Cliente :";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(222, 55);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(333, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(44, 100);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(511, 95);
            this.lstClientes.TabIndex = 2;
            // 
            // btn_agregarCliente
            // 
            this.btn_agregarCliente.Location = new System.Drawing.Point(44, 217);
            this.btn_agregarCliente.Name = "btn_agregarCliente";
            this.btn_agregarCliente.Size = new System.Drawing.Size(117, 40);
            this.btn_agregarCliente.TabIndex = 3;
            this.btn_agregarCliente.Text = "Agregar Cliente +";
            this.btn_agregarCliente.UseVisualStyleBackColor = true;
            this.btn_agregarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eliminarCliente
            // 
            this.btn_eliminarCliente.Location = new System.Drawing.Point(439, 217);
            this.btn_eliminarCliente.Name = "btn_eliminarCliente";
            this.btn_eliminarCliente.Size = new System.Drawing.Size(116, 40);
            this.btn_eliminarCliente.TabIndex = 4;
            this.btn_eliminarCliente.Text = "Eliminar cliente ";
            this.btn_eliminarCliente.UseVisualStyleBackColor = true;
            this.btn_eliminarCliente.Click += new System.EventHandler(this.btn_eliminarCliente_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 291);
            this.Controls.Add(this.btn_eliminarCliente);
            this.Controls.Add(this.btn_agregarCliente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClientes_FormClosing);
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btn_agregarCliente;
        private System.Windows.Forms.Button btn_eliminarCliente;
    }
}