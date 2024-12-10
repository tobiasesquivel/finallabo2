namespace Esquivel.Tobias
{
    partial class FrmUsuario
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblCorreoElectronico = new Label();
            txtCorreo = new TextBox();
            lblClave = new Label();
            txtClave = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(12, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(12, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(356, 29);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F);
            lblApellido.Location = new Point(12, 82);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 21);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(12, 106);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(356, 29);
            txtApellido.TabIndex = 4;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F);
            lblDni.Location = new Point(12, 138);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(40, 21);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 12F);
            txtDni.Location = new Point(12, 162);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(356, 29);
            txtDni.TabIndex = 6;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Font = new Font("Segoe UI", 12F);
            lblCorreoElectronico.Location = new Point(12, 241);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(141, 21);
            lblCorreoElectronico.TabIndex = 7;
            lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 12F);
            txtCorreo.Location = new Point(12, 265);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(356, 29);
            txtCorreo.TabIndex = 8;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 12F);
            lblClave.Location = new Point(12, 297);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(89, 21);
            lblClave.TabIndex = 9;
            lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 12F);
            txtClave.Location = new Point(12, 321);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(356, 29);
            txtClave.TabIndex = 10;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 15F);
            btnAceptar.Location = new Point(12, 400);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(127, 54);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 15F);
            btnCancelar.Location = new Point(241, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 54);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 469);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblCorreoElectronico;
        private TextBox txtCorreo;
        private Label lblClave;
        private TextBox txtClave;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}