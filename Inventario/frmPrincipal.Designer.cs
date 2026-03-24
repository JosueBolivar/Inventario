namespace Inventario
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgb = new System.Windows.Forms.ToolStripProgressBar();
            this.lblAvance = new System.Windows.Forms.ToolStripStatusLabel();
            this.gruBarraHerramientasPrincipal = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCorte = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.gruBarraHerramientasPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado,
            this.pgb,
            this.lblAvance});
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 302;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.SystemColors.Control;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(32, 17);
            this.lblEstado.Text = "Listo";
            // 
            // pgb
            // 
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(100, 16);
            this.pgb.Visible = false;
            // 
            // lblAvance
            // 
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(24, 17);
            this.lblAvance.Text = "0/0";
            this.lblAvance.Visible = false;
            // 
            // gruBarraHerramientasPrincipal
            // 
            this.gruBarraHerramientasPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnReportes);
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnCorte);
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnConfiguracion);
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnInventario);
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnProductos);
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnClientes);
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnVentas);
            this.gruBarraHerramientasPrincipal.Controls.Add(this.btnSalir);
            this.gruBarraHerramientasPrincipal.Location = new System.Drawing.Point(0, 57);
            this.gruBarraHerramientasPrincipal.Name = "gruBarraHerramientasPrincipal";
            this.gruBarraHerramientasPrincipal.Size = new System.Drawing.Size(1028, 47);
            this.gruBarraHerramientasPrincipal.TabIndex = 303;
            this.gruBarraHerramientasPrincipal.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "window-close-4.png");
            this.imageList1.Images.SetKeyName(1, "cart-add.png");
            this.imageList1.Images.SetKeyName(2, "view-list-multicolumn-4.png");
            this.imageList1.Images.SetKeyName(3, "go-bottom-7.png");
            this.imageList1.Images.SetKeyName(4, "calculator-edit.png");
            this.imageList1.Images.SetKeyName(5, "distribute-horizontal-center.png");
            this.imageList1.Images.SetKeyName(6, "format-list-ordered.png");
            this.imageList1.Images.SetKeyName(7, "wrench-orange.png");
            this.imageList1.Images.SetKeyName(8, "chart-bar-edit.png");
            this.imageList1.Images.SetKeyName(9, "group.png");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ayuda";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::Inventario.Properties.Resources.linea_Y;
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 61);
            this.panel3.TabIndex = 305;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::Inventario.Properties.Resources.linea_Y;
            this.panel2.Controls.Add(this.lblNombreUsuario);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(800, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 61);
            this.panel2.TabIndex = 304;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNombreUsuario.Location = new System.Drawing.Point(5, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(216, 23);
            this.lblNombreUsuario.TabIndex = 103;
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Black;
            this.btnMinimizar.ImageIndex = 3;
            this.btnMinimizar.ImageList = this.imageList1;
            this.btnMinimizar.Location = new System.Drawing.Point(198, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 23);
            this.btnMinimizar.TabIndex = 102;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Le atiende:";
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.ImageIndex = 8;
            this.btnReportes.ImageList = this.imageList1;
            this.btnReportes.Location = new System.Drawing.Point(665, 9);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(99, 33);
            this.btnReportes.TabIndex = 108;
            this.btnReportes.Text = " Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnReportes, "Reportes");
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnCorte
            // 
            this.btnCorte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCorte.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCorte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCorte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorte.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorte.ForeColor = System.Drawing.Color.Black;
            this.btnCorte.ImageIndex = 5;
            this.btnCorte.ImageList = this.imageList1;
            this.btnCorte.Location = new System.Drawing.Point(583, 9);
            this.btnCorte.Name = "btnCorte";
            this.btnCorte.Size = new System.Drawing.Size(76, 33);
            this.btnCorte.TabIndex = 107;
            this.btnCorte.Text = " Corte";
            this.btnCorte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCorte, "Corte");
            this.btnCorte.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.btnConfiguracion.ImageIndex = 7;
            this.btnConfiguracion.ImageList = this.imageList1;
            this.btnConfiguracion.Location = new System.Drawing.Point(461, 9);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(116, 33);
            this.btnConfiguracion.TabIndex = 106;
            this.btnConfiguracion.Text = " Configuración";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnConfiguracion, "Configuración");
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Black;
            this.btnInventario.ImageIndex = 6;
            this.btnInventario.ImageList = this.imageList1;
            this.btnInventario.Location = new System.Drawing.Point(337, 9);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(118, 33);
            this.btnInventario.TabIndex = 105;
            this.btnInventario.Text = " F4 Inventario";
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnInventario, "Inventario");
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.ImageIndex = 2;
            this.btnProductos.ImageList = this.imageList1;
            this.btnProductos.Location = new System.Drawing.Point(220, 9);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(111, 33);
            this.btnProductos.TabIndex = 104;
            this.btnProductos.Text = " F3 Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnProductos, "Productos");
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.ImageIndex = 9;
            this.btnClientes.ImageList = this.imageList1;
            this.btnClientes.Location = new System.Drawing.Point(113, 9);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(101, 33);
            this.btnClientes.TabIndex = 103;
            this.btnClientes.Text = " F2 Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnClientes, "Clientes");
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.ImageIndex = 1;
            this.btnVentas.ImageList = this.imageList1;
            this.btnVentas.Location = new System.Drawing.Point(6, 9);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(101, 33);
            this.btnVentas.TabIndex = 102;
            this.btnVentas.Text = " F1 Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnVentas, "Venta de productos");
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.ImageIndex = 0;
            this.btnSalir.ImageList = this.imageList1;
            this.btnSalir.Location = new System.Drawing.Point(946, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 33);
            this.btnSalir.TabIndex = 101;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gruBarraHerramientasPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gruBarraHerramientasPrincipal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripProgressBar pgb;
        private System.Windows.Forms.ToolStripStatusLabel lblAvance;
        private System.Windows.Forms.GroupBox gruBarraHerramientasPrincipal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCorte;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnReportes;
    }
}