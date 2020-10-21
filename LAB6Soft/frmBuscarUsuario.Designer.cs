namespace LAB6Soft {
    partial class frmBuscarUsuario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblBuscarUser = new System.Windows.Forms.Label();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.btnSeleccionarUser = new System.Windows.Forms.Button();
            this.dgvBuscarUser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarUser
            // 
            this.lblBuscarUser.AutoSize = true;
            this.lblBuscarUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUser.Location = new System.Drawing.Point(14, 46);
            this.lblBuscarUser.Name = "lblBuscarUser";
            this.lblBuscarUser.Size = new System.Drawing.Size(239, 21);
            this.lblBuscarUser.TabIndex = 0;
            this.lblBuscarUser.Text = "Buscar (nombre o apellido):";
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUser.Location = new System.Drawing.Point(259, 43);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(297, 28);
            this.txtBuscarUser.TabIndex = 1;
            // 
            // btnSeleccionarUser
            // 
            this.btnSeleccionarUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarUser.Location = new System.Drawing.Point(579, 43);
            this.btnSeleccionarUser.Name = "btnSeleccionarUser";
            this.btnSeleccionarUser.Size = new System.Drawing.Size(120, 28);
            this.btnSeleccionarUser.TabIndex = 2;
            this.btnSeleccionarUser.Text = "Seleccionar";
            this.btnSeleccionarUser.UseVisualStyleBackColor = true;
            // 
            // dgvBuscarUser
            // 
            this.dgvBuscarUser.AllowUserToAddRows = false;
            this.dgvBuscarUser.AllowUserToDeleteRows = false;
            this.dgvBuscarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombres,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.DNI,
            this.Area,
            this.Rol});
            this.dgvBuscarUser.Location = new System.Drawing.Point(18, 103);
            this.dgvBuscarUser.Name = "dgvBuscarUser";
            this.dgvBuscarUser.ReadOnly = true;
            this.dgvBuscarUser.RowHeadersWidth = 51;
            this.dgvBuscarUser.RowTemplate.Height = 24;
            this.dgvBuscarUser.Size = new System.Drawing.Size(681, 362);
            this.dgvBuscarUser.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 145;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.MinimumWidth = 6;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            this.ApellidoPaterno.Width = 115;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido Materno";
            this.ApellidoMaterno.MinimumWidth = 6;
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            this.ApellidoMaterno.Width = 115;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 85;
            // 
            // Area
            // 
            this.Area.HeaderText = "Área";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 75;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 65;
            // 
            // frmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 491);
            this.Controls.Add(this.dgvBuscarUser);
            this.Controls.Add(this.btnSeleccionarUser);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.lblBuscarUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarUsuario";
            this.Text = "Formulario para Buscar un Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarUser;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.Button btnSeleccionarUser;
        private System.Windows.Forms.DataGridView dgvBuscarUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}