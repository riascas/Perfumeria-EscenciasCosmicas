namespace Perfumeria2._0
{
    partial class frmControlEncargado
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
            btnSalirEncargado = new Button();
            btnVolverLoginEncargado = new Button();
            btnNuevoProducto = new Button();
            btnListadoProductos = new Button();
            btnModificarProductos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(142, 45);
            label1.Name = "label1";
            label1.Size = new Size(435, 31);
            label1.TabIndex = 0;
            label1.Text = "Pantalla Principal Encargado de Stock";
            // 
            // btnSalirEncargado
            // 
            btnSalirEncargado.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirEncargado.ForeColor = Color.Red;
            btnSalirEncargado.Location = new Point(687, 398);
            btnSalirEncargado.Name = "btnSalirEncargado";
            btnSalirEncargado.Size = new Size(91, 40);
            btnSalirEncargado.TabIndex = 1;
            btnSalirEncargado.Text = "Salir";
            btnSalirEncargado.UseVisualStyleBackColor = true;
            btnSalirEncargado.Click += button1_Click;
            // 
            // btnVolverLoginEncargado
            // 
            btnVolverLoginEncargado.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverLoginEncargado.Location = new Point(689, 334);
            btnVolverLoginEncargado.Name = "btnVolverLoginEncargado";
            btnVolverLoginEncargado.Size = new Size(89, 58);
            btnVolverLoginEncargado.TabIndex = 4;
            btnVolverLoginEncargado.Text = "Volver a Login";
            btnVolverLoginEncargado.UseVisualStyleBackColor = true;
            btnVolverLoginEncargado.Click += btnVolverLoginEncargado_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoProducto.Location = new Point(100, 154);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(145, 91);
            btnNuevoProducto.TabIndex = 5;
            btnNuevoProducto.Text = "Cargar \"Nuevo Producto\"";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnListadoProductos
            // 
            btnListadoProductos.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnListadoProductos.Location = new Point(326, 154);
            btnListadoProductos.Name = "btnListadoProductos";
            btnListadoProductos.Size = new Size(145, 91);
            btnListadoProductos.TabIndex = 6;
            btnListadoProductos.Text = "Control de Productos";
            btnListadoProductos.UseVisualStyleBackColor = true;
            // 
            // btnModificarProductos
            // 
            btnModificarProductos.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarProductos.Location = new Point(560, 154);
            btnModificarProductos.Name = "btnModificarProductos";
            btnModificarProductos.Size = new Size(145, 91);
            btnModificarProductos.TabIndex = 7;
            btnModificarProductos.Text = "Modificar stock / productos";
            btnModificarProductos.UseVisualStyleBackColor = true;
            // 
            // frmControlEncargado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarProductos);
            Controls.Add(btnListadoProductos);
            Controls.Add(btnNuevoProducto);
            Controls.Add(btnVolverLoginEncargado);
            Controls.Add(btnSalirEncargado);
            Controls.Add(label1);
            Name = "frmControlEncargado";
            Text = "frmControlEncargado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalirEncargado;
        private Button btnVolverLoginEncargado;
        private Button btnNuevoProducto;
        private Button btnListadoProductos;
        private Button btnModificarProductos;
    }
}