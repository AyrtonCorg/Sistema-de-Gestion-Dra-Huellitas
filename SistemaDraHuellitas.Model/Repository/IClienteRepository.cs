using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDraHuellitas.Model
{
    public interface IClienteRepository
    {
        bool Guardar(Cliente cliente);
        bool Modificar(Cliente cliente);
        Cliente ObtenerCliente(int dni);
        List<Cliente> ObtenerClientes();

    }
}
