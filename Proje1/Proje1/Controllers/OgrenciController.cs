using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Proje1.Data;
using Proje1.Models;
using System;
using System.Linq;
using System.Net;

namespace Proje1.Controllers
{
    public class OgrenciController:Controller
    {

        private readonly ILogger<OgrenciController> _logger;
        private readonly OgrenciContext _context;

        public OgrenciController(ILogger<OgrenciController> logger, OgrenciContext context)
        {
            _logger = logger;
            _context = context;
        }

        public ActionResult Index()
        {
            return View(_context.ogrencis.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = _context.ogrencis.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                _context.ogrencis.Add(ogrenci);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ogrenci);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = _context.ogrencis.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(ogrenci).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogrenci);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrenci ogrenci = _context.ogrencis.Find(id);
            if (ogrenci == null)
            {
                return HttpNotFound();
            }
            return View(ogrenci);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogrenci ogrenci = _context.ogrencis.Find(id);
            _context.ogrencis.Remove(ogrenci);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
