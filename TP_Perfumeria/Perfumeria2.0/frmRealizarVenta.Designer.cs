namespace Perfumeria2._0
{
    partial class frmRealizarVenta
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            btnVenta = new Button();
            btnSalirVenta = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(276, 39);
            label1.Name = "label1";
            label1.Size = new Size(227, 35);
            label1.TabIndex = 0;
            label1.Text = "Planilla de Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 107);
            label2.Name = "label2";
            label2.Size = new Size(169, 24);
            label2.TabIndex = 1;
            label2.Text = "Seleccionar Cliente";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 153);
            label3.Name = "label3";
            label3.Size = new Size(186, 24);
            label3.TabIndex = 2;
            label3.Text = "Seleccionar Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 196);
            label4.Name = "label4";
            label4.Size = new Size(202, 24);
            label4.TabIndex = 3;
            label4.Text = "Cantidad de Productos";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(289, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 27);
            textBox1.TabIndex = 4;
            // 
            // btnVenta
            // 
            btnVenta.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.Location = new Point(289, 306);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(120, 54);
            btnVenta.TabIndex = 5;
            btnVenta.Text = "Confirmar Venta";
            btnVenta.UseVisualStyleBackColor = true;
            // 
            // btnSalirVenta
            // 
            btnSalirVenta.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirVenta.ForeColor = Color.Red;
            btnSalirVenta.Location = new Point(652, 403);
            btnSalirVenta.Name = "btnSalirVenta";
            btnSalirVenta.Size = new Size(89, 35);
            btnSalirVenta.TabIndex = 6;
            btnSalirVenta.Text = "Salir";
            btnSalirVenta.UseVisualStyleBackColor = true;
            btnSalirVenta.Click += btnSalirVenta_Click;
            // 
            // frmRealizarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalirVenta);
            Controls.Add(btnVenta);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRealizarVenta";
            Text = "frmRealizarVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button btnVenta;
        private Button btnSalirVenta;
    }
}