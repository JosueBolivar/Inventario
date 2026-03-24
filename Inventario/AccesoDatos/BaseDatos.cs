using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventario.Negocio;

namespace Inventario.AccesoDatos
{
    public class BaseDatos
    {
        //string connstr = "Password=admin;Persist Security Info=True;User ID=admin;Initial Catalog=BaseCPUPrint;Data Source=INFO_JBOLIVAR\\SQLEXPRESS";
        //SqlConnection CN = new SqlConnection("Password=;Persist Security Info=True;User ID=admin;Initial Catalog=BaseCPUPrint;Data Source=INFO_JBOLIVAR\\SQLEXPRESS");
        public string mensajeError = string.Empty;

        #region CONEXION BASE DATOS
        public string sConexion(string usuario, string password)
        {
            //return "Data Source=INFO_JBOLIVAR\\SQLEXPRESS;Initial Catalog=databasePOS;Persist Security Info=True;User ID=" + usuario + ";Password=" + password;
            //return "Password=" + password + ";Persist Security Info=True;User ID=" + usuario + ";Initial Catalog=databasePOS;Data Source=JOSUE";
            //return "Data Source=LAPTOP-TJGI40V0\\SQLEXPRESS01;Initial Catalog=DBInventory;Persist Security Info=True;User ID=" + usuario + ";Password=" + password;
            return "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DBInventory;Trusted_Connection=True;TrustServerCertificate=True;";
        }
        #endregion

        #region USUARIO
        public DataTable LdObtenerUsuario(Usuario oUsu)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("EXEC dbo.BuscaUsuarioPorLogin ");
                sb.Append("'" + oUsu.Login + "',");     //@pLogin varchar (50),
                sb.Append("'" + oUsu.Password + "'");   //@pPassword varchar(50)

                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), sConexion(oUsu.Login, oUsu.Password));
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0) {
                    return dt;
                } else {
                    return null;
                }
            }
            catch (Exception ex)
            {
                mensajeError = "Error al obtener Usuario: " + sb.ToString() + " " + ex.Message;
                return null;
            }
        }

        public DataTable LdListarUsuarios()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("EXEC dbo.ListarUsuarios ");

                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), sConexion("admin", "1"));
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0) {
                    return dt;
                } else {
                    return null;
                }
            }
            catch (Exception ex)
            {
                mensajeError = "Error al listar usuarios: " + sb.ToString() + " " + ex.Message;
                return null;
            }
        }
        #endregion

        #region CAJEROS
        public DataTable LdObtenerCajero(Cajero oCajero)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("EXEC dbo.BuscaUsuarioPorLogin ");
                sb.Append("'" + oCajero.Login + "',");     //@pLogin varchar (50),
                sb.Append("'" + oCajero.Password + "'");   //@pPassword varchar(50)

                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), sConexion(oCajero.Login, oCajero.Password));
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0) {
                    return dt;
                } else {
                    return null;
                }
            }
            catch (Exception ex)
            {
                mensajeError = "Error al obtener Usuario: " + sb.ToString() + " " + ex.Message;
                return null;
            }
        }

        public DataTable LdListarCajeros()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append("EXEC dbo.ListarUsuarios ");

                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), sConexion("admin", "1"));
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0) {
                    return dt;
                } else {
                    return null;
                }
            }
            catch (Exception ex)
            {
                mensajeError = "Error al listar usuarios: " + sb.ToString() + " " + ex.Message;
                return null;
            }
        }
        #endregion
    }
}
