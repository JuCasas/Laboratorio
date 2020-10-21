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
            this.pnlSubProveedor = new System.Windows.Forms.Panel();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.pnlSubUsuarios = new System.Windows.Forms.Panel();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.pnlSubReps = new System.Windows.Forms.Panel();
            this.btnRepEf = new System.Windows.Forms.Button();
            this.btnRepOC = new System.Windows.Forms.Button();
            this.btnReportes = new FontAwesome.Sharp.IconButton();
            this.btnDocPago = new FontAwesome.Sharp.IconButton();
            this.pnlSubVencer = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnVencer = new FontAwesome.Sharp.IconButton();
            this.pnlSubComp = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCompPago = new FontAwesome.Sharp.IconButton();
            this.btnOC = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.lblActual = new System.Windows.Forms.Label();
            this.iconActual = new FontAwesome.Sharp.IconPictureBox();
            this.pnlVentana = new System.Windows.Forms.Panel();
            this.pnlSombra = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlMenulateral.SuspendLayout();
            this.pnlSubProveedor.SuspendLayout();
            this.pnlSubUsuarios.SuspendLayout();
            this.pnlSubReps.SuspendLayout();
            this.pnlSubVencer.SuspendLayout();
            this.pnlSubComp.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconActual)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.barraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Controls.Add(this.lblBarra);
            this.barraTitulo.Controls.Add(this.btnRest);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(942, 35);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB6Soft.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(911, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnRest.Location = new System.Drawing.Point(1017, 3);
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
            this.btnMinimizar.Location = new System.Drawing.Point(987, 3);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1017, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1049, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenulateral
            // 
            this.pnlMenulateral.AutoScroll = true;
            this.pnlMenulateral.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlMenulateral.Controls.Add(this.btnMoneda);
            this.pnlMenulateral.Controls.Add(this.pnlSubProveedor);
            this.pnlMenulateral.Controls.Add(this.btnProveedores);
            this.pnlMenulateral.Controls.Add(this.pnlSubUsuarios);
            this.pnlMenulateral.Controls.Add(this.btnUsuarios);
            this.pnlMenulateral.Controls.Add(this.pnlSubReps);
            this.pnlMenulateral.Controls.Add(this.btnReportes);
            this.pnlMenulateral.Controls.Add(this.btnDocPago);
            this.pnlMenulateral.Controls.Add(this.pnlSubVencer);
            this.pnlMenulateral.Controls.Add(this.btnVencer);
            this.pnlMenulateral.Controls.Add(this.pnlSubComp);
            this.pnlMenulateral.Controls.Add(this.btnCompPago);
            this.pnlMenulateral.Controls.Add(this.btnOC);
            this.pnlMenulateral.Controls.Add(this.pnlLogo);
            this.pnlMenulateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenulateral.Location = new System.Drawing.Point(0, 35);
            this.pnlMenulateral.Name = "pnlMenulateral";
            this.pnlMenulateral.Size = new System.Drawing.Size(220, 526);
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
            this.btnMoneda.Location = new System.Drawing.Point(0, 652);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMoneda.Rotation = 0D;
            this.btnMoneda.Size = new System.Drawing.Size(203, 40);
            this.btnMoneda.TabIndex = 14;
            this.btnMoneda.Text = "Moneda";
            this.btnMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoneda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoneda.UseVisualStyleBackColor = true;
            this.btnMoneda.Click += new System.EventHandler(this.btnMoneda_Click);
            // 
            // pnlSubProveedor
            // 
            this.pnlSubProveedor.Controls.Add(this.btnModificarProveedor);
            this.pnlSubProveedor.Controls.Add(this.btnAgregarProveedor);
            this.pnlSubProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubProveedor.Location = new System.Drawing.Point(0, 586);
            this.pnlSubProveedor.Name = "pnlSubProveedor";
            this.pnlSubProveedor.Size = new System.Drawing.Size(203, 66);
            this.pnlSubProveedor.TabIndex = 13;
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnModificarProveedor.Location = new System.Drawing.Point(0, 29);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnModificarProveedor.Size = new System.Drawing.Size(203, 29);
            this.btnModificarProveedor.TabIndex = 8;
            this.btnModificarProveedor.Text = "Modificar Proveedor";
            this.btnModificarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProveedor.UseVisualStyleBackColor = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnAgregarProveedor.Size = new System.Drawing.Size(203, 29);
            this.btnAgregarProveedor.TabIndex = 7;
            this.btnAgregarProveedor.Text = "Agregar Proveedor";
            this.btnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
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
            this.btnProveedores.Location = new System.Drawing.Point(0, 546);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProveedores.Rotation = 0D;
            this.btnProveedores.Size = new System.Drawing.Size(203, 40);
            this.btnProveedores.TabIndex = 12;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            // 
            // pnlSubUsuarios
            // 
            this.pnlSubUsuarios.Controls.Add(this.btnModificarUsuario);
            this.pnlSubUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.pnlSubUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubUsuarios.Location = new System.Drawing.Point(0, 474);
            this.pnlSubUsuarios.Name = "pnlSubUsuarios";
            this.pnlSubUsuarios.Size = new System.Drawing.Size(203, 72);
            this.pnlSubUsuarios.TabIndex = 11;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.Location = new System.Drawing.Point(0, 29);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnModificarUsuario.Size = new System.Drawing.Size(203, 29);
            this.btnModificarUsuario.TabIndex = 6;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnAgregarUsuario.Size = new System.Drawing.Size(203, 29);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
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
            this.btnUsuarios.Location = new System.Drawing.Point(0, 434);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Rotation = 0D;
            this.btnUsuarios.Size = new System.Drawing.Size(203, 40);
            this.btnUsuarios.TabIndex = 10;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click_1);
            // 
            // pnlSubReps
            // 
            this.pnlSubReps.Controls.Add(this.btnRepEf);
            this.pnlSubReps.Controls.Add(this.btnRepOC);
            this.pnlSubReps.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubReps.Location = new System.Drawing.Point(0, 366);
            this.pnlSubReps.Name = "pnlSubReps";
            this.pnlSubReps.Size = new System.Drawing.Size(203, 68);
            this.pnlSubReps.TabIndex = 9;
            // 
            // btnRepEf
            // 
            this.btnRepEf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepEf.FlatAppearance.BorderSize = 0;
            this.btnRepEf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepEf.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepEf.ForeColor = System.Drawing.Color.White;
            this.btnRepEf.Location = new System.Drawing.Point(0, 29);
            this.btnRepEf.Name = "btnRepEf";
            this.btnRepEf.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnRepEf.Size = new System.Drawing.Size(203, 29);
            this.btnRepEf.TabIndex = 4;
            this.btnRepEf.Text = "Reportes de Eficiencia";
            this.btnRepEf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepEf.UseVisualStyleBackColor = true;
            this.btnRepEf.Click += new System.EventHandler(this.btnRepEf_Click);
            // 
            // btnRepOC
            // 
            this.btnRepOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepOC.FlatAppearance.BorderSize = 0;
            this.btnRepOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepOC.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepOC.ForeColor = System.Drawing.Color.White;
            this.btnRepOC.Location = new System.Drawing.Point(0, 0);
            this.btnRepOC.Name = "btnRepOC";
            this.btnRepOC.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.btnRepOC.Size = new System.Drawing.Size(203, 29);
            this.btnRepOC.TabIndex = 3;
            this.btnRepOC.Text = "Reportes de O/C";
            this.btnRepOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepOC.UseVisualStyleBackColor = true;
            this.btnRepOC.Click += new System.EventHandler(this.btnRepOC_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReportes.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.IconChar = FontAwesome.Sharp.IconChar.FilePrescription;
            this.btnReportes.IconColor = System.Drawing.Color.White;
            this.btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportes.IconSize = 36;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 326);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReportes.Rotation = 0D;
            this.btnReportes.Size = new System.Drawing.Size(203, 40);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
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
            this.btnDocPago.Location = new System.Drawing.Point(0, 286);
            this.btnDocPago.Name = "btnDocPago";
            this.btnDocPago.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDocPago.Rotation = 0D;
            this.btnDocPago.Size = new System.Drawing.Size(203, 40);
            this.btnDocPago.TabIndex = 6;
            this.btnDocPago.Text = "Documentos de Pago";
            this.btnDocPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocPago.UseVisualStyleBackColor = true;
            this.btnDocPago.Click += new System.EventHandler(this.btnDocPago_Click_1);
            // 
            // pnlSubVencer
            // 
            this.pnlSubVencer.Controls.Add(this.button7);
            this.pnlSubVencer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubVencer.Location = new System.Drawing.Point(0, 246);
            this.pnlSubVencer.Name = "pnlSubVencer";
            this.pnlSubVencer.Size = new System.Drawing.Size(203, 40);
            this.pnlSubVencer.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(203, 29);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
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
            this.btnVencer.Location = new System.Drawing.Point(0, 206);
            this.btnVencer.Name = "btnVencer";
            this.btnVencer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnVencer.Rotation = 0D;
            this.btnVencer.Size = new System.Drawing.Size(203, 40);
            this.btnVencer.TabIndex = 4;
            this.btnVencer.Text = "Documentos a Vencer";
            this.btnVencer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVencer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVencer.UseVisualStyleBackColor = true;
            this.btnVencer.Click += new System.EventHandler(this.btnVencer_Click_1);
            // 
            // pnlSubComp
            // 
            this.pnlSubComp.Controls.Add(this.button4);
            this.pnlSubComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubComp.Location = new System.Drawing.Point(0, 164);
            this.pnlSubComp.Name = "pnlSubComp";
            this.pnlSubComp.Size = new System.Drawing.Size(203, 42);
            this.pnlSubComp.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(203, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
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
            this.btnCompPago.Location = new System.Drawing.Point(0, 124);
            this.btnCompPago.Name = "btnCompPago";
            this.btnCompPago.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompPago.Rotation = 0D;
            this.btnCompPago.Size = new System.Drawing.Size(203, 40);
            this.btnCompPago.TabIndex = 3;
            this.btnCompPago.Text = "Comprobantes de Pago";
            this.btnCompPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompPago.UseVisualStyleBackColor = true;
            this.btnCompPago.Click += new System.EventHandler(this.btnCompPago_Click_1);
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
            this.btnOC.Location = new System.Drawing.Point(0, 80);
            this.btnOC.Name = "btnOC";
            this.btnOC.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOC.Rotation = 0D;
            this.btnOC.Size = new System.Drawing.Size(203, 44);
            this.btnOC.TabIndex = 1;
            this.btnOC.Text = "Gestión de órdenes de Compra";
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
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(203, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(18, 10);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(170, 54);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBarra.Controls.Add(this.lblActual);
            this.pnlBarra.Controls.Add(this.iconActual);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(220, 35);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(722, 50);
            this.pnlBarra.TabIndex = 3;
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActual.ForeColor = System.Drawing.Color.White;
            this.lblActual.Location = new System.Drawing.Point(43, 24);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(35, 17);
            this.lblActual.TabIndex = 1;
            this.lblActual.Text = "Inicio";
            // 
            // iconActual
            // 
            this.iconActual.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconActual.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconActual.IconColor = System.Drawing.Color.White;
            this.iconActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActual.Location = new System.Drawing.Point(6, 8);
            this.iconActual.Name = "iconActual";
            this.iconActual.Size = new System.Drawing.Size(32, 32);
            this.iconActual.TabIndex = 0;
            this.iconActual.TabStop = false;
            // 
            // pnlVentana
            // 
            this.pnlVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVentana.Location = new System.Drawing.Point(220, 85);
            this.pnlVentana.Name = "pnlVentana";
            this.pnlVentana.Size = new System.Drawing.Size(722, 476);
            this.pnlVentana.TabIndex = 4;
            // 
            // pnlSombra
            // 
            this.pnlSombra.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSombra.Location = new System.Drawing.Point(220, 85);
            this.pnlSombra.Name = "pnlSombra";
            this.pnlSombra.Size = new System.Drawing.Size(722, 8);
            this.pnlSombra.TabIndex = 5;
            // 
            // frmSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 561);
            this.Controls.Add(this.pnlSombra);
            this.Controls.Add(this.pnlVentana);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlMenulateral);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
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
            this.pnlSubProveedor.ResumeLayout(false);
            this.pnlSubUsuarios.ResumeLayout(false);
            this.pnlSubReps.ResumeLayout(false);
            this.pnlSubVencer.ResumeLayout(false);
            this.pnlSubComp.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblActual;
        private FontAwesome.Sharp.IconPictureBox iconActual;
        private System.Windows.Forms.Panel pnlVentana;
        private System.Windows.Forms.Panel pnlSombra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlSubVencer;
        private FontAwesome.Sharp.IconButton btnVencer;
        private System.Windows.Forms.Panel pnlSubComp;
        private System.Windows.Forms.Button button4;
        private FontAwesome.Sharp.IconButton btnCompPago;
        private FontAwesome.Sharp.IconButton btnDocPago;
        private System.Windows.Forms.Button button7;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel pnlSubReps;
        private System.Windows.Forms.Button btnRepEf;
        private System.Windows.Forms.Button btnRepOC;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnMoneda;
        private System.Windows.Forms.Panel pnlSubProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private System.Windows.Forms.Panel pnlSubUsuarios;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
    }
}