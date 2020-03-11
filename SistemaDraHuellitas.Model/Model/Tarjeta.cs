using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class Tarjeta
    {
        public long NumeroTarjeta { get; set; }
        public int CodigoSeguridad { get; set; }
        public string Banco { get; set; }
        public EnumTipoTarjeta TipoTarjeta { get; set; }
    }
}
