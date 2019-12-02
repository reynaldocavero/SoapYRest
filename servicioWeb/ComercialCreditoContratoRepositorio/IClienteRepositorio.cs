using ComercialClienteDominio;
using System.Collections.Generic;

namespace ComercialCreditoContratoRepositorio
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> listarCliente();
        IEnumerable<Cliente> buscarCliente(string xml);
        IEnumerable<Cliente> registrarCliente(string xml);
        IEnumerable<Cliente> eliminarCliente(string xml);
        IEnumerable<Cliente> actualizarCliente(string xml);
    }
}
