namespace Perfumeria2._0
{
    partial class frmControlGerente
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
            btnReporteGerencia = new Button();
            btnSalirGerencia = new Button();
            btnVolverLoginGerencia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(251, 38);
            label1.Name = "label1";
            label1.Size = new Size(317, 31);
            label1.TabIndex = 0;
            label1.Text = "Pantalla Principal Gerencia";
            // 
            // btnReporteGerencia
            // 
            btnReporteGerencia.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporteGerencia.Location = new Point(334, 179);
            btnReporteGerencia.Name = "btnReporteGerencia";
            btnReporteGerencia.Size = new Size(150, 98);
            btnReporteGerencia.TabIndex = 1;
            btnReporteGerencia.Text = "Armar Reportes";
            btnReporteGerencia.UseVisualStyleBackColor = true;
            // 
            // btnSalirGerencia
            // 
            btnSalirGerencia.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalirGerencia.ForeColor = Color.Red;
            btnSalirGerencia.Location = new Point(683, 413);
            btnSalirGerencia.Name = "btnSalirGerencia";
            btnSalirGerencia.Size = new Size(89, 31);
            btnSalirGerencia.TabIndex = 2;
            btnSalirGerencia.Text = "Salir";
            btnSalirGerencia.UseVisualStyleBackColor = true;
            btnSalirGerencia.Click += btnSalirGerencia_Click;
            // 
            // btnVolverLoginGerencia
            // 
            btnVolverLoginGerencia.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverLoginGerencia.Location = new Point(683, 349);
            btnVolverLoginGerencia.Name = "btnVolverLoginGerencia";
            btnVolverLoginGerencia.Size = new Size(89, 58);
            btnVolverLoginGerencia.TabIndex = 3;
            btnVolverLoginGerencia.Text = "Volver a Login";
            btnVolverLoginGerencia.UseVisualStyleBackColor = true;
            btnVolverLoginGerencia.Click += btnVolverLoginGerencia_Click;
            // 
            // frmControlGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverLoginGerencia);
            Controls.Add(btnSalirGerencia);
            Controls.Add(btnReporteGerencia);
            Controls.Add(label1);
            Name = "frmControlGerente";
            Text = "frmControlGerente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReporteGerencia;
        private Button btnSalirGerencia;
        private Button btnVolverLoginGerencia;
    }
}