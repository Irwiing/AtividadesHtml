using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtividadeMVC.Controllers
{
    public class PerifericoController : Controller
    {
        private IPerifericoData _periferico;

        public PerifericoController()
        {
            _periferico = new PerifericoData();
        }

        public ActionResult Index()
        {
            var lst = _periferico.Select();
            return View(lst);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Periferico periferico)
        {
            if (ModelState.IsValid)
            {
                _periferico.Insert(periferico);
                return RedirectToAction("Index");
            }
            return View(periferico);
        }

        public ActionResult Edit(int id)
        {
            var periferico = _periferico.Select(id);
            return View(periferico);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Periferico periferico)
        {
            if (ModelState.IsValid)
            {
                _periferico.Update(periferico);
                return RedirectToAction("Index");
            }
            return View(periferico);
        }

        public ActionResult Details(int id)
        {
            var periferico = _periferico.Select(id);
            return View(periferico);
        }

        public ActionResult Delete(int id)
        {
            var periferico = _periferico.Select(id);
            return View(periferico);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            _periferico.Delete(id);
            return RedirectToAction("Index");
        }
    }
}