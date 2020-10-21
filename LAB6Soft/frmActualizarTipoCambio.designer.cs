namespace formsLab6 {
    partial class frmActualizarTipoCambio {
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
            this.gbTableroMonedas = new System.Windows.Forms.GroupBox();
            this.txtEuTab = new System.Windows.Forms.TextBox();
            this.txtDoTab = new System.Windows.Forms.TextBox();
            this.lblSolesEuTab = new System.Windows.Forms.Label();
            this.lblSolesDoTab = new System.Windows.Forms.Label();
            this.lblEuroTab = new System.Windows.Forms.Label();
            this.lblDolarTab = new System.Windows.Forms.Label();
            this.gbTipoCambioSistema = new System.Windows.Forms.GroupBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblSolesEu = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblSolesDo = new System.Windows.Forms.Label();
            this.gbTableroMonedas.SuspendLayout();
            this.gbTipoCambioSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTableroMonedas
            // 
            this.gbTableroMonedas.Controls.Add(this.txtEuTab);
            this.gbTableroMonedas.Controls.Add(this.txtDoTab);
            this.gbTableroMonedas.Controls.Add(this.lblSolesEuTab);
            this.gbTableroMonedas.Controls.Add(this.lblSolesDoTab);
            this.gbTableroMonedas.Controls.Add(this.lblEuroTab);
            this.gbTableroMonedas.Controls.Add(this.lblDolarTab);
            this.gbTableroMonedas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTableroMonedas.Location = new System.Drawing.Point(33, 29);
            this.gbTableroMonedas.Name = "gbTableroMonedas";
            this.gbTableroMonedas.Size = new System.Drawing.Size(771, 176);
            this.gbTableroMonedas.TabIndex = 31;
            this.gbTableroMonedas.TabStop = false;
            this.gbTableroMonedas.Text = "Tablero Referencial";
            // 
            // txtEuTab
            // 
            this.txtEuTab.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuTab.Location = new System.Drawing.Point(362, 105);
            this.txtEuTab.Name = "txtEuTab";
            this.txtEuTab.Size = new System.Drawing.Size(100, 28);
            this.txtEuTab.TabIndex = 5;
            // 
            // txtDoTab
            // 
            this.txtDoTab.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoTab.Location = new System.Drawing.Point(362, 64);
            this.txtDoTab.Name = "txtDoTab";
            this.txtDoTab.Size = new System.Drawing.Size(100, 28);
            this.txtDoTab.TabIndex = 4;
            // 
            // lblSolesEuTab
            // 
            this.lblSolesEuTab.AutoSize = true;
            this.lblSolesEuTab.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolesEuTab.Location = new System.Drawing.Point(468, 108);
            this.lblSolesEuTab.Name = "lblSolesEuTab";
            this.lblSolesEuTab.Size = new System.Drawing.Size(50, 21);
            this.lblSolesEuTab.TabIndex = 3;
            this.lblSolesEuTab.Text = "Soles";
            // 
            // lblSolesDoTab
            // 
            this.lblSolesDoTab.AutoSize = true;
            this.lblSolesDoTab.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolesDoTab.Location = new System.Drawing.Point(468, 67);
            this.lblSolesDoTab.Name = "lblSolesDoTab";
            this.lblSolesDoTab.Size = new System.Drawing.Size(50, 21);
            this.lblSolesDoTab.TabIndex = 2;
            this.lblSolesDoTab.Text = "Soles";
            // 
            // lblEuroTab
            // 
            this.lblEuroTab.AutoSize = true;
            this.lblEuroTab.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroTab.Location = new System.Drawing.Point(262, 108);
            this.lblEuroTab.Name = "lblEuroTab";
            this.lblEuroTab.Size = new System.Drawing.Size(50, 21);
            this.lblEuroTab.TabIndex = 1;
            this.lblEuroTab.Text = "Euro:";
            // 
            // lblDolarTab
            // 
            this.lblDolarTab.AutoSize = true;
            this.lblDolarTab.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarTab.Location = new System.Drawing.Point(157, 67);
            this.lblDolarTab.Name = "lblDolarTab";
            this.lblDolarTab.Size = new System.Drawing.Size(155, 21);
            this.lblDolarTab.TabIndex = 0;
            this.lblDolarTab.Text = "Dólar Americano:";
            // 
            // gbTipoCambioSistema
            // 
            this.gbTipoCambioSistema.Controls.Add(this.txtEuro);
            this.gbTipoCambioSistema.Controls.Add(this.txtDolar);
            this.gbTipoCambioSistema.Controls.Add(this.lblDolar);
            this.gbTipoCambioSistema.Controls.Add(this.lblSolesEu);
            this.gbTipoCambioSistema.Controls.Add(this.lblEuro);
            this.gbTipoCambioSistema.Controls.Add(this.lblSolesDo);
            this.gbTipoCambioSistema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoCambioSistema.Location = new System.Drawing.Point(33, 252);
            this.gbTipoCambioSistema.Name = "gbTipoCambioSistema";
            this.gbTipoCambioSistema.Size = new System.Drawing.Size(771, 174);
            this.gbTipoCambioSistema.TabIndex = 32;
            this.gbTipoCambioSistema.TabStop = false;
            this.gbTipoCambioSistema.Text = "Tipo de Cambio del Sistema";
            // 
            // txtEuro
            // 
            this.txtEuro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.Location = new System.Drawing.Point(362, 112);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 28);
            this.txtEuro.TabIndex = 11;
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.Location = new System.Drawing.Point(362, 71);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 28);
            this.txtDolar.TabIndex = 10;
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(157, 74);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(155, 21);
            this.lblDolar.TabIndex = 6;
            this.lblDolar.Text = "Dólar Americano:";
            // 
            // lblSolesEu
            // 
            this.lblSolesEu.AutoSize = true;
            this.lblSolesEu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolesEu.Location = new System.Drawing.Point(468, 115);
            this.lblSolesEu.Name = "lblSolesEu";
            this.lblSolesEu.Size = new System.Drawing.Size(50, 21);
            this.lblSolesEu.TabIndex = 9;
            this.lblSolesEu.Text = "Soles";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(262, 115);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(50, 21);
            this.lblEuro.TabIndex = 7;
            this.lblEuro.Text = "Euro:";
            // 
            // lblSolesDo
            // 
            this.lblSolesDo.AutoSize = true;
            this.lblSolesDo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolesDo.Location = new System.Drawing.Point(468, 74);
            this.lblSolesDo.Name = "lblSolesDo";
            this.lblSolesDo.Size = new System.Drawing.Size(50, 21);
            this.lblSolesDo.TabIndex = 8;
            this.lblSolesDo.Text = "Soles";
            // 
            // frmActualizarTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 491);
            this.Controls.Add(this.gbTipoCambioSistema);
            this.Controls.Add(this.gbTableroMonedas);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActualizarTipoCambio";
            this.Text = "frmActualizarTipoCambio";
            this.gbTableroMonedas.ResumeLayout(false);
            this.gbTableroMonedas.PerformLayout();
            this.gbTipoCambioSistema.ResumeLayout(false);
            this.gbTipoCambioSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbTableroMonedas;
        private System.Windows.Forms.TextBox txtEuTab;
        private System.Windows.Forms.TextBox txtDoTab;
        private System.Windows.Forms.Label lblSolesEuTab;
        private System.Windows.Forms.Label lblSolesDoTab;
        private System.Windows.Forms.Label lblEuroTab;
        private System.Windows.Forms.Label lblDolarTab;
        private System.Windows.Forms.GroupBox gbTipoCambioSistema;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblSolesEu;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblSolesDo;
    }
}