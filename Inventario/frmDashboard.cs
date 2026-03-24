using Inventario.ControlesUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmDashboard : Form
    {
        bool sidebarExpand = true;

        usrctrlDashboard ucDashboard = new usrctrlDashboard();
        usrctrlCliente ucCliente = new usrctrlCliente();
        usrctrlProducto ucProducto = new usrctrlProducto();
        usrctrlSettings ucSettings = new usrctrlSettings();

        public frmDashboard()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Funciones.G_LANGUAGE);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Funciones.G_LANGUAGE);
            InitializeComponent();
        }

        private void ocultarTodosControles()
        {
            ucDashboard.Visible = false;
            ucCliente.Visible = false;
            ucProducto.Visible = false;
            ucSettings.Visible = false;
        }

        private void efectoComportamientoControl(string nombreControl, int comportamiento)
        {
            // 1 = maximiza control
            // 2 = minimiza control

            if (comportamiento == 1) {
                Control[] myControl1 = this.Controls.Find(nombreControl, false);
                if (myControl1.Length > 0) {
                    myControl1.First().Left -= sidebar.MaximumSize.Width - sidebar.MinimumSize.Width;
                }
            }

            if (comportamiento == 2) {
                Control[] myControl1 = this.Controls.Find(nombreControl, false);
                if (myControl1.Length > 0) {
                    myControl1.First().Left = sidebar.MaximumSize.Width;
                }
            }   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            renderizar();
        }

        private void renderizar()
        {
            lblNombreUsuario.Text = Funciones.G_NOMBRE_USUARIO;

            switch (Funciones.G_LANGUAGE)
            {
                case "en-US":
                    picIdioma.Image = imageList1.Images[1];
                    break;
                default:
                    picIdioma.Image = imageList1.Images[0];
                    break;
            }
            
            topPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                    efectoComportamientoControl("ucDashboard", 1);
                    efectoComportamientoControl("ucCliente", 1);
                    efectoComportamientoControl("ucProducto", 1);
                    efectoComportamientoControl("ucSettings", 1);
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();

                    efectoComportamientoControl("ucDashboard", 2);
                    efectoComportamientoControl("ucCliente", 2);
                    efectoComportamientoControl("ucProducto", 2);
                    efectoComportamientoControl("ucSettings", 2);
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void frmDashboard_Shown(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = Funciones.G_NOMBRE_USUARIO;
            switch (Funciones.G_LANGUAGE)
            {
                case "en-US":
                    picIdioma.Image = imageList1.Images[1];
                    break;
                default:
                    picIdioma.Image = imageList1.Images[0];
                    break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ocultarTodosControles();
            Control[] myControl1 = this.Controls.Find("ucDashboard", false);
            if (myControl1.Length == 0)
            {                
                ucDashboard.Name = "ucDashboard";
                ucDashboard.Top = topPanel.Height;
                ucDashboard.Left += sidebar.Width;
                ucDashboard.Width = this.Width - sidebar.Width;
                ucDashboard.Height = this.Height - topPanel.Height;
                this.Controls.Add(ucDashboard);
                ucDashboard.Visible = true;

            } else {
                ucDashboard.Visible = true;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ocultarTodosControles();
            Control[] myControl1 = this.Controls.Find("ucCliente", false);
            if (myControl1.Length == 0)
            {
                ucCliente.Name = "ucCliente";
                ucCliente.Top = topPanel.Height;
                ucCliente.Left += sidebar.Width;
                this.Controls.Add(ucCliente);
                ucCliente.Visible = true;

            } else {
                ucCliente.Visible = true;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ocultarTodosControles();
            Control[] myControl1 = this.Controls.Find("ucProducto", false);
            if (myControl1.Length == 0)
            {
                ucProducto.Name = "ucProducto";
                ucProducto.Top = topPanel.Height;
                ucProducto.Left += sidebar.Width;
                this.Controls.Add(ucProducto);
                ucProducto.Visible = true;

            } else {
                ucProducto.Visible = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ocultarTodosControles();
            Control[] myControl1 = this.Controls.Find("ucSettings", false);
            if (myControl1.Length == 0)
            {
                ucSettings.Name = "ucSettings";
                ucSettings.Top = topPanel.Height;
                ucSettings.Left += sidebar.Width;
                this.Controls.Add(ucSettings);
                ucSettings.Visible = true;

            } else {
                ucSettings.Visible = true;
            }
        }
    }
}
