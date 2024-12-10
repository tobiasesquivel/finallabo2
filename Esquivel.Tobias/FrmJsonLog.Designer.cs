namespace Esquivel.Tobias
{
    partial class FrmJsonLog
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
            txtUsuariosLog = new TextBox();
            SuspendLayout();
            // 
            // txtUsuariosLog
            // 
            txtUsuariosLog.Font = new Font("Segoe UI", 12F);
            txtUsuariosLog.Location = new Point(12, 35);
            txtUsuariosLog.Multiline = true;
            txtUsuariosLog.Name = "txtUsuariosLog";
            txtUsuariosLog.Size = new Size(776, 403);
            txtUsuariosLog.TabIndex = 0;
            // 
            // FrmJsonLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsuariosLog);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmJsonLog";
            Text = "FrmJsonLog";
            Load += FrmJsonLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuariosLog;
    }
}