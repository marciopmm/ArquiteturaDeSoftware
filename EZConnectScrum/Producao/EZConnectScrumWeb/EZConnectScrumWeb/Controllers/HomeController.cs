using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EZConnectScrumWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Este é um exemplo de utilização do TFS Scrum Template.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Exemplo Arquitetura C#";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Visite nosso site!";

            return View();
        }
    }
}
