using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ComoFunciona()
        {
            ViewBag.Message = "Ajuda sobre o funcionamento da aplicação.";

            return View();
        }

        public ActionResult SobreGrupo()
        {
            ViewBag.Message = "Página com informações sobre os membros do grupo.";

            return View();
        }

        public ActionResult Documentacao()
        {
            ViewBag.Message = "Página com os documentos do projeto.";

            return View();
        }

        public ActionResult Apresentacao()
        {
            ViewBag.Message = "Apresentação em CSS.";

            return View();
        }
    }
}