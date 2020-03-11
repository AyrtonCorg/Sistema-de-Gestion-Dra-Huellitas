using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public interface IMascotaRepository
    {
        bool Guardar(Mascota mascota);
        bool Modificar(Mascota mascota);
        Cliente ObtenerMascota(int idMascota);
        List<Cliente> ObtenerMascota();
    }
}
