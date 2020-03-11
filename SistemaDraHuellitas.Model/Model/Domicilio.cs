using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class Domicilio
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public int Departamento { get; set; }
    }
}
