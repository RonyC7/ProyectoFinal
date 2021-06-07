using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Class
{
    public class HistorialPacientes
    {
        List<NIT> nit = new List<NIT>();
        public DateTime DiaConsulta { get; set; }
        public string Consulta { get; set; }
        public string Temperatura { get; set; }
        public string Presion { get; set; }
        public string Sintomas { get; set; } 
        public string Diagnostico { get; set; }
        public string Descripcion { get; set; }
        public DateTime ProximaCita { get; set; }
        double Precio { get; set; }
    }
}