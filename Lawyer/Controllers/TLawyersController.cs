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
    public class TLawyersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TLawyers
        public ActionResult Index()
        {
            return View(db.TLawyer.ToList());
        }

        // GET: TLawyers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TLawyer tLawyer = db.TLawyer.Find(id);
            if (tLawyer == null)
            {
                return HttpNotFound();
            }
            return View(tLawyer);
        }

        // GET: TLawyers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TLawyers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,QualifiedLawers")] TLawyer tLawyer)
        {
            if (ModelState.IsValid)
            {
                db.TLawyer.Add(tLawyer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tLawyer);
        }

        // GET: TLawyers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TLawyer tLawyer = db.TLawyer.Find(id);
            if (tLawyer == null)
            {
                return HttpNotFound();
            }
            return View(tLawyer);
        }

        // POST: TLawyers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,QualifiedLawers")] TLawyer tLawyer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tLawyer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tLawyer);
        }

        // GET: TLawyers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TLawyer tLawyer = db.TLawyer.Find(id);
            if (tLawyer == null)
            {
                return HttpNotFound();
            }
            return View(tLawyer);
        }

        // POST: TLawyers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TLawyer tLawyer = db.TLawyer.Find(id);
            db.TLawyer.Remove(tLawyer);
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
