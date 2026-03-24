using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;

namespace Inventario
{
    public class Funciones
    {
        public static string G_TITULO_PROGRAMA = "JABA - Inventory";
        public static string G_LOGIN_USUARIO = string.Empty;
        public static string G_NOMBRE_USUARIO = string.Empty;
        public static string G_PASS_USUARIO = string.Empty;
        public static string G_LANGUAGE = string.Empty;


        StringUtility stringUtility = new StringUtility();
        public string FormatFechaSQL(string fecha)
        {
            fecha = fecha.Replace("/", "-");
            string[] aFec = fecha.Split('-');
            string nfecha = "";
            for (int i = 2; i > -1; i--)
            {
                nfecha += aFec[i].ToString() + "-";
            }
            nfecha = nfecha.Substring(0, nfecha.Length - 1);

            return nfecha;
        }

        public string FormatNumber(double numero, int decimales)
        {
            NumberFormatInfo oNum = new NumberFormatInfo();
            oNum.NumberDecimalSeparator = ",";
            oNum.NumberGroupSeparator = ".";
            oNum.NumberDecimalDigits = decimales;
            return String.Format(oNum, "{0:n}", numero);
        }

        public string FormatNumber(string texto, int decimales)
        {
            double numero = Convert.ToDouble(texto);
            return FormatNumber(numero, decimales);
        }

        public string FormatNumber(double numero)
        {
            return FormatNumber(numero, 0);
        }

        public string FormatNumber(string texto)
        {
            return FormatNumber(Convert.ToDouble(texto));
        }

        public bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public bool IsDate(string inputDate)
        {
            bool isDate = true;

            try
            {
                DateTime dt = DateTime.Parse(inputDate);
            }
            catch
            {
                isDate = false;
            }

            return isDate;
        }

        public void cambiarColor(TextBox campo, string accion)
        {
            if (accion == "Enter")
            {
                campo.BackColor = Color.LemonChiffon;
            }
            else
            {
                campo.BackColor = Color.White;
            }

        }

        public void cambiarColor(TextBox campo, string accion, Color color)
        {
            if (color != null) {
                campo.BackColor = color;
            } else {
                if (accion == "Enter") {
                    campo.BackColor = Color.LemonChiffon;
                } else {
                    campo.BackColor = Color.White;
                }
            }
        }

        public string Right(string sValue, int iMaxLength)
        {
            //Check if the value is valid
            if (string.IsNullOrEmpty(sValue)) {
                //Set valid empty string as string could be null
                sValue = string.Empty;
            } else if (sValue.Length > iMaxLength) {
                //Make the string no longer than the max length
                sValue = sValue.Substring(sValue.Length - iMaxLength, iMaxLength);
            }

            //Return the string
            return sValue;
        }

        public string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }

        public string diferenciaFechas(string fecha1, string fecha2, string indicadorDiferencia)
        {
            string valorDiferencia = "0";
            try
            {
                string[] afec1 = fecha1.Split('-');
                string ano1 = afec1[2].ToString();
                string mes1 = afec1[1].ToString();
                string dia1 = afec1[0].ToString();
                DateTime fecha1Aux = new DateTime(int.Parse(ano1), int.Parse(mes1), int.Parse(dia1));

                string[] afec2 = fecha2.Split('-');
                string ano2 = afec2[2].ToString();
                string mes2 = afec2[1].ToString();
                string dia2 = afec2[0].ToString();
                DateTime fecha2Aux = new DateTime(int.Parse(ano2), int.Parse(mes2), int.Parse(dia2));

                TimeSpan tiempoTranscurrido;
                tiempoTranscurrido = fecha2Aux.Subtract(fecha1Aux);

                if (indicadorDiferencia == "d") {
                    valorDiferencia = tiempoTranscurrido.TotalDays.ToString();
                }

                if (indicadorDiferencia == "h") {
                    valorDiferencia = (tiempoTranscurrido.TotalHours).ToString();
                }

                return valorDiferencia;
            }
            catch (Exception ex)
            {
                valorDiferencia = ex.Message;
                return valorDiferencia;
            }
        }

        public string eliminarCaracteresEspeciales(string entrada)
        {
            string salida = entrada;
            if (!salida.Trim().Equals(""))
                salida = stringUtility.removeInvalidCharacters(salida, stringUtility.RegexPattern_Address);
            if (entrada.Trim().Length == 0)
                salida = "0";
            return salida;
        }

        public List<string[]> leerCSV(string path, char separador, bool transformarMayuscula)
        {

            List<string[]> parsedData = new List<string[]>();
            string[] vectorLinea = new string[32];

            using (StreamReader readFile = new StreamReader(path))
            {
                string line;
                string[] row;

                while ((line = readFile.ReadLine()) != null)
                {
                    if (transformarMayuscula) {
                        line = line.ToUpper();
                    }

                    if ((!line.Contains("DETALLE")) && (!string.IsNullOrEmpty(line))) {
                        row = line.Split(separador);
                        parsedData.Add(row);
                    }
                }
            }
            return parsedData;
        }

        #region Tratamiento de caja de texto
        public static List<T> GetSubControlsOf<T>(Control parent) where T : class
        {
            var myCtrls = new List<T>();

            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl.GetType() == typeof(T) || ctrl.GetType().IsInstanceOfType(typeof(T))) {
                    myCtrls.Add(ctrl as T);
                } else if (ctrl.HasChildren) {
                    var childs = GetSubControlsOf<T>(ctrl);
                    if (childs.Any()) myCtrls.AddRange(childs);
                }
            }

            return myCtrls;
        }

        public void defineEventosFocus(Form nameFormulario)
        {
            foreach (var textbox in GetSubControlsOf<TextBox>(nameFormulario))
            {
                textbox.Enter += new EventHandler(cambiarColorContieneFoco);
                textbox.Leave += new EventHandler(cambiarColorPerdioFoco);
            }
        }

        public void defineEventosFocus(UserControl nameFormulario)
        {
            foreach (var textbox in GetSubControlsOf<TextBox>(nameFormulario))
            {
                textbox.Enter += new EventHandler(cambiarColorContieneFoco);
                textbox.Leave += new EventHandler(cambiarColorPerdioFoco);
            }
        }

        private void cambiarColorContieneFoco(object sender, EventArgs e)
        {
            TextBox cajaTexto = ((TextBox)sender);
            if (!cajaTexto.ReadOnly)
                cajaTexto.BackColor = Color.LemonChiffon;
        }

        private void cambiarColorPerdioFoco(object sender, EventArgs e)
        {
            TextBox cajaTexto = ((TextBox)sender);
            if (!cajaTexto.ReadOnly)
                cajaTexto.BackColor = Color.White;
        }


        /*public void mostrarFormBuscar(string campoCodigo, string campoDescripcion, string nombreTabla, string condicion, string campoOrden,
                                       string nombreTituloBusqueda, TextBox codigoSalida, Label descripcionSalida, Label advertenciaFalta)
        {
            frmBuscar fAyuda = new frmBuscar(campoCodigo, campoDescripcion, nombreTabla, condicion, campoOrden, nombreTituloBusqueda);
            fAyuda.ShowDialog();
            if (string.IsNullOrEmpty(Program.G_CodigoBusqueda)) {
                if (descripcionSalida != null) { 
                    descripcionSalida.Text = string.Empty;
                    advertenciaFalta.Visible = true;
                }

            } else {
                codigoSalida.Text = Program.G_CodigoBusqueda;
                if (descripcionSalida != null) {
                    descripcionSalida.Text = Program.G_DescripcionBusqueda;
                    advertenciaFalta.Visible = false;
                }
            }

            Program.G_CodigoBusqueda = string.Empty;
            Program.G_DescripcionBusqueda = string.Empty;
        }*/
        #endregion

        #region Notificacion via email
        public void notificarUsuarioViaEmail(string mensaje)
        {
            //string[] destinatarios = { "informatica@chilepost.cl", "amedina@chilepost.cl", "s_aguas@chilepost.cl" };
            string[] destinatarios = { "jbolivar@chilepost.cl" };
            string asunto = "Cortes Programados - Sistema de Alertas";
            string cuerpo = mensaje;
            System.Net.Mail.MailPriority prioridadMail = System.Net.Mail.MailPriority.Normal;

            CommonLibrary.Mail email = new Mail();
            bool correoEnviado = false;
            if (email.sendMail("10.10.10.15",25, "administrador@chilepost.cl", destinatarios, asunto, mensaje, prioridadMail)) {
                correoEnviado = true;
            } else {
                MessageBox.Show(email.error.getExceptionMessage());
            }
        }
        #endregion
    }
}
