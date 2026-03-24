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
    public partial class usrctrlProducto : UserControl
    {
        public usrctrlProducto()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Funciones.G_LANGUAGE);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Funciones.G_LANGUAGE);
            InitializeComponent();
        }
    }
}
