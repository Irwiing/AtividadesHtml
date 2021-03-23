using EntityFramewokMVC.Dal;
using EntityFramewokMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramewokMVC.Controllers
{
    public class PerifericoController : Controller
    {
        private PerifericoContext _ctxPeriferico = new PerifericoContext();

        // GET: Periferico
        public ActionResult Index()
        {
            var Perifericos = _ctxPeriferico.Perifericos.ToList();
            return View(Perifericos);
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
                _ctxPeriferico.Perifericos.Add(periferico);
                _ctxPeriferico.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(periferico);
        }

        public ActionResult Edit(int id)
        {
            var perifericoSelecionado = _ctxPeriferico.Perifericos.First(periferico => periferico.Id == id);
            return View(perifericoSelecionado);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Periferico perifericoAtualizado)
        {
            if (ModelState.IsValid)
            {
                var perifericoSelecionado = _ctxPeriferico.Perifericos.First(periferico => periferico.Id == perifericoAtualizado.Id);
                perifericoSelecionado.Marca = perifericoAtualizado.Marca;
                perifericoSelecionado.Modelo = perifericoAtualizado.Modelo;
                perifericoSelecionado.Tipo = perifericoAtualizado.Tipo;
                perifericoSelecionado.Preco = perifericoAtualizado.Preco;

                _ctxPeriferico.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var perifericoSelecionado = _ctxPeriferico.Perifericos.First(periferico => periferico.Id == id);
            return View(perifericoSelecionado);
        }

        public ActionResult Delete(int id)
        {
            var perifericoSelecionado = _ctxPeriferico.Perifericos.First(periferico => periferico.Id == id);
            return View(perifericoSelecionado);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var perifericoSelecionado = _ctxPeriferico.Perifericos.First(periferico => periferico.Id == id);
            _ctxPeriferico.Perifericos.Remove(perifericoSelecionado);
            _ctxPeriferico.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}