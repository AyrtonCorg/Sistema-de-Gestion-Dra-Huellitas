using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    interface IClienteService
    {
        List<Mascota> ObtenerMascotas(int dniCliente);
        List<Telefono> ObtenerTelefono(int dniCliente);
        Domicilio ObtenerDomicilio(int dniCliente);
        List<Tarjeta> ObtenerTarjeta(int dniCliente);


    }
}
