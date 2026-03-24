using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    static class Program
    {
        ///<summary>
        ///Punto de entrada principal para la aplicación.
        //</summary>
        [STAThread]

        /*public static string G_TITULO_PROGRAMA = "JPOS - Punto de Venta";
        public static string G_LOGIN_USUARIO = string.Empty;
        public static string G_NOMBRE_USUARIO = string.Empty;*/

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());

            bool unica_instancia = true;
            Mutex mtx = null;

            //Acciones
            const int K_LOGUEO_INICIAL = 1;

            //mtx = new Mutex(true, "form_ventas", out unica_instancia);
            mtx = new Mutex(true, "frmLogin", out unica_instancia);
            if (unica_instancia)
            {
                //Application.Run(new form_ventas(caja, vendedor, codigo_venta));
                Application.Run(new frmLogin(K_LOGUEO_INICIAL, 0, 0));
            }
        }
    }
}
