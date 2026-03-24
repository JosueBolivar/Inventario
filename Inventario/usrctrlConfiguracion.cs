using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class usrctrlConfiguracion : UserControl
    {
        usrctrlCajero ucCajero = new usrctrlCajero();
        public usrctrlConfiguracion()
        {
            InitializeComponent();
        }

        private void usrctrlConfiguracion_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ucCajero.Visible = false;
            listView1.Visible = true;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string itemSeleccionado = string.Empty;
            if (listView1.SelectedItems.Count > 0) {
                ListViewItem listItem = listView1.SelectedItems[0];
                itemSeleccionado = listItem.Text;
            }

            if (itemSeleccionado == "Cajeros") {
                Control[] myControl1 = this.Controls.Find("ucCajero", false);
                if (myControl1.Length == 0) {
                    ucCajero.Location = new System.Drawing.Point(2, 170); 
                    ucCajero.Name = "ucCajero";
                    this.Controls.Add(ucCajero);
                    listView1.Visible = false;
                    ucCajero.BringToFront();
                    ucCajero.Visible = true;
                } else {
                    ucCajero.BringToFront();
                    listView1.Visible = false;
                    ucCajero.Visible = true;
                }
            }
        }
    }
}
