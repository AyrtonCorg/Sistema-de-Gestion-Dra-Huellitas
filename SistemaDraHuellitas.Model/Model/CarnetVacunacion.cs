using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class CarnetVacunacion
    {
        public DateTime FechaVacunacion { get; set; }
        public string Vacuna { get; set; }        
        public string Descripcion { get; set; }
        public DateTime FechaProximaVacunacion { get; set; }
    }
}
