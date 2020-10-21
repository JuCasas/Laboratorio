namespace LAB6Soft
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.lblBarra = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSoporte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgUmil = new System.Windows.Forms.PictureBox();
            this.btnOC = new FontAwesome.Sharp.IconButton();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.btnProveedor = new FontAwesome.Sharp.IconButton();
            this.btnMoneda = new FontAwesome.Sharp.IconButton();
            this.btnComprobantes = new FontAwesome.Sharp.IconButton();
            this.btnVencer = new FontAwesome.Sharp.IconButton();
            this.btnDocs = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUmil)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.barraTitulo.Controls.Add(this.lblBarra);
            this.barraTitulo.Controls.Add(this.btnRest);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(788, 35);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(13, 7);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(101, 17);
            this.lblBarra.TabIndex = 9;
            this.lblBarra.Text = "UMiLDESK Sofware";
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.Enabled = false;
            this.btnRest.Image = ((System.Drawing.Image)(resources.GetObject("btnRest.Image")));
            this.btnRest.Location = new System.Drawing.Point(729, 7);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(25, 25);
            this.btnRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRest.TabIndex = 8;
            this.btnRest.TabStop = false;
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(698, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(729, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(760, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menu Principal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gestión Comercial";
            // 
            // lblSoporte
            // 
            this.lblSoporte.AutoSize = true;
            this.lblSoporte.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoporte.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporte.ForeColor = System.Drawing.Color.Black;
            this.lblSoporte.Location = new System.Drawing.Point(595, 115);
            this.lblSoporte.Name = "lblSoporte";
            this.lblSoporte.Size = new System.Drawing.Size(60, 23);
            this.lblSoporte.TabIndex = 13;
            this.lblSoporte.Text = "Soporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(325, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gestión de Reportes";
            // 
            // imgUmil
            // 
            this.imgUmil.Image = ((System.Drawing.Image)(resources.GetObject("imgUmil.Image")));
            this.imgUmil.Location = new System.Drawing.Point(566, 51);
            this.imgUmil.Name = "imgUmil";
            this.imgUmil.Size = new System.Drawing.Size(200, 50);
            this.imgUmil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUmil.TabIndex = 21;
            this.imgUmil.TabStop = false;
            // 
            // btnOC
            // 
            this.btnOC.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOC.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOC.ForeColor = System.Drawing.Color.Transparent;
            this.btnOC.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnOC.IconColor = System.Drawing.Color.White;
            this.btnOC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOC.IconSize = 42;
            this.btnOC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOC.Location = new System.Drawing.Point(22, 154);
            this.btnOC.Margin = new System.Windows.Forms.Padding(0);
            this.btnOC.Name = "btnOC";
            this.btnOC.Rotation = 0D;
            this.btnOC.Size = new System.Drawing.Size(92, 85);
            this.btnOC.TabIndex = 31;
            this.btnOC.Text = "Orden de Compra";
            this.btnOC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOC.UseVisualStyleBackColor = false;
            this.btnOC.Click += new System.EventHandler(this.btnOC_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsuario.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuario.IconColor = System.Drawing.Color.White;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuario.IconSize = 42;
            this.btnUsuario.Location = new System.Drawing.Point(598, 153);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Rotation = 0D;
            this.btnUsuario.Size = new System.Drawing.Size(92, 85);
            this.btnUsuario.TabIndex = 32;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProveedor.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.Transparent;
            this.btnProveedor.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnProveedor.IconColor = System.Drawing.Color.White;
            this.btnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedor.IconSize = 42;
            this.btnProveedor.Location = new System.Drawing.Point(598, 255);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Rotation = 0D;
            this.btnProveedor.Size = new System.Drawing.Size(92, 85);
            this.btnProveedor.TabIndex = 33;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnMoneda
            // 
            this.btnMoneda.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoneda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMoneda.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda.ForeColor = System.Drawing.Color.Transparent;
            this.btnMoneda.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnMoneda.IconColor = System.Drawing.Color.White;
            this.btnMoneda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMoneda.IconSize = 42;
            this.btnMoneda.Location = new System.Drawing.Point(598, 361);
            this.btnMoneda.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Rotation = 0D;
            this.btnMoneda.Size = new System.Drawing.Size(92, 85);
            this.btnMoneda.TabIndex = 34;
            this.btnMoneda.Text = "Moneda";
            this.btnMoneda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoneda.UseVisualStyleBackColor = false;
            this.btnMoneda.Click += new System.EventHandler(this.btnMoneda_Click);
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobantes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnComprobantes.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobantes.ForeColor = System.Drawing.Color.Transparent;
            this.btnComprobantes.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnComprobantes.IconColor = System.Drawing.Color.White;
            this.btnComprobantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprobantes.IconSize = 42;
            this.btnComprobantes.Location = new System.Drawing.Point(22, 255);
            this.btnComprobantes.Margin = new System.Windows.Forms.Padding(0);
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.Rotation = 0D;
            this.btnComprobantes.Size = new System.Drawing.Size(92, 85);
            this.btnComprobantes.TabIndex = 35;
            this.btnComprobantes.Text = "Comprobantes";
            this.btnComprobantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComprobantes.UseVisualStyleBackColor = false;
            // 
            // btnVencer
            // 
            this.btnVencer.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVencer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVencer.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencer.ForeColor = System.Drawing.Color.Transparent;
            this.btnVencer.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnVencer.IconColor = System.Drawing.Color.White;
            this.btnVencer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVencer.IconSize = 42;
            this.btnVencer.Location = new System.Drawing.Point(156, 153);
            this.btnVencer.Margin = new System.Windows.Forms.Padding(0);
            this.btnVencer.Name = "btnVencer";
            this.btnVencer.Rotation = 0D;
            this.btnVencer.Size = new System.Drawing.Size(92, 85);
            this.btnVencer.TabIndex = 36;
            this.btnVencer.Text = "D. a vencer";
            this.btnVencer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVencer.UseVisualStyleBackColor = false;
            // 
            // btnDocs
            // 
            this.btnDocs.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocs.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDocs.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocs.ForeColor = System.Drawing.Color.Transparent;
            this.btnDocs.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btnDocs.IconColor = System.Drawing.Color.White;
            this.btnDocs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocs.IconSize = 44;
            this.btnDocs.Location = new System.Drawing.Point(22, 361);
            this.btnDocs.Margin = new System.Windows.Forms.Padding(0);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Rotation = 0D;
            this.btnDocs.Size = new System.Drawing.Size(92, 85);
            this.btnDocs.TabIndex = 37;
            this.btnDocs.Text = "D. Pago";
            this.btnDocs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDocs.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FilePrescription;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 42;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(329, 153);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(92, 85);
            this.iconButton1.TabIndex = 38;
            this.iconButton1.Text = "Ordenes Abiertas";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FilePowerpoint;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 42;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.Location = new System.Drawing.Point(329, 255);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(92, 85);
            this.iconButton2.TabIndex = 39;
            this.iconButton2.Text = "Ordenes Abiertas";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 640);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnDocs);
            this.Controls.Add(this.btnVencer);
            this.Controls.Add(this.btnComprobantes);
            this.Controls.Add(this.btnMoneda);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnOC);
            this.Controls.Add(this.imgUmil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSoporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barraTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUmil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSoporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgUmil;
        private System.Windows.Forms.Label lblBarra;
        private FontAwesome.Sharp.IconButton btnOC;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private FontAwesome.Sharp.IconButton btnProveedor;
        private FontAwesome.Sharp.IconButton btnMoneda;
        private FontAwesome.Sharp.IconButton btnComprobantes;
        private FontAwesome.Sharp.IconButton btnVencer;
        private FontAwesome.Sharp.IconButton btnDocs;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}