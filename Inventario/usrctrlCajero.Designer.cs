namespace Inventario
{
    partial class usrctrlCajero
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usrctrlCajero));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVenta = new System.Windows.Forms.TabPage();
            this.lstvVentas = new System.Windows.Forms.ListView();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.lstvClientes = new System.Windows.Forms.ListView();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.lstvProductos = new System.Windows.Forms.ListView();
            this.tabInventario = new System.Windows.Forms.TabPage();
            this.lstvInventario = new System.Windows.Forms.ListView();
            this.tabOtros = new System.Windows.Forms.TabPage();
            this.lstvOtros = new System.Windows.Forms.ListView();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnNuevoCajero = new System.Windows.Forms.Button();
            this.dgvCajeros = new System.Windows.Forms.DataGridView();
            this.imagenCajero = new System.Windows.Forms.DataGridViewImageColumn();
            this.cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.tabOtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user-add.png");
            this.imageList1.Images.SetKeyName(1, "cross.png");
            this.imageList1.Images.SetKeyName(2, "dialog-apply.png");
            this.imageList1.Images.SetKeyName(3, "user-delete-2.png");
            this.imageList1.Images.SetKeyName(4, "user-new-3.png");
            this.imageList1.Images.SetKeyName(5, "cart.png");
            this.imageList1.Images.SetKeyName(6, "user.png");
            this.imageList1.Images.SetKeyName(7, "view-list-multicolumn-4.png");
            this.imageList1.Images.SetKeyName(8, "format-list-ordered.png");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(681, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 319;
            this.button1.Text = " Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(392, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 29);
            this.button2.TabIndex = 318;
            this.button2.Text = " Guardar Cajero y Permisos";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabVenta);
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Controls.Add(this.tabInventario);
            this.tabControl1.Controls.Add(this.tabOtros);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(392, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 201);
            this.tabControl1.TabIndex = 317;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.lstvVentas);
            this.tabVenta.ImageIndex = 5;
            this.tabVenta.Location = new System.Drawing.Point(4, 23);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenta.Size = new System.Drawing.Size(425, 174);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // lstvVentas
            // 
            this.lstvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvVentas.Location = new System.Drawing.Point(3, 3);
            this.lstvVentas.Name = "lstvVentas";
            this.lstvVentas.Size = new System.Drawing.Size(419, 168);
            this.lstvVentas.TabIndex = 0;
            this.lstvVentas.UseCompatibleStateImageBehavior = false;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.lstvClientes);
            this.tabClientes.ImageIndex = 6;
            this.tabClientes.Location = new System.Drawing.Point(4, 23);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(425, 174);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // lstvClientes
            // 
            this.lstvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvClientes.Location = new System.Drawing.Point(3, 3);
            this.lstvClientes.Name = "lstvClientes";
            this.lstvClientes.Size = new System.Drawing.Size(419, 168);
            this.lstvClientes.TabIndex = 1;
            this.lstvClientes.UseCompatibleStateImageBehavior = false;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.lstvProductos);
            this.tabProductos.ImageIndex = 7;
            this.tabProductos.Location = new System.Drawing.Point(4, 23);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(425, 174);
            this.tabProductos.TabIndex = 2;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // lstvProductos
            // 
            this.lstvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvProductos.Location = new System.Drawing.Point(3, 3);
            this.lstvProductos.Name = "lstvProductos";
            this.lstvProductos.Size = new System.Drawing.Size(419, 168);
            this.lstvProductos.TabIndex = 2;
            this.lstvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.lstvInventario);
            this.tabInventario.ImageIndex = 8;
            this.tabInventario.Location = new System.Drawing.Point(4, 23);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventario.Size = new System.Drawing.Size(425, 174);
            this.tabInventario.TabIndex = 3;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // lstvInventario
            // 
            this.lstvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvInventario.Location = new System.Drawing.Point(3, 3);
            this.lstvInventario.Name = "lstvInventario";
            this.lstvInventario.Size = new System.Drawing.Size(419, 168);
            this.lstvInventario.TabIndex = 3;
            this.lstvInventario.UseCompatibleStateImageBehavior = false;
            // 
            // tabOtros
            // 
            this.tabOtros.Controls.Add(this.lstvOtros);
            this.tabOtros.Location = new System.Drawing.Point(4, 23);
            this.tabOtros.Name = "tabOtros";
            this.tabOtros.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtros.Size = new System.Drawing.Size(425, 174);
            this.tabOtros.TabIndex = 4;
            this.tabOtros.Text = "Otros";
            this.tabOtros.UseVisualStyleBackColor = true;
            // 
            // lstvOtros
            // 
            this.lstvOtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvOtros.Location = new System.Drawing.Point(3, 3);
            this.lstvOtros.Name = "lstvOtros";
            this.lstvOtros.Size = new System.Drawing.Size(419, 168);
            this.lstvOtros.TabIndex = 4;
            this.lstvOtros.UseCompatibleStateImageBehavior = false;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(503, 135);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(318, 22);
            this.txtNombreCompleto.TabIndex = 316;
            this.txtNombreCompleto.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 315;
            this.label4.Text = "Nombre completo";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(503, 110);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(192, 22);
            this.txtPass.TabIndex = 314;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 313;
            this.label3.Text = "Contraseña";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(503, 85);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(192, 22);
            this.txtLogin.TabIndex = 312;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 311;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(365, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 310;
            this.label1.Text = "MODIFICAR CAJERO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDarBaja.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDarBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDarBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaja.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarBaja.ForeColor = System.Drawing.Color.Black;
            this.btnDarBaja.ImageIndex = 3;
            this.btnDarBaja.ImageList = this.imageList1;
            this.btnDarBaja.Location = new System.Drawing.Point(492, 26);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(120, 27);
            this.btnDarBaja.TabIndex = 309;
            this.btnDarBaja.Text = " Dar de baja";
            this.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCajero
            // 
            this.btnNuevoCajero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevoCajero.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoCajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevoCajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevoCajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCajero.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCajero.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoCajero.ImageIndex = 4;
            this.btnNuevoCajero.ImageList = this.imageList1;
            this.btnNuevoCajero.Location = new System.Drawing.Point(358, 25);
            this.btnNuevoCajero.Name = "btnNuevoCajero";
            this.btnNuevoCajero.Size = new System.Drawing.Size(128, 27);
            this.btnNuevoCajero.TabIndex = 308;
            this.btnNuevoCajero.Text = " Nuevo Cajero";
            this.btnNuevoCajero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCajero.UseVisualStyleBackColor = false;
            // 
            // dgvCajeros
            // 
            this.dgvCajeros.AllowUserToAddRows = false;
            this.dgvCajeros.AllowUserToDeleteRows = false;
            this.dgvCajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCajeros.BackgroundColor = System.Drawing.Color.White;
            this.dgvCajeros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCajeros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCajeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagenCajero,
            this.cajero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCajeros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCajeros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvCajeros.EnableHeadersVisualStyles = false;
            this.dgvCajeros.GridColor = System.Drawing.Color.White;
            this.dgvCajeros.Location = new System.Drawing.Point(7, 59);
            this.dgvCajeros.Name = "dgvCajeros";
            this.dgvCajeros.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCajeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCajeros.RowHeadersVisible = false;
            this.dgvCajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCajeros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCajeros.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCajeros.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCajeros.RowTemplate.Height = 24;
            this.dgvCajeros.RowTemplate.ReadOnly = true;
            this.dgvCajeros.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCajeros.Size = new System.Drawing.Size(345, 342);
            this.dgvCajeros.TabIndex = 307;
            this.dgvCajeros.TabStop = false;
            // 
            // imagenCajero
            // 
            this.imagenCajero.HeaderText = "";
            this.imagenCajero.Name = "imagenCajero";
            this.imagenCajero.ReadOnly = true;
            this.imagenCajero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagenCajero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imagenCajero.Width = 60;
            // 
            // cajero
            // 
            this.cajero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cajero.HeaderText = "Nombre del Cajero";
            this.cajero.Name = "cajero";
            this.cajero.ReadOnly = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(7, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(345, 23);
            this.txtBusqueda.TabIndex = 306;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl1.Location = new System.Drawing.Point(4, 4);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(288, 23);
            this.lbl1.TabIndex = 305;
            this.lbl1.Text = "ADMINISTRACION DE CAJEROS";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usrctrlCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnNuevoCajero);
            this.Controls.Add(this.dgvCajeros);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lbl1);
            this.Name = "usrctrlCajero";
            this.Size = new System.Drawing.Size(828, 408);
            this.tabControl1.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tabInventario.ResumeLayout(false);
            this.tabOtros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVenta;
        private System.Windows.Forms.ListView lstvVentas;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.ListView lstvClientes;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.ListView lstvProductos;
        private System.Windows.Forms.TabPage tabInventario;
        private System.Windows.Forms.ListView lstvInventario;
        private System.Windows.Forms.TabPage tabOtros;
        private System.Windows.Forms.ListView lstvOtros;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnNuevoCajero;
        private System.Windows.Forms.DataGridView dgvCajeros;
        private System.Windows.Forms.DataGridViewImageColumn imagenCajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajero;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lbl1;
    }
}
