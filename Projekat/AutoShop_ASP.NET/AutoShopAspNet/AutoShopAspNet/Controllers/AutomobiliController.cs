using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoShopAspNet.Models;
using OOADAspNetMVCEFAzure.Models;

namespace AutoShopAspNet.Controllers
{
    public class AutomobiliController : Controller
    {
        private OOADContext db = new OOADContext();

        // GET: Automobili
        public ActionResult Lista()
        {
            return View(db.Automobil.ToList());
        }

        // GET: Automobili/Detalji/5
        public ActionResult Detalji(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobil automobil = db.Automobil.Find(id);
            if (automobil == null)
            {
                return HttpNotFound();
            }
            return View(automobil);
        }

        // GET: Automobili/Registriraj
        public ActionResult Registriraj()
        {
            return View();
        }

        // POST: Automobili/Registriraj
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registriraj([Bind(Include = "ID,Marka,Model,Boja,Cijena,Godiste")] Automobil automobil)
        {
            if (ModelState.IsValid)
            {
                db.Automobil.Add(automobil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(automobil);
        }

        // GET: Automobili/Azuriraj/5
        public ActionResult Azuriraj(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobil automobil = db.Automobil.Find(id);
            if (automobil == null)
            {
                return HttpNotFound();
            }
            return View(automobil);
        }

        // POST: Automobili/Azuriraj/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Azuriraj([Bind(Include = "ID,Marka,Model,Boja,Cijena,Godiste")] Automobil automobil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automobil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(automobil);
        }

        // GET: Automobili/Obrisi/5
        public ActionResult Obrisi(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automobil automobil = db.Automobil.Find(id);
            if (automobil == null)
            {
                return HttpNotFound();
            }
            return View(automobil);
        }

        // POST: Automobili/Obrisi/5
        [HttpPost, ActionName("Obrisi")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automobil automobil = db.Automobil.Find(id);
            db.Automobil.Remove(automobil);
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
