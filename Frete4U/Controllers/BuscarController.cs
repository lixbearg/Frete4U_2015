using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Frete4U.ViewModels;
using Frete4U.Models;

namespace Frete4U.Controllers
{
    public class BuscarController : Controller
    {
        private Frete4UEntities db = new Frete4UEntities();
        //
        // GET: /Buscar/
        public ActionResult Index()
        {
            var model = new BuscarView
            {
                Cidades = db.tb_cd_cidades.ToList()
            };
            return View(model);
        }
    }
}