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
    public class SejoursController : Controller
    {
        private Locamer1Entities db = new Locamer1Entities();

        // GET: Sejours
        public ActionResult Index()
        {
            var sejour = db.Sejour.Include(s => s.Client).Include(s => s.Type_sejour);
            return View(sejour.ToList());
        }

        // GET: Sejours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sejour sejour = db.Sejour.Find(id);
            if (sejour == null)
            {
                return HttpNotFound();
            }
            return View(sejour);
        }

        // GET: Sejours/Create
        public ActionResult Create()
        {
            ViewBag.id_client = new SelectList(db.Client, "id_client", "nom_client");
            ViewBag.id_Tsejour = new SelectList(db.Type_sejour, "id_Tsejour", "libelle_Tsejour");
            return View();
        }

        // POST: Sejours/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_Sejour,id_client,id_Tsejour,id_option,date_debut,date_fin")] Sejour sejour)
        {
            if (ModelState.IsValid)
            {
                db.Sejour.Add(sejour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_client = new SelectList(db.Client, "id_client", "nom_client", sejour.id_client);
            ViewBag.id_Tsejour = new SelectList(db.Type_sejour, "id_Tsejour", "libelle_Tsejour", sejour.id_Tsejour);
            return View(sejour);
        }

        // GET: Sejours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sejour sejour = db.Sejour.Find(id);
            if (sejour == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_client = new SelectList(db.Client, "id_client", "nom_client", sejour.id_client);
            ViewBag.id_Tsejour = new SelectList(db.Type_sejour, "id_Tsejour", "libelle_Tsejour", sejour.id_Tsejour);
            return View(sejour);
        }

        // POST: Sejours/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_Sejour,id_client,id_Tsejour,id_option,date_debut,date_fin")] Sejour sejour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sejour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_client = new SelectList(db.Client, "id_client", "nom_client", sejour.id_client);
            ViewBag.id_Tsejour = new SelectList(db.Type_sejour, "id_Tsejour", "libelle_Tsejour", sejour.id_Tsejour);
            return View(sejour);
        }

        // GET: Sejours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sejour sejour = db.Sejour.Find(id);
            if (sejour == null)
            {
                return HttpNotFound();
            }
            return View(sejour);
        }

        // POST: Sejours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sejour sejour = db.Sejour.Find(id);
            db.Sejour.Remove(sejour);
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
