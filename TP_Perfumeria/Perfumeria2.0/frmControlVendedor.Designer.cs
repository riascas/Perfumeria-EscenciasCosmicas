namespace Perfumeria2._0
{
    partial class frmControlVendedor
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
            label1 = new Label();
            btnSalirVendedor = new Button();
            btnVolverLoginVendedor = new Button();
            btnRealiarVenta = new Button();
            btnGestionClientes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(220, 47);
            label1.Name = "label1";
            label1.Size = new Size(347, 31);
            label1.TabIndex = 0;
            label1.Text = "Pantalla Principal Vendedores";
            // 
            // btnSalirVendedor
            // 
            btnSalirVendedor.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirVendedor.ForeColor = Color.Red;
            btnSalirVendedor.Location = new Point(699, 403);
            btnSalirVendedor.Name = "btnSalirVendedor";
            btnSalirVendedor.Size = new Size(89, 35);
            btnSalirVendedor.TabIndex = 1;
            btnSalirVendedor.Text = "Salir";
            btnSalirVendedor.UseVisualStyleBackColor = true;
            btnSalirVendedor.Click += button1_Click;
            // 
            // btnVolverLoginVendedor
            // 
            btnVolverLoginVendedor.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverLoginVendedor.Location = new Point(699, 339);
            btnVolverLoginVendedor.Name = "btnVolverLoginVendedor";
            btnVolverLoginVendedor.Size = new Size(89, 58);
            btnVolverLoginVendedor.TabIndex = 4;
            btnVolverLoginVendedor.Text = "Volver a Login";
            btnVolverLoginVendedor.UseVisualStyleBackColor = true;
            btnVolverLoginVendedor.Click += btnVolverLoginVendedor_Click;
            // 
            // btnRealiarVenta
            // 
            btnRealiarVenta.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRealiarVenta.Location = new Point(193, 184);
            btnRealiarVenta.Name = "btnRealiarVenta";
            btnRealiarVenta.Size = new Size(125, 98);
            btnRealiarVenta.TabIndex = 5;
            btnRealiarVenta.Text = "Realizar Venta";
            btnRealiarVenta.UseVisualStyleBackColor = true;
            btnRealiarVenta.Click += btnRealiarVenta_Click;
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionClientes.Location = new Point(478, 184);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(125, 98);
            btnGestionClientes.TabIndex = 6;
            btnGestionClientes.Text = "Gestion de Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            // 
            // frmControlVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionClientes);
            Controls.Add(btnRealiarVenta);
            Controls.Add(btnVolverLoginVendedor);
            Controls.Add(btnSalirVendedor);
            Controls.Add(label1);
            Name = "frmControlVendedor";
            Text = "frmControlVendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalirVendedor;
        private Button btnVolverLoginVendedor;
        private Button btnRealiarVenta;
        private Button btnGestionClientes;
    }
}