using ComercialClienteDominio;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ComercialCreditoContrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebInvoke(
        Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/listarCliente",
        BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Cliente> listarCliente();

        [OperationContract]
        [WebInvoke(
        Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/buscarCliente",
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        IEnumerable<Cliente> buscarCliente(string xml);

        [OperationContract]
        [WebInvoke(
        Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/registrarCliente",
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        IEnumerable<Cliente> registrarCliente(string xml);
    }
}
