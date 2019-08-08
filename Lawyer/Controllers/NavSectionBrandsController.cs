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
    public class NavSectionBrandsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NavSectionBrands
        public ActionResult Index()
        {
            return View(db.NavSectionBrands.ToList());
        }

        // GET: NavSectionBrands/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NavSectionBrand navSectionBrand = db.NavSectionBrands.Find(id);
            if (navSectionBrand == null)
            {
                return HttpNotFound();
            }
            return View(navSectionBrand);
        }

        // GET: NavSectionBrands/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NavSectionBrands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,LogoImage")] NavSectionBrand navSectionBrand)
        {
            if (ModelState.IsValid)
            {
                db.NavSectionBrands.Add(navSectionBrand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(navSectionBrand);
        }

        // GET: NavSectionBrands/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NavSectionBrand navSectionBrand = db.NavSectionBrands.Find(id);
            if (navSectionBrand == null)
            {
                return HttpNotFound();
            }
            return View(navSectionBrand);
        }

        // POST: NavSectionBrands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,LogoImage")] NavSectionBrand navSectionBrand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(navSectionBrand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(navSectionBrand);
        }

        // GET: NavSectionBrands/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NavSectionBrand navSectionBrand = db.NavSectionBrands.Find(id);
            if (navSectionBrand == null)
            {
                return HttpNotFound();
            }
            return View(navSectionBrand);
        }

        // POST: NavSectionBrands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NavSectionBrand navSectionBrand = db.NavSectionBrands.Find(id);
            db.NavSectionBrands.Remove(navSectionBrand);
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
