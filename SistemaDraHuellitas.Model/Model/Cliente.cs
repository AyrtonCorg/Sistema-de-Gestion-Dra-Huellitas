using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class Cliente
    {
        public int Documento { get; set; }
        public string NombreCliente { get; set; }
        public List<Mascota> Mascota { get; set; }
        public List<Telefono> Telefono { get; set; }
        public Domicilio Domicilio { get; set; }
        public List<Tarjeta> Tarjeta { get; set; }

    }
}
