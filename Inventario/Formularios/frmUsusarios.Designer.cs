
namespace Inventario.Formularios
{
    partial class frmUsusarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsusarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.imagenCajero = new System.Windows.Forms.DataGridViewImageColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblAcccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabVenta.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.tabInventario.SuspendLayout();
            this.tabOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Inventario.Properties.Resources.usu_normal;
            this.pictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox7.Location = new System.Drawing.Point(12, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(72, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuarios";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.ImageIndex = 1;
            this.btnCerrar.ImageList = this.imageList1;
            this.btnCerrar.Location = new System.Drawing.Point(490, 453);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(228, 36);
            this.btnCerrar.TabIndex = 324;
            this.btnCerrar.Text = " Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.ImageIndex = 2;
            this.btnGuardar.ImageList = this.imageList1;
            this.btnGuardar.Location = new System.Drawing.Point(782, 453);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(277, 36);
            this.btnGuardar.TabIndex = 323;
            this.btnGuardar.Text = " Guardar Usuario";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 29;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagenCajero,
            this.usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.White;
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 122);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.RowTemplate.ReadOnly = true;
            this.dgvUsuarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(459, 364);
            this.dgvUsuarios.TabIndex = 326;
            this.dgvUsuarios.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(13, 83);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(459, 27);
            this.txtBusqueda.TabIndex = 325;
            // 
            // imagenCajero
            // 
            this.imagenCajero.HeaderText = "";
            this.imagenCajero.MinimumWidth = 6;
            this.imagenCajero.Name = "imagenCajero";
            this.imagenCajero.ReadOnly = true;
            this.imagenCajero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagenCajero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imagenCajero.Width = 60;
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario.HeaderText = "Nombre Usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
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
            this.btnDarBaja.Location = new System.Drawing.Point(665, 35);
            this.btnDarBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(160, 33);
            this.btnDarBaja.TabIndex = 328;
            this.btnDarBaja.Text = " Dar de baja";
            this.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarBaja.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.ImageIndex = 4;
            this.btnNuevo.ImageList = this.imageList1;
            this.btnNuevo.Location = new System.Drawing.Point(486, 34);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(171, 33);
            this.btnNuevo.TabIndex = 327;
            this.btnNuevo.Text = " Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(658, 118);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(318, 26);
            this.txtNombreCompleto.TabIndex = 332;
            this.txtNombreCompleto.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 331;
            this.label6.Text = "Nombre completo";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(658, 150);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 26);
            this.textBox2.TabIndex = 330;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(552, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 329;
            this.label7.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(658, 85);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 26);
            this.textBox1.TabIndex = 334;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 333;
            this.label2.Text = "Login";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabVenta);
            this.tabControl1.Controls.Add(this.tabClientes);
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Controls.Add(this.tabInventario);
            this.tabControl1.Controls.Add(this.tabOtros);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(486, 198);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 249);
            this.tabControl1.TabIndex = 335;
            // 
            // tabVenta
            // 
            this.tabVenta.Controls.Add(this.lstvVentas);
            this.tabVenta.ImageIndex = 5;
            this.tabVenta.Location = new System.Drawing.Point(4, 26);
            this.tabVenta.Margin = new System.Windows.Forms.Padding(4);
            this.tabVenta.Name = "tabVenta";
            this.tabVenta.Padding = new System.Windows.Forms.Padding(4);
            this.tabVenta.Size = new System.Drawing.Size(569, 219);
            this.tabVenta.TabIndex = 0;
            this.tabVenta.Text = "Ventas";
            this.tabVenta.UseVisualStyleBackColor = true;
            // 
            // lstvVentas
            // 
            this.lstvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvVentas.HideSelection = false;
            this.lstvVentas.Location = new System.Drawing.Point(4, 4);
            this.lstvVentas.Margin = new System.Windows.Forms.Padding(4);
            this.lstvVentas.Name = "lstvVentas";
            this.lstvVentas.Size = new System.Drawing.Size(561, 211);
            this.lstvVentas.TabIndex = 0;
            this.lstvVentas.UseCompatibleStateImageBehavior = false;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.lstvClientes);
            this.tabClientes.ImageIndex = 6;
            this.tabClientes.Location = new System.Drawing.Point(4, 26);
            this.tabClientes.Margin = new System.Windows.Forms.Padding(4);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(4);
            this.tabClientes.Size = new System.Drawing.Size(569, 217);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // lstvClientes
            // 
            this.lstvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvClientes.HideSelection = false;
            this.lstvClientes.Location = new System.Drawing.Point(4, 4);
            this.lstvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.lstvClientes.Name = "lstvClientes";
            this.lstvClientes.Size = new System.Drawing.Size(561, 209);
            this.lstvClientes.TabIndex = 1;
            this.lstvClientes.UseCompatibleStateImageBehavior = false;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.lstvProductos);
            this.tabProductos.ImageIndex = 7;
            this.tabProductos.Location = new System.Drawing.Point(4, 26);
            this.tabProductos.Margin = new System.Windows.Forms.Padding(4);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(4);
            this.tabProductos.Size = new System.Drawing.Size(569, 217);
            this.tabProductos.TabIndex = 2;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // lstvProductos
            // 
            this.lstvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvProductos.HideSelection = false;
            this.lstvProductos.Location = new System.Drawing.Point(4, 4);
            this.lstvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.lstvProductos.Name = "lstvProductos";
            this.lstvProductos.Size = new System.Drawing.Size(561, 209);
            this.lstvProductos.TabIndex = 2;
            this.lstvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // tabInventario
            // 
            this.tabInventario.Controls.Add(this.lstvInventario);
            this.tabInventario.ImageIndex = 8;
            this.tabInventario.Location = new System.Drawing.Point(4, 26);
            this.tabInventario.Margin = new System.Windows.Forms.Padding(4);
            this.tabInventario.Name = "tabInventario";
            this.tabInventario.Padding = new System.Windows.Forms.Padding(4);
            this.tabInventario.Size = new System.Drawing.Size(569, 217);
            this.tabInventario.TabIndex = 3;
            this.tabInventario.Text = "Inventario";
            this.tabInventario.UseVisualStyleBackColor = true;
            // 
            // lstvInventario
            // 
            this.lstvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvInventario.HideSelection = false;
            this.lstvInventario.Location = new System.Drawing.Point(4, 4);
            this.lstvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.lstvInventario.Name = "lstvInventario";
            this.lstvInventario.Size = new System.Drawing.Size(561, 209);
            this.lstvInventario.TabIndex = 3;
            this.lstvInventario.UseCompatibleStateImageBehavior = false;
            // 
            // tabOtros
            // 
            this.tabOtros.Controls.Add(this.lstvOtros);
            this.tabOtros.Location = new System.Drawing.Point(4, 26);
            this.tabOtros.Margin = new System.Windows.Forms.Padding(4);
            this.tabOtros.Name = "tabOtros";
            this.tabOtros.Padding = new System.Windows.Forms.Padding(4);
            this.tabOtros.Size = new System.Drawing.Size(569, 217);
            this.tabOtros.TabIndex = 4;
            this.tabOtros.Text = "Otros";
            this.tabOtros.UseVisualStyleBackColor = true;
            // 
            // lstvOtros
            // 
            this.lstvOtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvOtros.HideSelection = false;
            this.lstvOtros.Location = new System.Drawing.Point(4, 4);
            this.lstvOtros.Margin = new System.Windows.Forms.Padding(4);
            this.lstvOtros.Name = "lstvOtros";
            this.lstvOtros.Size = new System.Drawing.Size(561, 209);
            this.lstvOtros.TabIndex = 4;
            this.lstvOtros.UseCompatibleStateImageBehavior = false;
            // 
            // lblAcccion
            // 
            this.lblAcccion.BackColor = System.Drawing.Color.Transparent;
            this.lblAcccion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcccion.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAcccion.Location = new System.Drawing.Point(863, 36);
            this.lblAcccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcccion.Name = "lblAcccion";
            this.lblAcccion.Size = new System.Drawing.Size(196, 28);
            this.lblAcccion.TabIndex = 336;
            this.lblAcccion.Text = "MODIFICAR USUARIO";
            this.lblAcccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmUsusarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 494);
            this.Controls.Add(this.lblAcccion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmUsusarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ususarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabVenta.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.tabInventario.ResumeLayout(false);
            this.tabOtros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewImageColumn imagenCajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label lblAcccion;
    }
}