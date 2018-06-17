using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IssatisLab.Yima.Mvc.Seed.Models;

namespace IssatisLab.Yima.Mvc.Seed.Controllers
{
    public class OcorrenciaInternaController : Controller
    {
        private PrefeituraBairroEFContext db = new PrefeituraBairroEFContext();

        // GET: OcorrenciaInterna
        public ActionResult Index()
        {
            ViewBag.Link1 = "Home";
            ViewBag.Link2 = "Relação Ocorrência";
            return View(db.OcorrenciaInternas.ToList());
        }

        // GET: OcorrenciaInterna/Details/5
        public ActionResult Details(int? id)
        {
            ViewBag.Link1 = "Home";
            ViewBag.Link2 = "Relação Ocorrência";
            ViewBag.Link3 = "Detalhes";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OcorrenciaInterna ocorrenciaInterna = db.OcorrenciaInternas.Find(id);
            if (ocorrenciaInterna == null)
            {
                return HttpNotFound();
            }
            return View(ocorrenciaInterna);
        }

        // GET: OcorrenciaInterna/Create
        public ActionResult Create()
        {
            ViewBag.Link1 = "Home";
            ViewBag.Link2 = "Relação Ocorrência";
            ViewBag.Link3 = "Nova Ocorrência";
            return View();
        }

        // POST: OcorrenciaInterna/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ocorrenciaInternaId,latitude,longitude,logradouro,numero,bairro,cep,cidade,estado,status,descricao,dataAguardando,dataFinalizado,dataIniciado")] OcorrenciaInterna ocorrenciaInterna)
        {
            ocorrenciaInterna.status = "iniciado";
            ocorrenciaInterna.dataAguardando = DateTime.Now.Date;
            ocorrenciaInterna.dataFinalizado = DateTime.Now.Date;
            ocorrenciaInterna.dataIniciado = DateTime.Now.Date;
            if (ModelState.IsValid)
            {
                db.OcorrenciaInternas.Add(ocorrenciaInterna);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ocorrenciaInterna);
        }

        // GET: OcorrenciaInterna/Edit/5
        public ActionResult Edit(int? id)
        {
            ViewBag.Link1 = "Home";
            ViewBag.Link2 = "Relação Ocorrência";
            ViewBag.Link3 = "Editar Ocorrência";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OcorrenciaInterna ocorrenciaInterna = db.OcorrenciaInternas.Find(id);
            if (ocorrenciaInterna == null)
            {
                return HttpNotFound();
            }
            return View(ocorrenciaInterna);
        }

        // POST: OcorrenciaInterna/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ocorrenciaInternaId,latitude,longitude,logradouro,numero,bairro,cep,cidade,estado,status,descricao,dataAguardando,dataFinalizado,dataIniciado")] OcorrenciaInterna ocorrenciaInterna)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ocorrenciaInterna).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ocorrenciaInterna);
        }

        // GET: OcorrenciaInterna/Delete/5
        public ActionResult Delete(int? id)
        {
            ViewBag.Link1 = "Home";
            ViewBag.Link2 = "Relação Ocorrência";
            ViewBag.Link3 = "Deletar Ocorrência";

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OcorrenciaInterna ocorrenciaInterna = db.OcorrenciaInternas.Find(id);
            if (ocorrenciaInterna == null)
            {
                return HttpNotFound();
            }
            return View(ocorrenciaInterna);
        }

        // POST: OcorrenciaInterna/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OcorrenciaInterna ocorrenciaInterna = db.OcorrenciaInternas.Find(id);
            db.OcorrenciaInternas.Remove(ocorrenciaInterna);
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
