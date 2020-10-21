namespace LAB6Soft
{
    partial class frmSubMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubMenu));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBarra = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenulateral = new System.Windows.Forms.Panel();
            this.btnMoneda = new FontAwesome.Sharp.IconButton();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnReporte = new FontAwesome.Sharp.IconButton();
            this.btnDocPago = new FontAwesome.Sharp.IconButton();
            this.btnVencer = new FontAwesome.Sharp.IconButton();
            this.btnCompPago = new FontAwesome.Sharp.IconButton();
            this.btnOC = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblActual = new System.Windows.Forms.Label();
            this.iconActual = new FontAwesome.Sharp.IconPictureBox();
            this.pnlVentana = new System.Windows.Forms.Panel();
            this.pnlSombra = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlMenulateral.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActual)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Controls.Add(this.lblBarra);
            this.barraTitulo.Controls.Add(this.btnRest);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1256, 42);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB6Soft.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(1215, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(17, 9);
            this.lblBarra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(127, 22);
            this.lblBarra.TabIndex = 9;
            this.lblBarra.Text = "UMiLDESK Sofware";
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.Enabled = false;
            this.btnRest.Image = ((System.Drawing.Image)(resources.GetObject("btnRest.Image")));
            this.btnRest.Location = new System.Drawing.Point(1362, 4);
            this.btnRest.Margin = new System.Windows.Forms.Padding(4);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(33, 31);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1321, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 31);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1362, 4);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(33, 31);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1404, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenulateral
            // 
            this.pnlMenulateral.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlMenulateral.Controls.Add(this.btnMoneda);
            this.pnlMenulateral.Controls.Add(this.btnProveedores);
            this.pnlMenulateral.Controls.Add(this.btnUsuarios);
            this.pnlMenulateral.Controls.Add(this.btnReporte);
            this.pnlMenulateral.Controls.Add(this.btnDocPago);
            this.pnlMenulateral.Controls.Add(this.btnVencer);
            this.pnlMenulateral.Controls.Add(this.btnCompPago);
            this.pnlMenulateral.Controls.Add(this.btnOC);
            this.pnlMenulateral.Controls.Add(this.pnlLogo);
            this.pnlMenulateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenulateral.Location = new System.Drawing.Point(0, 42);
            this.pnlMenulateral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenulateral.Name = "pnlMenulateral";
            this.pnlMenulateral.Size = new System.Drawing.Size(293, 667);
            this.pnlMenulateral.TabIndex = 2;
            // 
            // btnMoneda
            // 
            this.btnMoneda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoneda.FlatAppearance.BorderSize = 0;
            this.btnMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoneda.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMoneda.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda.ForeColor = System.Drawing.Color.White;
            this.btnMoneda.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnMoneda.IconColor = System.Drawing.Color.White;
            this.btnMoneda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMoneda.IconSize = 36;
            this.btnMoneda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoneda.Location = new System.Drawing.Point(0, 469);
            this.btnMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnMoneda.Rotation = 0D;
            this.btnMoneda.Size = new System.Drawing.Size(293, 49);
            this.btnMoneda.TabIndex = 8;
            this.btnMoneda.Text = "Moneda";
            this.btnMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoneda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoneda.UseVisualStyleBackColor = true;
            this.btnMoneda.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProveedores.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 36;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 420);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnProveedores.Rotation = 0D;
            this.btnProveedores.Size = new System.Drawing.Size(293, 49);
            this.btnProveedores.TabIndex = 7;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsuarios.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 36;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 371);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUsuarios.Rotation = 0D;
            this.btnUsuarios.Size = new System.Drawing.Size(293, 49);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReporte.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.IconChar = FontAwesome.Sharp.IconChar.FilePrescription;
            this.btnReporte.IconColor = System.Drawing.Color.White;
            this.btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporte.IconSize = 36;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 322);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnReporte.Rotation = 0D;
            this.btnReporte.Size = new System.Drawing.Size(293, 49);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnDocPago
            // 
            this.btnDocPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocPago.FlatAppearance.BorderSize = 0;
            this.btnDocPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocPago.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDocPago.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocPago.ForeColor = System.Drawing.Color.White;
            this.btnDocPago.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btnDocPago.IconColor = System.Drawing.Color.White;
            this.btnDocPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocPago.IconSize = 36;
            this.btnDocPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocPago.Location = new System.Drawing.Point(0, 273);
            this.btnDocPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnDocPago.Name = "btnDocPago";
            this.btnDocPago.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnDocPago.Rotation = 0D;
            this.btnDocPago.Size = new System.Drawing.Size(293, 49);
            this.btnDocPago.TabIndex = 4;
            this.btnDocPago.Text = "Documentos de Pago";
            this.btnDocPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocPago.UseVisualStyleBackColor = true;
            this.btnDocPago.Click += new System.EventHandler(this.btnDocPago_Click);
            // 
            // btnVencer
            // 
            this.btnVencer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVencer.FlatAppearance.BorderSize = 0;
            this.btnVencer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVencer.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVencer.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencer.ForeColor = System.Drawing.Color.White;
            this.btnVencer.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnVencer.IconColor = System.Drawing.Color.White;
            this.btnVencer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVencer.IconSize = 36;
            this.btnVencer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVencer.Location = new System.Drawing.Point(0, 224);
            this.btnVencer.Margin = new System.Windows.Forms.Padding(4);
            this.btnVencer.Name = "btnVencer";
            this.btnVencer.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnVencer.Rotation = 0D;
            this.btnVencer.Size = new System.Drawing.Size(293, 49);
            this.btnVencer.TabIndex = 3;
            this.btnVencer.Text = "Documentos a Vencer";
            this.btnVencer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVencer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVencer.UseVisualStyleBackColor = true;
            this.btnVencer.Click += new System.EventHandler(this.btnVencer_Click);
            // 
            // btnCompPago
            // 
            this.btnCompPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompPago.FlatAppearance.BorderSize = 0;
            this.btnCompPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompPago.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCompPago.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompPago.ForeColor = System.Drawing.Color.White;
            this.btnCompPago.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnCompPago.IconColor = System.Drawing.Color.White;
            this.btnCompPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompPago.IconSize = 36;
            this.btnCompPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompPago.Location = new System.Drawing.Point(0, 175);
            this.btnCompPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompPago.Name = "btnCompPago";
            this.btnCompPago.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnCompPago.Rotation = 0D;
            this.btnCompPago.Size = new System.Drawing.Size(293, 49);
            this.btnCompPago.TabIndex = 2;
            this.btnCompPago.Text = "Comprobantes de Pago";
            this.btnCompPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompPago.UseVisualStyleBackColor = true;
            this.btnCompPago.Click += new System.EventHandler(this.btnCompPago_Click);
            // 
            // btnOC
            // 
            this.btnOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOC.FlatAppearance.BorderSize = 0;
            this.btnOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOC.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOC.ForeColor = System.Drawing.Color.White;
            this.btnOC.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnOC.IconColor = System.Drawing.Color.White;
            this.btnOC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOC.IconSize = 36;
            this.btnOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOC.Location = new System.Drawing.Point(0, 126);
            this.btnOC.Margin = new System.Windows.Forms.Padding(4);
            this.btnOC.Name = "btnOC";
            this.btnOC.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnOC.Rotation = 0D;
            this.btnOC.Size = new System.Drawing.Size(293, 49);
            this.btnOC.TabIndex = 1;
            this.btnOC.Text = "Orden de Compra";
            this.btnOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOC.UseVisualStyleBackColor = true;
            this.btnOC.Click += new System.EventHandler(this.btnOC_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlLogo.Controls.Add(this.btnInicio);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(293, 126);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(24, 33);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(227, 66);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBarra.Controls.Add(this.linkLabel4);
            this.pnlBarra.Controls.Add(this.lblActual);
            this.pnlBarra.Controls.Add(this.iconActual);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(293, 42);
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(963, 61);
            this.pnlBarra.TabIndex = 3;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.ForeColor = System.Drawing.Color.White;
            this.lblActual.Location = new System.Drawing.Point(57, 30);
            this.lblActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(40, 22);
            this.lblActual.TabIndex = 1;
            this.lblActual.Text = "Inicio";
            // 
            // iconActual
            // 
            this.iconActual.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconActual.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconActual.IconColor = System.Drawing.Color.White;
            this.iconActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActual.IconSize = 39;
            this.iconActual.Location = new System.Drawing.Point(8, 10);
            this.iconActual.Margin = new System.Windows.Forms.Padding(4);
            this.iconActual.Name = "iconActual";
            this.iconActual.Size = new System.Drawing.Size(43, 39);
            this.iconActual.TabIndex = 0;
            this.iconActual.TabStop = false;
            // 
            // pnlVentana
            // 
            this.pnlVentana.CausesValidation = false;
            this.pnlVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVentana.Location = new System.Drawing.Point(293, 103);
            this.pnlVentana.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVentana.Name = "pnlVentana";
            this.pnlVentana.Size = new System.Drawing.Size(963, 606);
            this.pnlVentana.TabIndex = 4;
            // 
            // pnlSombra
            // 
            this.pnlSombra.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSombra.Location = new System.Drawing.Point(293, 103);
            this.pnlSombra.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSombra.Name = "pnlSombra";
            this.pnlSombra.Size = new System.Drawing.Size(963, 10);
            this.pnlSombra.TabIndex = 5;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(718, 10);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(117, 26);
            this.linkLabel4.TabIndex = 20;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = " Detracciones";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // frmSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 709);
            this.Controls.Add(this.pnlSombra);
            this.Controls.Add(this.pnlVentana);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlMenulateral);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSubMenu";
            this.Text = "frmOrdenCompra";
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlMenulateral.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.PictureBox btnRest;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlMenulateral;
        private FontAwesome.Sharp.IconButton btnOC;
        private System.Windows.Forms.Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnMoneda;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnReporte;
        private FontAwesome.Sharp.IconButton btnDocPago;
        private FontAwesome.Sharp.IconButton btnVencer;
        private FontAwesome.Sharp.IconButton btnCompPago;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblActual;
        private FontAwesome.Sharp.IconPictureBox iconActual;
        private System.Windows.Forms.Panel pnlSombra;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel pnlVentana;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}