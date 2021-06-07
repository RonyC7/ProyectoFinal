using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Class
{
    public class Medicinas
    {
        public string CodigoMedicamento { get; set; }
        public string Ingredientes { get; set; }
        public string Laboratorio { get; set; }
        List<Enfermedades> enfermedades = new List<Enfermedades>();
    }
}