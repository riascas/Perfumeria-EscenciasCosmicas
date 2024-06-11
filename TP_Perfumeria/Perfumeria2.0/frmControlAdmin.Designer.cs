namespace Perfumeria2._0
{
    partial class frmControlAdmin
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
            btnAltaEmpleado = new Button();
            btnBajaEmpleado = new Button();
            btnSalirAdmin = new Button();
            btnVolverLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 57);
            label1.Name = "label1";
            label1.Size = new Size(624, 27);
            label1.TabIndex = 0;
            label1.Text = "Control de Administrador de Sistemas";
            // 
            // btnAltaEmpleado
            // 
            btnAltaEmpleado.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAltaEmpleado.Location = new Point(214, 193);
            btnAltaEmpleado.Name = "btnAltaEmpleado";
            btnAltaEmpleado.Size = new Size(125, 74);
            btnAltaEmpleado.TabIndex = 1;
            btnAltaEmpleado.Text = "Alta de Empleado";
            btnAltaEmpleado.UseVisualStyleBackColor = true;
            btnAltaEmpleado.Click += btnAltaEmpleado_Click;
            // 
            // btnBajaEmpleado
            // 
            btnBajaEmpleado.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBajaEmpleado.Location = new Point(468, 193);
            btnBajaEmpleado.Name = "btnBajaEmpleado";
            btnBajaEmpleado.Size = new Size(125, 74);
            btnBajaEmpleado.TabIndex = 2;
            btnBajaEmpleado.Text = "Baja de Empleado";
            btnBajaEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnSalirAdmin
            // 
            btnSalirAdmin.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirAdmin.ForeColor = Color.Red;
            btnSalirAdmin.Location = new Point(667, 402);
            btnSalirAdmin.Name = "btnSalirAdmin";
            btnSalirAdmin.Size = new Size(91, 36);
            btnSalirAdmin.TabIndex = 3;
            btnSalirAdmin.Text = "Salir";
            btnSalirAdmin.UseVisualStyleBackColor = true;
            btnSalirAdmin.Click += btnSalirAdmin_Click;
            // 
            // btnVolverLogin
            // 
            btnVolverLogin.Font = new Font("Lucida Console", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverLogin.Location = new Point(667, 341);
            btnVolverLogin.Name = "btnVolverLogin";
            btnVolverLogin.Size = new Size(91, 45);
            btnVolverLogin.TabIndex = 4;
            btnVolverLogin.Text = "Volver al Login";
            btnVolverLogin.UseVisualStyleBackColor = true;
            btnVolverLogin.Click += btnVolverLogin_Click;
            // 
            // frmControlAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverLogin);
            Controls.Add(btnSalirAdmin);
            Controls.Add(btnBajaEmpleado);
            Controls.Add(btnAltaEmpleado);
            Controls.Add(label1);
            Name = "frmControlAdmin";
            Text = "frmControlAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAltaEmpleado;
        private Button btnBajaEmpleado;
        private Button btnSalirAdmin;
        private Button btnVolverLogin;
    }
}