namespace Esquivel.Tobias
{
    partial class FrmListado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgListado = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colClave = new DataGridViewTextBoxColumn();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListado).BeginInit();
            SuspendLayout();
            // 
            // dgListado
            // 
            dgListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListado.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellido, colDni, colCorreo, colClave });
            dgListado.Location = new Point(12, 12);
            dgListado.Name = "dgListado";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgListado.Size = new Size(776, 333);
            dgListado.TabIndex = 0;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            // 
            // colDni
            // 
            colDni.HeaderText = "Dni";
            colDni.Name = "colDni";
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.Name = "colCorreo";
            // 
            // colClave
            // 
            colClave.HeaderText = "Clave";
            colClave.Name = "colClave";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 368);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(162, 54);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(317, 368);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(162, 54);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(626, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 54);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(dgListado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListado";
            Text = "FrmListado";
            Load += FrmListado_Load;
            ((System.ComponentModel.ISupportInitialize)dgListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgListado;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colClave;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnEliminar;
    }
}