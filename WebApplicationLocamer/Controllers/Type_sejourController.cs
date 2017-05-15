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
    public class Type_sejourController : Controller
    {
        private Locamer1Entities db = new Locamer1Entities();

        // GET: Type_sejour
        public ActionResult Index()
        {
            return View(db.Type_sejour.ToList());
        }

        // GET: Type_sejour/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type_sejour type_sejour = db.Type_sejour.Find(id);
            if (type_sejour == null)
            {
                return HttpNotFound();
            }
            return View(type_sejour);
        }

        // GET: Type_sejour/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Type_sejour/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_Tsejour,libelle_Tsejour,coefficient_Tsejour")] Type_sejour type_sejour)
        {
            if (ModelState.IsValid)
            {
                db.Type_sejour.Add(type_sejour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(type_sejour);
        }

        // GET: Type_sejour/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type_sejour type_sejour = db.Type_sejour.Find(id);
            if (type_sejour == null)
            {
                return HttpNotFound();
            }
            return View(type_sejour);
        }

        // POST: Type_sejour/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_Tsejour,libelle_Tsejour,coefficient_Tsejour")] Type_sejour type_sejour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(type_sejour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(type_sejour);
        }

        // GET: Type_sejour/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type_sejour type_sejour = db.Type_sejour.Find(id);
            if (type_sejour == null)
            {
                return HttpNotFound();
            }
            return View(type_sejour);
        }

        // POST: Type_sejour/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Type_sejour type_sejour = db.Type_sejour.Find(id);
            db.Type_sejour.Remove(type_sejour);
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
