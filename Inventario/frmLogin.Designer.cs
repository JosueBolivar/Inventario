namespace Inventario
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblMensajeUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lknOlvideClave = new System.Windows.Forms.LinkLabel();
            this.lblTituloMensajeUsuario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlAviso = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.pnlAviso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(105, 197);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(211, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "1";
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit-clear-3.png");
            this.imageList1.Images.SetKeyName(1, "dialog-accept.png");
            this.imageList1.Images.SetKeyName(2, "application-exit.png");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ayuda";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.ImageIndex = 1;
            this.btnSalir.ImageList = this.imageList2;
            this.btnSalir.Location = new System.Drawing.Point(105, 312);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(177, 39);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "application-exit-5.png");
            this.imageList2.Images.SetKeyName(1, "window-close-4.png");
            this.imageList2.Images.SetKeyName(2, "basket-3.png");
            this.imageList2.Images.SetKeyName(3, "group-add.png");
            this.imageList2.Images.SetKeyName(4, "cart-add.png");
            this.imageList2.Images.SetKeyName(5, "view-list-multicolumn-4.png");
            this.imageList2.Images.SetKeyName(6, "go-bottom-7.png");
            this.imageList2.Images.SetKeyName(7, "arrow-refresh.png");
            this.imageList2.Images.SetKeyName(8, "calculator-edit.png");
            this.imageList2.Images.SetKeyName(9, "distribute-horizontal-center.png");
            this.imageList2.Images.SetKeyName(10, "format-list-ordered.png");
            this.imageList2.Images.SetKeyName(11, "system-run-5.png");
            this.imageList2.Images.SetKeyName(12, "system-run-6.png");
            this.imageList2.Images.SetKeyName(13, "wrench-orange.png");
            this.imageList2.Images.SetKeyName(14, "tick.png");
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.ImageIndex = 14;
            this.btnEntrar.ImageList = this.imageList2;
            this.btnEntrar.Location = new System.Drawing.Point(324, 312);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(187, 39);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Aceptar";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnEntrar, "Acceder al sistema");
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblMensajeUsuario
            // 
            this.lblMensajeUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeUsuario.Location = new System.Drawing.Point(106, 60);
            this.lblMensajeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajeUsuario.Name = "lblMensajeUsuario";
            this.lblMensajeUsuario.Size = new System.Drawing.Size(396, 23);
            this.lblMensajeUsuario.TabIndex = 301;
            this.lblMensajeUsuario.Text = "Por favor ingresa usuario y contraseña para continuar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 302;
            this.label2.Text = "Contraseña";
            // 
            // cboUsuario
            // 
            this.cboUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(105, 140);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(410, 24);
            this.cboUsuario.TabIndex = 1;
            this.cboUsuario.TextChanged += new System.EventHandler(this.cboUsuario_TextChanged);
            // 
            // lknOlvideClave
            // 
            this.lknOlvideClave.AutoSize = true;
            this.lknOlvideClave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lknOlvideClave.Location = new System.Drawing.Point(320, 202);
            this.lknOlvideClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lknOlvideClave.Name = "lknOlvideClave";
            this.lknOlvideClave.Size = new System.Drawing.Size(191, 20);
            this.lknOlvideClave.TabIndex = 3;
            this.lknOlvideClave.TabStop = true;
            this.lknOlvideClave.Text = "Olvidé mi contraseña";
            // 
            // lblTituloMensajeUsuario
            // 
            this.lblTituloMensajeUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMensajeUsuario.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTituloMensajeUsuario.Location = new System.Drawing.Point(105, 23);
            this.lblTituloMensajeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloMensajeUsuario.Name = "lblTituloMensajeUsuario";
            this.lblTituloMensajeUsuario.Size = new System.Drawing.Size(388, 25);
            this.lblTituloMensajeUsuario.TabIndex = 305;
            this.lblTituloMensajeUsuario.Text = "Login";
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.BackColor = System.Drawing.Color.Ivory;
            this.lblEstado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(47, 4);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(460, 36);
            this.lblEstado.TabIndex = 306;
            // 
            // pnlAviso
            // 
            this.pnlAviso.BackColor = System.Drawing.Color.Ivory;
            this.pnlAviso.Controls.Add(this.pictureBox2);
            this.pnlAviso.Controls.Add(this.lblEstado);
            this.pnlAviso.Location = new System.Drawing.Point(45, 366);
            this.pnlAviso.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAviso.Name = "pnlAviso";
            this.pnlAviso.Size = new System.Drawing.Size(511, 43);
            this.pnlAviso.TabIndex = 308;
            this.pnlAviso.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Inventario.Properties.Resources.application_error;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(9, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.TabIndex = 307;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventario.Properties.Resources.usu_admin;
            this.pictureBox1.Location = new System.Drawing.Point(27, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 310;
            this.label3.Text = "Seleccione el idioma";
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "spain_32px.png");
            this.imageList3.Images.SetKeyName(1, "usa_32px.png");
            // 
            // cboIdioma
            // 
            this.cboIdioma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Items.AddRange(new object[] {
            "Español",
            "Inglés"});
            this.cboIdioma.Location = new System.Drawing.Point(105, 267);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(211, 23);
            this.cboIdioma.TabIndex = 311;
            this.cboIdioma.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboIdioma_DrawItem);
            this.cboIdioma.SelectedIndexChanged += new System.EventHandler(this.cboIdioma_SelectedIndexChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 424);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlAviso);
            this.Controls.Add(this.lblTituloMensajeUsuario);
            this.Controls.Add(this.lknOlvideClave);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensajeUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al sistema";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.pnlAviso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMensajeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.LinkLabel lknOlvideClave;
        private System.Windows.Forms.Label lblTituloMensajeUsuario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlAviso;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ComboBox cboIdioma;
    }
}