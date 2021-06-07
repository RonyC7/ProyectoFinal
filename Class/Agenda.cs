using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Class
{
    public class Agenda
    {
        List<NIT> nit = new List<NIT>();
        public DateTime Dia { get; set; }
        public string Fechainicio { get; set; }
        public string FechaFinal { get; set; }
    }
}