using Frete4U.Models;
using System.Linq;
using System.Web.Mvc;

namespace TestPage.Controllers
{
    public class HomeController : Controller
    {

        private Frete4UEntities dbfrete4u = new Frete4UEntities();

        public ActionResult Index()
        {
            ViewBag.ListaCidades = (from c in dbfrete4u.tb_cd_cidades
                                    select c).ToList();
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