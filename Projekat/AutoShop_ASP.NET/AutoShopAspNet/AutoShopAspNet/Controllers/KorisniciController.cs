using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AutoShopAspNet.Models;
using Microsoft.AspNet.Identity.Owin;
using OOADAspNetMVCEFAzure.Models;

namespace AutoShopAspNet.Controllers
{
    public class KorisniciController : Controller
    {
        private OOADContext db = new OOADContext();

        // GET: Korisnici
        public ActionResult Index()
        {
            if (Session["UserId"] != null)
                return View(db.Korisnik.ToList());
            else
                return RedirectToAction("Login");
        }

        // GET: Korisnici/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // GET: Korisnici/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        // POST: Korisnici/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ime,Prezime,Username,Password,Telefon")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Korisnik.Add(korisnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(korisnik);
        }

        // POST: /Account/Login
        [HttpPost]
        public ActionResult Login(string Username, string Sifra)
        {
            OOADContext db = new OOADContext();
            List<Korisnik> korisnici = new List<Korisnik>();
            List<AutoSalon> autosaloni = new List<AutoSalon>();
            korisnici = db.Korisnik.ToList<Korisnik>();
            autosaloni = db.AutoSalon.ToList<AutoSalon>();

            for(int i=0; i<korisnici.Count; i++)
            {
                if (korisnici[i].Username.Equals(Username) && korisnici[i].Password.Equals(Sifra))
                {
                    Session["User"] = korisnici[i];
                    Session["UserId"] = korisnici[i].Id;
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }


        // GET: Korisnici/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisnici/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ime,Prezime,Username,Password,Telefon")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(korisnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(korisnik);
        }

        // GET: Korisnici/Delete/5
 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Korisnik korisnik = db.Korisnik.Find(id);
            if (korisnik == null)
            {
                return HttpNotFound();
            }
            return View(korisnik);
        }

        // POST: Korisnici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Korisnik korisnik = db.Korisnik.Find(id);
            db.Korisnik.Remove(korisnik);
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
