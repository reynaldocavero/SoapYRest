using ComercialClienteDominio;
using ComercialCreditoContratoRepositorio;
using ComercioCreditoSQLRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialCreditoFachada
{
    public class ClienteFachada : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<Cliente> listarCliente()
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.listarCliente();
        }

        public IEnumerable<Cliente> buscarCliente(string xml)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.buscarCliente(xml);
        }

        public IEnumerable<Cliente> registrarCliente(string xml)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.registrarCliente(xml);
        }
    }
}
