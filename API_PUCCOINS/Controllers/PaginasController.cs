using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace API_PUCCOINS.Controllers
{
    [Route("")]
    public class PaginasController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public async System.Threading.Tasks.Task<ActionResult> MinhasMoedas()
        {
            HttpClient client = new HttpClient();

            List<string> clientes;
            HttpResponseMessage response = await client.GetAsync($"{Request.Url.AbsoluteUri.Replace(Request.Url.LocalPath, "")}/api/Contas");
            if (response.IsSuccessStatusCode)
            {
                clientes = await response.Content.ReadAsAsync<List<string>>();
            }

            ViewBag.Title = "Home Page";
            ViewBag.Moedas = 234;

            return View();
        }

        public ActionResult Relatorio()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Resgatar()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Transferencias()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
