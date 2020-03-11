using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public interface IMascotaService
    {
        HistoriaClinica ObtenerHistoriaClinica(int idMascota);
        CarnetVacunacion ObtenerCarnetVacunacion(int idMascota);
        Cliente ObtenerDuenio(int idMascota);

        bool GuardarHistoriaClinica(HistoriaClinica historiaClinica);

        bool ModificarHistoriaClinica(HistoriaClinica historiaClinica);
    }
}
