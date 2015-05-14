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
        //
        // GET: /Buscar/
        public ActionResult Buscar()
        {
            List<tb_cd_tipo_entrega> listateste = new List<tb_cd_tipo_entrega>();
            BuscarView tbentrega = new BuscarView();
            
            listateste.Add(new tb_cd_tipo_entrega { descricao = "Delivery" });

            BuscarView model = new BuscarView
                {
                    TiposEntrega = listateste,
                    teste = "testestring"
                };

            return View(model);
        }
        
        // POST: /Buscar/
        [HttpPost]
         public ActionResult BuscarPost(string teste2)
        {
            return View(teste2);
        }
	}
}