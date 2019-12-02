using ComercialCreditoContrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComercialClienteDominio;
using ComercialCreditoFachada;

namespace ComercialCreditoImplementacion
{
    public class ClienteService : IClienteService
    {
        public IEnumerable<Cliente> listarCliente()
        {
           using(var instancia=new ClienteFachada())
            {
                return instancia.listarCliente();
            }
        }
        public IEnumerable<Cliente> buscarCliente(string xml)
        {
            using (var instancia = new ClienteFachada())
            {
                return instancia.buscarCliente(xml);
            }
        }
        public IEnumerable<Cliente> registrarCliente(string xml)
        {
            using (var instancia = new ClienteFachada())
            {
                return instancia.registrarCliente(xml);
            }
        }
    }
}
