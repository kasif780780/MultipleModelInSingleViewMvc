using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lawyer.DTOModels;
using Lawyer.Models;

namespace Lawyer.Controllers
{
    public class PracticeAreasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PracticeAreas
        public ActionResult Index()
        {
            return View(db.PracticeAreas.ToList());
        }

        // GET: PracticeAreas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PracticeArea practiceArea = db.PracticeAreas.Find(id);
            if (practiceArea == null)
            {
                return HttpNotFound();
            }
            return View(practiceArea);
        }

        // GET: PracticeAreas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PracticeAreas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PrimaryHeading,Description")] PracticeArea practiceArea)
        {
            if (ModelState.IsValid)
            {
                db.PracticeAreas.Add(practiceArea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(practiceArea);
        }

        // GET: PracticeAreas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PracticeArea practiceArea = db.PracticeAreas.Find(id);
            if (practiceArea == null)
            {
                return HttpNotFound();
            }
            return View(practiceArea);
        }

        // POST: PracticeAreas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PrimaryHeading,Description")] PracticeArea practiceArea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(practiceArea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(practiceArea);
        }

        // GET: PracticeAreas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PracticeArea practiceArea = db.PracticeAreas.Find(id);
            if (practiceArea == null)
            {
                return HttpNotFound();
            }
            return View(practiceArea);
        }

        // POST: PracticeAreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PracticeArea practiceArea = db.PracticeAreas.Find(id);
            db.PracticeAreas.Remove(practiceArea);
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
