namespace Perfumeria2._0
{
    partial class frmPantallaEmpleados
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
            btnPerfilAdmin = new Button();
            btnPerfilEncargado = new Button();
            btnPerfilVendedor = new Button();
            btnPerfilGerente = new Button();
            btnPerfilVolverLogin = new Button();
            btnPerfilSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(48, 27);
            label1.Name = "label1";
            label1.Size = new Size(708, 30);
            label1.TabIndex = 0;
            label1.Text = "Has iniciado sesion correctamente, elige el perfil que te corresponde";
            // 
            // btnPerfilAdmin
            // 
            btnPerfilAdmin.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfilAdmin.Location = new Point(237, 99);
            btnPerfilAdmin.Name = "btnPerfilAdmin";
            btnPerfilAdmin.Size = new Size(324, 35);
            btnPerfilAdmin.TabIndex = 1;
            btnPerfilAdmin.Text = "Administrador de sistemas";
            btnPerfilAdmin.UseVisualStyleBackColor = true;
            btnPerfilAdmin.Click += btnPerfilAdmin_Click;
            // 
            // btnPerfilEncargado
            // 
            btnPerfilEncargado.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfilEncargado.Location = new Point(237, 340);
            btnPerfilEncargado.Name = "btnPerfilEncargado";
            btnPerfilEncargado.Size = new Size(324, 35);
            btnPerfilEncargado.TabIndex = 2;
            btnPerfilEncargado.Text = "Encargado de Stock";
            btnPerfilEncargado.UseVisualStyleBackColor = true;
            // 
            // btnPerfilVendedor
            // 
            btnPerfilVendedor.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfilVendedor.Location = new Point(237, 265);
            btnPerfilVendedor.Name = "btnPerfilVendedor";
            btnPerfilVendedor.Size = new Size(324, 35);
            btnPerfilVendedor.TabIndex = 3;
            btnPerfilVendedor.Text = "Vendedor";
            btnPerfilVendedor.UseVisualStyleBackColor = true;
            // 
            // btnPerfilGerente
            // 
            btnPerfilGerente.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfilGerente.Location = new Point(237, 182);
            btnPerfilGerente.Name = "btnPerfilGerente";
            btnPerfilGerente.Size = new Size(324, 35);
            btnPerfilGerente.TabIndex = 4;
            btnPerfilGerente.Text = "Gerente";
            btnPerfilGerente.UseVisualStyleBackColor = true;
            // 
            // btnPerfilVolverLogin
            // 
            btnPerfilVolverLogin.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfilVolverLogin.Location = new Point(662, 350);
            btnPerfilVolverLogin.Name = "btnPerfilVolverLogin";
            btnPerfilVolverLogin.Size = new Size(98, 47);
            btnPerfilVolverLogin.TabIndex = 5;
            btnPerfilVolverLogin.Text = "Volver al Login";
            btnPerfilVolverLogin.UseVisualStyleBackColor = true;
            // 
            // btnPerfilSalir
            // 
            btnPerfilSalir.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btnPerfilSalir.ForeColor = Color.Red;
            btnPerfilSalir.Location = new Point(662, 403);
            btnPerfilSalir.Name = "btnPerfilSalir";
            btnPerfilSalir.Size = new Size(98, 36);
            btnPerfilSalir.TabIndex = 6;
            btnPerfilSalir.Text = "Salir";
            btnPerfilSalir.UseVisualStyleBackColor = true;
            btnPerfilSalir.Click += btnPerfilSalir_Click;
            // 
            // frmPantallaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPerfilSalir);
            Controls.Add(btnPerfilVolverLogin);
            Controls.Add(btnPerfilGerente);
            Controls.Add(btnPerfilVendedor);
            Controls.Add(btnPerfilEncargado);
            Controls.Add(btnPerfilAdmin);
            Controls.Add(label1);
            Name = "frmPantallaEmpleados";
            Text = "frmPantallaEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPerfilAdmin;
        private Button btnPerfilEncargado;
        private Button btnPerfilVendedor;
        private Button btnPerfilGerente;
        private Button btnPerfilVolverLogin;
        private Button btnPerfilSalir;
    }
}