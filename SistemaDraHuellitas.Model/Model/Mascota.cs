using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class Mascota
    {
        public int Id { get; set; }
        public string NombreMascota { get; set; }
        public string Raza { get; set; }
        public EnumSexo Sexo { get; set; }
        public string Especie { get; set; }
        public string Color { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime? FechaDefuncion { get; set; }
        public HistoriaClinica HistoriaClinica { get; set; }
        public CarnetVacunacion Carnet { get; set; }
    }
}
