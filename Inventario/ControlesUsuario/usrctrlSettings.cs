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

namespace Inventario.ControlesUsuario
{
    public partial class usrctrlSettings : UserControl
    {
        public usrctrlSettings()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Funciones.G_LANGUAGE);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Funciones.G_LANGUAGE);
            InitializeComponent();
        }

        private void picUsuarios_Click(object sender, EventArgs e)
        {
            Formularios.frmUsusarios fUsuarios = new Formularios.frmUsusarios();
            fUsuarios.Show();
        }
    }
}
