using IssatisLab.Yima.Mvc.Seed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace IssatisLab.Yima.Mvc.Seed.Controllers
{
    public class OcorrenciaController : Controller
    {
        
        // GET: Ocorrencia
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Interna()
        {
            ViewBag.Tipo = "interna";
            return View();
        }

        public ActionResult Externa()
        {
            ViewBag.Tipo = "externa";
            return View();
        }

        // GET: Ocorrencia/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ocorrencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ocorrencia/Create
        [HttpPost]
        public ActionResult Create(Ocorrencia ocorrencia)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ocorrencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ocorrencia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ocorrencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ocorrencia/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
