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
    public class CidadaoController : Controller
    {
        private PrefeituraBairroEFContext db = new PrefeituraBairroEFContext();

        // GET: Cidadao
        public ActionResult Index()
        {
            return View(db.Cidadaos.ToList());
        }

        // GET: Cidadao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidadao cidadao = db.Cidadaos.Find(id);
            if (cidadao == null)
            {
                return HttpNotFound();
            }
            return View(cidadao);
        }

        // GET: Cidadao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cidadao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cidadaoId,nome,email,telefone")] Cidadao cidadao)
        {
            if (ModelState.IsValid)
            {
                db.Cidadaos.Add(cidadao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidadao);
        }

        // GET: Cidadao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidadao cidadao = db.Cidadaos.Find(id);
            if (cidadao == null)
            {
                return HttpNotFound();
            }
            return View(cidadao);
        }

        // POST: Cidadao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cidadaoId,nome,email,telefone")] Cidadao cidadao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidadao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cidadao);
        }

        // GET: Cidadao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidadao cidadao = db.Cidadaos.Find(id);
            if (cidadao == null)
            {
                return HttpNotFound();
            }
            return View(cidadao);
        }

        // POST: Cidadao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cidadao cidadao = db.Cidadaos.Find(id);
            db.Cidadaos.Remove(cidadao);
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
