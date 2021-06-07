using Newtonsoft.Json;
using ProyectoFinal.Class.Login_And_LogOut;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Security;
using System.Web.UI.WebControls;
using BC = BCrypt.Net.BCrypt;

namespace ProyectoFinal
{
    public partial class Login : System.Web.UI.Page
    {
        static List<Usuario> usuarios = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = Server.MapPath("Usuarios.json");
            if(File.Exists(file))
            {
                StreamReader rd = File.OpenText(file);
                string json = rd.ReadToEnd();
                rd.Close();
                usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
            }
        }


        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = usuarios.Find(u => u.Nombredeusuario == Login1.UserName);
            bool validatePassword = BC.Verify(Login1.Password, usuario.Contrasena);

            if (validatePassword)
            {
                int level = usuario.Nivel;
                FormsAuthenticationTicket tkt;
                string cookiestr;
                HttpCookie ck;

                tkt = new FormsAuthenticationTicket(1, Login1.UserName, DateTime.Now,
                DateTime.Now.AddMinutes(30), Login1.RememberMeSet, level.ToString());
                cookiestr = FormsAuthentication.Encrypt(tkt);
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);

                if (Login1.RememberMeSet)
                    ck.Expires = tkt.Expiration;
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);
                string strRedirect;
                strRedirect = Request["ReturnUrl"];
                if (strRedirect == null)
                    if (usuario.Nivel == 1)
                        strRedirect = "../Pacientes.aspx";
                if (usuario.Nivel == 2)
                    strRedirect = "../Consultas.aspx";
                Response.Redirect(strRedirect, true);
            }
            else
            {
                Response.Redirect("Login.aspx", true);
            }
        }
    }
}