namespace Esquivel.Tobias
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            toolStrip1 = new ToolStrip();
            TSBtnUsuarios = new ToolStripSplitButton();
            TSMIListadoCrud = new ToolStripMenuItem();
            TSMIVerLog = new ToolStripMenuItem();
            TSMIDeserializarJSON = new ToolStripMenuItem();
            TSMITask = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TSBtnUsuarios });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TSBtnUsuarios
            // 
            TSBtnUsuarios.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSBtnUsuarios.DropDownItems.AddRange(new ToolStripItem[] { TSMIListadoCrud, TSMIVerLog, TSMIDeserializarJSON, TSMITask });
            TSBtnUsuarios.Image = (Image)resources.GetObject("TSBtnUsuarios.Image");
            TSBtnUsuarios.ImageTransparentColor = Color.Magenta;
            TSBtnUsuarios.Name = "TSBtnUsuarios";
            TSBtnUsuarios.Size = new Size(68, 22);
            TSBtnUsuarios.Text = "Usuarios";
            // 
            // TSMIListadoCrud
            // 
            TSMIListadoCrud.Name = "TSMIListadoCrud";
            TSMIListadoCrud.Size = new Size(181, 22);
            TSMIListadoCrud.Text = "1.- Listado CRUD";
            TSMIListadoCrud.Click += TSMIListadoCrud_Click;
            // 
            // TSMIVerLog
            // 
            TSMIVerLog.Name = "TSMIVerLog";
            TSMIVerLog.Size = new Size(181, 22);
            TSMIVerLog.Text = "2.- Ver log";
            TSMIVerLog.Click += TSMIVerLog_Click;
            // 
            // TSMIDeserializarJSON
            // 
            TSMIDeserializarJSON.Name = "TSMIDeserializarJSON";
            TSMIDeserializarJSON.Size = new Size(181, 22);
            TSMIDeserializarJSON.Text = "3.- Deserializar JSON";
            TSMIDeserializarJSON.Click += TSMIDeserializarJSON_Click;
            // 
            // TSMITask
            // 
            TSMITask.Name = "TSMITask";
            TSMITask.Size = new Size(181, 22);
            TSMITask.Text = "4.- Task";
            TSMITask.Click += TSMITask_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripSplitButton TSBtnUsuarios;
        private ToolStripMenuItem TSMIListadoCrud;
        private ToolStripMenuItem TSMIVerLog;
        private ToolStripMenuItem TSMIDeserializarJSON;
        private ToolStripMenuItem TSMITask;
    }
}