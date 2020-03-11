using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class Consulta
    {
        public DateTime FechaConsulta { get; set; }
        public string Reseña { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
    }
}
