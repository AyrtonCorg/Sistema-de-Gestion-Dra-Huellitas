using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model.Service.Implementacion
{
    public class MascotaService : IMascotaService
    {
        #region Constructor
        public MascotaService()
        {
        }
        #endregion

        #region Métodos públicos
        #region Gets
        public CarnetVacunacion ObtenerCarnetVacunacion(int idMascota)
        {
            throw new NotImplementedException();
        }

        public Cliente ObtenerDuenio(int idMascota)
        {
            throw new NotImplementedException();
        }

        public HistoriaClinica ObtenerHistoriaClinica(int idMascota)
        {
            throw new NotImplementedException();
        }
        #endregion
        public bool GuardarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            throw new NotImplementedException();
        }

        public bool ModificarHistoriaClinica(HistoriaClinica historiaClinica)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Métodos privados

        #endregion
    }
}
