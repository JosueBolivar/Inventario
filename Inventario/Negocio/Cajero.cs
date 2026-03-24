using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.AccesoDatos;

namespace Inventario.Negocio
{
    public class Cajero
    {
        public string mensajeError = string.Empty;
        string _login = string.Empty;
        string _pass = string.Empty;
        string _nombre = string.Empty;
        string _apellido = string.Empty;
        int _perfil = 0;
        string _fechaAlta = string.Empty;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Password
        {
            get { return _pass; }
            set { _pass = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        public string FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }

        public DataTable LnObtenerCajero(Cajero oCajero)
        {
            DataTable dt = new DataTable();
            BaseDatos dbConexion = new BaseDatos();
            dt = dbConexion.LdObtenerCajero(oCajero);
            mensajeError = dbConexion.mensajeError;
            return dt;
        }

        public DataTable LnListarCajeros()
        {
            DataTable dt = new DataTable();
            BaseDatos dbConexion = new BaseDatos();
            dt = dbConexion.LdListarCajeros();
            mensajeError = dbConexion.mensajeError;
            return dt;
        }
    }
}
