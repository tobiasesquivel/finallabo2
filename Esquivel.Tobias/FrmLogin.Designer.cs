﻿namespace Esquivel.Tobias
{
    partial class FrmLogin
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
            lblCorreo = new Label();
            lblClave = new Label();
            txtCorreo = new TextBox();
            txtClave = new TextBox();
            btnEnviar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 15F);
            lblCorreo.Location = new Point(27, 80);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(174, 28);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo electronico";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 15F);
            lblClave.Location = new Point(27, 202);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(110, 28);
            lblClave.TabIndex = 1;
            lblClave.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(27, 129);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(290, 23);
            txtCorreo.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(27, 252);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(290, 23);
            txtClave.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 15F);
            btnEnviar.Location = new Point(27, 336);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(127, 54);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 15F);
            btnCerrar.Location = new Point(190, 336);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(127, 54);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnEnviar);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(lblClave);
            Controls.Add(lblCorreo);
            Name = "FrmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreo;
        private Label lblClave;
        private TextBox txtCorreo;
        private TextBox txtClave;
        private Button btnEnviar;
        private Button btnCerrar;
    }
}
