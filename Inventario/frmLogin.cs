using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Negocio;

namespace Inventario
{
    public partial class frmLogin : Form
    {
        string errorDatosSQL = string.Empty;
        string nombreModulo = " - Login";
        Funciones oFN = new Funciones();
        Usuario oUsu = new Usuario();

        int Accion;
        int Reporte;
        int FilaProductoEliminar;

        //Acciones
        const int K_LOGUEO_INICIAL = 1;
        const int K_ELIMINAR_PRODUCTO_GRILLA = 10;
        const int K_EMITIR_REPORTE = 11;
        const int K_LIMPIAR_GRILLA_PRODUCTOS = 15;

        public frmLogin(int Accion, int Reporte, int FilaEliminar)
        {
            InitializeComponent();
            this.Text = Funciones.G_TITULO_PROGRAMA + " " + Application.ProductVersion.ToString() + nombreModulo;

            this.Accion = Accion;
            this.Reporte = Reporte;
            this.FilaProductoEliminar = FilaEliminar;

            frmSplash fsplash = new frmSplash();
            fsplash.ShowDialog();
            if (fsplash.DialogResult == System.Windows.Forms.DialogResult.OK) {
                fsplash.Close();
                fsplash.Dispose();
            }
            oFN.defineEventosFocus(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboUsuario.Text.Trim())) {                

                DataTable dt = new DataTable();
                oUsu.Login = cboUsuario.Text.Trim();
                oUsu.Password = txtPass.Text.Trim();
                dt = oUsu.LnObtenerUsuario(oUsu);
                errorDatosSQL = oUsu.mensajeError;

                if (dt != null) {
                    this.Hide();
                    Funciones.G_LOGIN_USUARIO = dt.Rows[0]["usu_login"].ToString();
                    Funciones.G_PASS_USUARIO = dt.Rows[0]["usu_password"].ToString();
                    Funciones.G_NOMBRE_USUARIO = dt.Rows[0]["usu_nombre_completo"].ToString();
                    //frmPrincipal fPrincipal = new frmPrincipal();
                    //fPrincipal.ShowDialog();
                    frmDashboard fDash = new frmDashboard();
                    fDash.ShowDialog();

                    this.Dispose();

                } else {
                    pnlAviso.Visible = true;
                    Funciones.G_LOGIN_USUARIO = string.Empty;
                    Funciones.G_NOMBRE_USUARIO = string.Empty;
                    Funciones.G_PASS_USUARIO = string.Empty;
                    lblEstado.ForeColor = System.Drawing.Color.Red;
                    lblEstado.Text = "Usuario o contraseña incorrectos. " +  errorDatosSQL;
                    cboUsuario.Focus();
                }

            } else {
                pnlAviso.Visible = true;
                Funciones.G_LOGIN_USUARIO = string.Empty;
                Funciones.G_NOMBRE_USUARIO = string.Empty;
                Funciones.G_PASS_USUARIO = string.Empty;
                lblEstado.ForeColor = System.Drawing.Color.Red;
                lblEstado.Text = "Ingrese un usuario por favor.";
                cboUsuario.Focus();
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                cboIdioma.SelectedIndex = 0;

                DataTable dt = oUsu.LnListarUsuarios();
                if (dt != null) {
                    if (dt.Rows.Count > 0) {
                        for (int i = 0; i < dt.Rows.Count; i++) {
                            cboUsuario.Items.Add(dt.Rows[i]["usu_login"].ToString());
                        }
                        if (cboUsuario.Items.Count > 0) {
                            cboUsuario.SelectedIndex = 0;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(oUsu.mensajeError)) {
                    pnlAviso.Visible = true;
                    lblEstado.ForeColor = System.Drawing.Color.Red;
                    lblEstado.Text = oUsu.mensajeError;
                }
            }
            catch (Exception ex)
            {
                lblEstado.Text = "Error: " + ex.Message;
            }

            cboUsuario.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                btnEntrar_Click(0, e);
            }
        }

        private void cboUsuario_TextChanged(object sender, EventArgs e)
        {
            if (cboUsuario.Text.Length == 0) {
                pnlAviso.Visible = false;
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(0, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }

        }


        private void cboIdioma_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var cbo = sender as ComboBox;
            Color foreColor = e.ForeColor;

            if (e.State.HasFlag(DrawItemState.Selected) && !(e.State.HasFlag(DrawItemState.ComboBoxEdit)))
            {
                e.DrawBackground();
                e.DrawFocusRectangle(); // <= could be removed for a cleaner rendering
            }
            else
            {
                using (var brush = new SolidBrush(cbo.BackColor))
                {
                    var rect = e.Bounds;
                    rect.Inflate(1, 1);
                    e.Graphics.FillRectangle(brush, rect);
                }
                foreColor = cbo.ForeColor;
            }
            TextRenderer.DrawText(e.Graphics, cbo.GetItemText(cbo.Items[e.Index]), e.Font,
                new Point(e.Bounds.Height + 10, e.Bounds.Y), foreColor);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawImage(imageList3.Images[e.Index],
                                 new Rectangle(e.Bounds.Location,
                                 new Size(e.Bounds.Height - 2, e.Bounds.Height - 2)));
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboIdioma.SelectedIndex)
            {
                case 0:
                    Funciones.G_LANGUAGE = "es-ES";
                    break;

                case 1:
                    Funciones.G_LANGUAGE = "en-US";
                    break;

            }
        }
    }
}
