using Frete4U.Models;
using Frete4U.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Frete4U.Controllers
{
    public class BuscarController : Controller
    {
        private Frete4UEntities dbfrete4u = new Frete4UEntities();
        //
        // GET: /Buscar/
        public ActionResult Index()
        {
            ViewBag.ListaCidades = (from c in dbfrete4u.tb_cd_cidades
                                    select c).ToList();            
            ViewBag.TiposEntrega = (from te in dbfrete4u.tb_cd_tipo_entrega
                                    select te).ToList();
            ViewBag.Transportes = (from tr in dbfrete4u.tb_cd_transporte
                                    select tr).ToList();

            return View();
        }

        [HttpGet]
        public ActionResult Buscar(string CidadeOrigem, string CidadeDestino)
        {
            var prestadores = from p in dbfrete4u.tb_cd_prestador
                              select p;

            if (!String.IsNullOrEmpty(CidadeOrigem) && !String.IsNullOrEmpty(CidadeDestino))
            {
                prestadores = prestadores.Where(p => p.tb_cd_cidades.Any(c => c.nom_cidade == CidadeOrigem) && p.tb_cd_cidades.Any(c => c.nom_cidade == CidadeDestino));
            }

            ViewBag.Prestadores = prestadores.ToList();

            return PartialView("Busca");
        }
    }
}