using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Class
{
    public class Pacientes
    {
        List<NIT> nit = new List<NIT>();
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime Fechanaci { get; set; }
        public int numerotelefono { get; set; }

    }
}