using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class Telefono
    {
        public string CaracteristicaTelefono { get; set; }
        public string NumeroTelefono { get; set; }
        public EnumTipoTelefono TipoTelefono { get; set; }
    }
}
