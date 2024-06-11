namespace Perfumeria2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSalir = new Button();
            btnIniciarSesion = new Button();
            tboxUsuario = new TextBox();
            tboxClave = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 51);
            label1.Name = "label1";
            label1.Size = new Size(240, 52);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 137);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(172, 214);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Clave:";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(639, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(79, 38);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.Blue;
            btnIniciarSesion.Location = new Point(570, 160);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(148, 53);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // tboxUsuario
            // 
            tboxUsuario.Location = new Point(264, 140);
            tboxUsuario.Name = "tboxUsuario";
            tboxUsuario.Size = new Size(217, 23);
            tboxUsuario.TabIndex = 5;
            // 
            // tboxClave
            // 
            tboxClave.Location = new Point(264, 212);
            tboxClave.Name = "tboxClave";
            tboxClave.PasswordChar = '#';
            tboxClave.Size = new Size(217, 23);
            tboxClave.TabIndex = 6;
            tboxClave.TextChanged += tboxClave_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tboxClave);
            Controls.Add(tboxUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnSalir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalir;
        private Button btnIniciarSesion;
        private TextBox tboxUsuario;
        private TextBox tboxClave;
    }
}
