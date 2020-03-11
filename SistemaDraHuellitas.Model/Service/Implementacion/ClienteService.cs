using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public class ClienteService : IClienteService
    {
        #region Constructor
        public ClienteService()
        {

        }
        #endregion

        #region Métodos públicos
        public Domicilio ObtenerDomicilio(int dniCliente)
        {
            throw new NotImplementedException();
        }

        public List<Mascota> ObtenerMascotas(int dniCliente)
        {
            throw new NotImplementedException();
        }

        public List<Tarjeta> ObtenerTarjeta(int dniCliente)
        {
            throw new NotImplementedException();
        }

        public List<Telefono> ObtenerTelefono(int dniCliente)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Métodos privados
        #endregion        
    }
}
