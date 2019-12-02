using clienteServiciosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace clienteServiciosWeb.Controllers
{
    public class DocumentoController : Controller
    {
        // GET: Documento
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> listaCliente()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53717/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new
                    MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.PostAsync("ClienteService.svc/rest/listarCliente", null);

                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStreamAsync().Result;

                    DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(List<ClienteViewModel>));
                    List<ClienteViewModel> response = obj.ReadObject(result) as List<ClienteViewModel>;

                    return Json(response);
                }
                return View();
            }


        }
    }
}