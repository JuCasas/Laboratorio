namespace LAB6Soft {
    partial class frmBuscarProveedor {
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
            this.dgvBuscarProv = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarProv = new System.Windows.Forms.Button();
            this.txtBuscarProv = new System.Windows.Forms.TextBox();
            this.lblBuscarProv = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarProv
            // 
            this.dgvBuscarProv.AllowUserToAddRows = false;
            this.dgvBuscarProv.AllowUserToDeleteRows = false;
            this.dgvBuscarProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombres,
            this.ApellidoPaterno,
            this.Rol,
            this.Area});
            this.dgvBuscarProv.Location = new System.Drawing.Point(23, 94);
            this.dgvBuscarProv.Name = "dgvBuscarProv";
            this.dgvBuscarProv.ReadOnly = true;
            this.dgvBuscarProv.RowHeadersWidth = 51;
            this.dgvBuscarProv.RowTemplate.Height = 24;
            this.dgvBuscarProv.Size = new System.Drawing.Size(681, 362);
            this.dgvBuscarProv.TabIndex = 7;
            // 
            // btnSeleccionarProv
            // 
            this.btnSeleccionarProv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProv.Location = new System.Drawing.Point(584, 35);
            this.btnSeleccionarProv.Name = "btnSeleccionarProv";
            this.btnSeleccionarProv.Size = new System.Drawing.Size(120, 28);
            this.btnSeleccionarProv.TabIndex = 6;
            this.btnSeleccionarProv.Text = "Seleccionar";
            this.btnSeleccionarProv.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProv
            // 
            this.txtBuscarProv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProv.Location = new System.Drawing.Point(159, 35);
            this.txtBuscarProv.Name = "txtBuscarProv";
            this.txtBuscarProv.Size = new System.Drawing.Size(297, 28);
            this.txtBuscarProv.TabIndex = 5;
            // 
            // lblBuscarProv
            // 
            this.lblBuscarProv.AutoSize = true;
            this.lblBuscarProv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProv.Location = new System.Drawing.Point(19, 38);
            this.lblBuscarProv.Name = "lblBuscarProv";
            this.lblBuscarProv.Size = new System.Drawing.Size(123, 21);
            this.lblBuscarProv.TabIndex = 4;
            this.lblBuscarProv.Text = "Buscar (RUC):";
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
            this.Nombres.HeaderText = "Razón Social";
            this.Nombres.MinimumWidth = 6;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 200;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "RUC";
            this.ApellidoPaterno.MinimumWidth = 6;
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            this.ApellidoPaterno.Width = 120;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Dirección";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 200;
            // 
            // Area
            // 
            this.Area.HeaderText = "Detracción";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            this.Area.Width = 80;
            // 
            // frmBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 491);
            this.Controls.Add(this.dgvBuscarProv);
            this.Controls.Add(this.btnSeleccionarProv);
            this.Controls.Add(this.txtBuscarProv);
            this.Controls.Add(this.lblBuscarProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarProveedor";
            this.Text = "Formulario para Buscar un Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarProv;
        private System.Windows.Forms.Button btnSeleccionarProv;
        private System.Windows.Forms.TextBox txtBuscarProv;
        private System.Windows.Forms.Label lblBuscarProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
    }
}