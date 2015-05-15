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
        private Frete4UEntities dbfrete4u = new Frete4UEntities();
        private ApplicationDbContext dbasp = new ApplicationDbContext();
        //
        // GET: /Buscar/
        public ActionResult Index()
        {
            var model = new BuscarView
            {
                Cidades = dbfrete4u.tb_cd_cidades.ToList(),
                Usuarios = dbasp.Users.ToList()      
            };
            return View(model);
        }
    }
}