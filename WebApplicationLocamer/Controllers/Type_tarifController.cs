using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationLocamer.Models;

namespace WebApplicationLocamer.Controllers
{
    public class Type_tarifController : Controller
    {
        private Locamer1Entities db = new Locamer1Entities();

        // GET: Type_tarif
        public ActionResult Index()
        {
            return View(db.Type_tarif.ToList());
        }

        // GET: Type_tarif/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type_tarif type_tarif = db.Type_tarif.Find(id);
            if (type_tarif == null)
            {
                return HttpNotFound();
            }
            return View(type_tarif);
        }

        // GET: Type_tarif/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Type_tarif/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_Ttarif,libelle_Ttarif,prixJour_Ttarif")] Type_tarif type_tarif)
        {
            if (ModelState.IsValid)
            {
                db.Type_tarif.Add(type_tarif);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(type_tarif);
        }

        // GET: Type_tarif/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type_tarif type_tarif = db.Type_tarif.Find(id);
            if (type_tarif == null)
            {
                return HttpNotFound();
            }
            return View(type_tarif);
        }

        // POST: Type_tarif/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_Ttarif,libelle_Ttarif,prixJour_Ttarif")] Type_tarif type_tarif)
        {
            if (ModelState.IsValid)
            {
                db.Entry(type_tarif).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(type_tarif);
        }

        // GET: Type_tarif/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type_tarif type_tarif = db.Type_tarif.Find(id);
            if (type_tarif == null)
            {
                return HttpNotFound();
            }
            return View(type_tarif);
        }

        // POST: Type_tarif/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Type_tarif type_tarif = db.Type_tarif.Find(id);
            db.Type_tarif.Remove(type_tarif);
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
