using SistemaDraHuellitas.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        #region Constructor
        public ClienteRepository()
        {
        }
        #endregion

        #region Métodos públicos
        public bool Guardar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObtenerCliente(int dni)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObtenerClientes()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Métodos privados 

        #endregion
    }
}
