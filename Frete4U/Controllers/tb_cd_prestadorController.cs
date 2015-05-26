using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Frete4U.Models;

namespace Frete4U.Controllers
{
    public class tb_cd_prestadorController : Controller
    {
        private Frete4UEntities db = new Frete4UEntities();

        // GET: tb_cd_prestador
        public ActionResult Index()
        {
            return View(db.tb_cd_prestador.ToList());
        }

        // GET: tb_cd_prestador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_cd_prestador tb_cd_prestador = db.tb_cd_prestador.Find(id);
            if (tb_cd_prestador == null)
            {
                return HttpNotFound();
            }
            return View(tb_cd_prestador);
        }

        // GET: tb_cd_prestador/Create
        public ActionResult Cadastro(string id)
        {
            var model = new tb_cd_prestador { Id = id };            
            return View(model);
        }

        // POST: tb_cd_prestador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro([Bind(Include = "Id,cod_prestador,nome,nomeEmpresa,CPF,CNPJ,logradouro,numeroEndereco,bairro,complemento,cidade,estado")] tb_cd_prestador tb_cd_prestador)
        {
            if (ModelState.IsValid)
            {
                db.tb_cd_prestador.Add(tb_cd_prestador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_cd_prestador);
        }

        // GET: tb_cd_prestador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_cd_prestador tb_cd_prestador = db.tb_cd_prestador.Find(id);
            if (tb_cd_prestador == null)
            {
                return HttpNotFound();
            }
            return View(tb_cd_prestador);
        }

        // POST: tb_cd_prestador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,cod_prestador,nome,nomeEmpresa,CPF,CNPJ,logradouro,numeroEndereco,bairro,complemento,cidade,estado")] tb_cd_prestador tb_cd_prestador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_cd_prestador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_cd_prestador);
        }

        // GET: tb_cd_prestador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_cd_prestador tb_cd_prestador = db.tb_cd_prestador.Find(id);
            if (tb_cd_prestador == null)
            {
                return HttpNotFound();
            }
            return View(tb_cd_prestador);
        }

        // POST: tb_cd_prestador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_cd_prestador tb_cd_prestador = db.tb_cd_prestador.Find(id);
            db.tb_cd_prestador.Remove(tb_cd_prestador);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
