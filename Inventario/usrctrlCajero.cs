using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario.Negocio;

namespace Inventario
{
    public partial class usrctrlCajero : UserControl
    {
        Funciones oFN = new Funciones();
        Usuario oUsu = new Usuario();
        public usrctrlCajero()
        {
            InitializeComponent();

            oFN.defineEventosFocus(this);
            txtLogin.Focus();
        }
    }
}
