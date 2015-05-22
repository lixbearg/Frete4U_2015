﻿using System;
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
        //
        // GET: /Buscar/
        public ActionResult Index(string CidadeOrigem, string CidadeDestino)
        {
            var prestadores = from p in dbfrete4u.tb_cd_prestador 
                              select p;

            if (!String.IsNullOrEmpty(CidadeOrigem) && !String.IsNullOrEmpty(CidadeOrigem))
            {
                prestadores = prestadores.Where(p => p.tb_cd_cidades.Any(c => c.nom_cidade == CidadeOrigem) && p.tb_cd_cidades.Any(c => c.nom_cidade == CidadeDestino));
            }

            return View(prestadores.ToList());
        }
    }
}