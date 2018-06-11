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
    public class AutoSaloniController : Controller
    {
        private OOADContext db = new OOADContext();

        // GET: AutoSaloni
        public ActionResult Index()
        {
            return View(db.AutoSalon.ToList());
        }

        // GET: AutoSaloni/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AutoSalon autoSalon = db.AutoSalon.Find(id);
            if (autoSalon == null)
            {
                return HttpNotFound();
            }
            return View(autoSalon);
        }

        // GET: AutoSaloni/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutoSaloni/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Naziv,Username,Password,Adresa,Telefon")] AutoSalon autoSalon)
        {
            if (ModelState.IsValid)
            {
                db.AutoSalon.Add(autoSalon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(autoSalon);
        }

        // GET: AutoSaloni/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AutoSalon autoSalon = db.AutoSalon.Find(id);
            if (autoSalon == null)
            {
                return HttpNotFound();
            }
            return View(autoSalon);
        }

        // POST: AutoSaloni/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Naziv,Username,Password,Adresa,Telefon")] AutoSalon autoSalon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autoSalon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autoSalon);
        }

        // GET: AutoSaloni/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AutoSalon autoSalon = db.AutoSalon.Find(id);
            if (autoSalon == null)
            {
                return HttpNotFound();
            }
            return View(autoSalon);
        }

        // POST: AutoSaloni/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AutoSalon autoSalon = db.AutoSalon.Find(id);
            db.AutoSalon.Remove(autoSalon);
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
