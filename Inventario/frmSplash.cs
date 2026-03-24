using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            lblVersion.Text = Application.ProductVersion.ToString();

            if (!timer1.Enabled)
                timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            Application.DoEvents();
            lblInfo.Text = string.Empty;

            this.lblInfo.Text = "Comprobando directorios...";
            Application.DoEvents();
            //compruebaDirectorios();
            this.lblInfo.Refresh();

            //GPS_Lectura_Desktop.Program.G_VersionAppDispositivo = obtenerVersionAppDispositivo();

            Thread.Sleep(120);

            this.lblInfo.Text = "Revisando conexión BD...";
            this.lblInfo.Refresh();
            Thread.Sleep(120);
            //this.PictureBox3.Refresh();

            this.lblInfo.Text = "Listo...";
            this.lblInfo.Refresh();
            Thread.Sleep(1520);
            //this.PictureBox3.Refresh();

            this.lblInfo.Text = "Abriendo aplicación...";
            this.lblInfo.Refresh();
            Thread.Sleep(1380);
            //this.PictureBox3.Refresh();

            //this.lblInfo.Text = "Bienvenido " + loginUsuario;
            //this.lblInfo.Refresh();
            //Thread.Sleep(600);
            //this.PictureBox3.Refresh();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
