using System;
using System.Collections.Generic;
using System.Linq;
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

        public ActionResult MinhasMoedas()
        {
            ViewBag.Title = "Home Page";

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
