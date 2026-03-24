using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmPrincipal : Form
    {
        usrctrlVentas ucVentas = new usrctrlVentas();
        usrctrlClientes ucClientes = new usrctrlClientes();
        usrctrlProductos ucProductos = new usrctrlProductos();
        usrctrlInventario ucInventario = new usrctrlInventario();
        usrctrlConfiguracion ucConfiguracion = new usrctrlConfiguracion();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Control[] myControl1 = this.Controls.Find("ucVentas", false);
            if (myControl1.Length == 0) {

                ucClientes.Visible = false;
                ucProductos.Visible = false;
                ucInventario.Visible = false;
                ucConfiguracion.Visible = false;

                ucVentas.Name = "ucVentas";
                ucVentas.Dock = DockStyle.Fill;
                this.Controls.Add(ucVentas);
                ucVentas.Visible = true;
            } else {
                ucClientes.Visible = false;
                ucProductos.Visible = false;
                ucInventario.Visible = false;
                ucConfiguracion.Visible = false;
                ucVentas.Visible = true;
            }

            btnVentas.Enabled = false;
            btnClientes.Enabled = true;
            btnProductos.Enabled = true;
            btnInventario.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnCorte.Enabled = true;
            btnReportes.Enabled = true;

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Control[] myControl1 = this.Controls.Find("ucClientes", false);
            if (myControl1.Length == 0) {
                ucVentas.Visible = false;
                ucProductos.Visible = false;
                ucInventario.Visible = false;
                ucConfiguracion.Visible = false;

                ucClientes.Name = "ucClientes";
                ucClientes.Dock = DockStyle.Fill;
                this.Controls.Add(ucClientes);
                ucClientes.Visible = true;
            } else {
                ucVentas.Visible = false;
                ucProductos.Visible = false;
                ucInventario.Visible = false;
                ucConfiguracion.Visible = false;
                ucClientes.Visible = true;
            }

            btnClientes.Enabled = false;
            btnVentas.Enabled = true;
            btnProductos.Enabled = true;
            btnInventario.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnCorte.Enabled = true;
            btnReportes.Enabled = true;

        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = Funciones.G_NOMBRE_USUARIO;            
            Control[] myControl1 = this.Controls.Find("ucVentas", false);
            if (myControl1.Length == 0) {

                ucVentas.Name = "ucVentas";
                ucVentas.Dock = DockStyle.Fill;
                this.Controls.Add(ucVentas);
                ucVentas.Visible = true;
            } else {
                ucVentas.Visible = true;
            }
            btnVentas.Enabled = false;
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) {
                btnVentas_Click(0, e);
            }

            if (e.KeyCode == Keys.F2) {
                btnClientes_Click(0, e);
            }

            if (e.KeyCode == Keys.F3) {
                btnProductos_Click(0, e);
            }

            if (e.KeyCode == Keys.F4) {
                btnInventario_Click(0, e);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            Control[] myControl1 = this.Controls.Find("ucProductos", false);
            if (myControl1.Length == 0) {
                ucVentas.Visible = false;
                ucClientes.Visible = false;
                ucInventario.Visible = false;
                ucConfiguracion.Visible = false;

                ucProductos.Name = "ucProductos";
                ucProductos.Dock = DockStyle.Fill;
                this.Controls.Add(ucProductos);
                ucProductos.Visible = true;
            } else {
                ucVentas.Visible = false;
                ucClientes.Visible = false;
                ucInventario.Visible = false;
                ucConfiguracion.Visible = false;
                ucProductos.Visible = true;
            }
            this.ResumeLayout();

            btnProductos.Enabled = false;
            btnVentas.Enabled = true;
            btnClientes.Enabled = true;
            btnInventario.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnCorte.Enabled = true;
            btnReportes.Enabled = true;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            Control[] myControl1 = this.Controls.Find("ucInventario", false);
            if (myControl1.Length == 0) {
                ucVentas.Visible = false;
                ucClientes.Visible = false;
                ucProductos.Visible = false;
                ucConfiguracion.Visible = false;

                ucInventario.Name = "ucInventario";
                ucInventario.Dock = DockStyle.Fill;
                this.Controls.Add(ucInventario);
                ucInventario.Visible = true;
            } else {
                ucVentas.Visible = false;
                ucClientes.Visible = false;
                ucProductos.Visible = false;
                ucConfiguracion.Visible = false;
                ucInventario.Visible = true;
            }
            this.ResumeLayout();

            btnInventario.Enabled = false;
            btnProductos.Enabled = true;
            btnVentas.Enabled = true;
            btnClientes.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnCorte.Enabled = true;
            btnReportes.Enabled = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            Control[] myControl1 = this.Controls.Find("ucConfiguracion", false);
            if (myControl1.Length == 0) {
                ucVentas.Visible = false;
                ucClientes.Visible = false;
                ucProductos.Visible = false;
                ucInventario.Visible = false;

                ucConfiguracion.Name = "ucConfiguracion";
                ucConfiguracion.Dock = DockStyle.Fill;
                this.Controls.Add(ucConfiguracion);
                ucConfiguracion.Visible = true;
            } else {
                ucVentas.Visible = false;
                ucClientes.Visible = false;
                ucProductos.Visible = false;
                ucInventario.Visible = false;
                ucConfiguracion.Visible = true;
            }
            this.ResumeLayout();

            btnConfiguracion.Enabled = false;
            btnInventario.Enabled = true;
            btnProductos.Enabled = true;
            btnVentas.Enabled = true;
            btnClientes.Enabled = true;
            btnCorte.Enabled = true;
            btnReportes.Enabled = true;

        }
    }
}
