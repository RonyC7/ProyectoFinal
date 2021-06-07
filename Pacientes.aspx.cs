using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Pacientes : System.Web.UI.Page
    {
        static List<Usuarios> usuarios = new List<Usuarios>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonApaciente_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonEpaciente_Click(object sender, EventArgs e)
        {
             Pacientes usuarios = usuarios.Find(prop => prop.Nombre == TextBoxApaciente.Text);

            if (usuarios != null)
            {
                TextBoxApaciente.Text = usuarios.TextBoxNopaciente

            }
        }

        private Pacientes Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        private void Guardar()
        {

        }
    }
}