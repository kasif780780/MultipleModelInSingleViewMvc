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
    public class SliderSectionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SliderSections
        public ActionResult Index()
        {
            return View(db.SliderSections.ToList());
        }

        // GET: SliderSections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderSection sliderSection = db.SliderSections.Find(id);
            if (sliderSection == null)
            {
                return HttpNotFound();
            }
            return View(sliderSection);
        }

        // GET: SliderSections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SliderSections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,WelcomeTitle,HeadingTitle,ShortDescription,SpanImage")] SliderSection sliderSection)
        {
            if (ModelState.IsValid)
            {
                db.SliderSections.Add(sliderSection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sliderSection);
        }

        // GET: SliderSections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderSection sliderSection = db.SliderSections.Find(id);
            if (sliderSection == null)
            {
                return HttpNotFound();
            }
            return View(sliderSection);
        }

        // POST: SliderSections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,WelcomeTitle,HeadingTitle,ShortDescription,SpanImage")] SliderSection sliderSection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sliderSection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sliderSection);
        }

        // GET: SliderSections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SliderSection sliderSection = db.SliderSections.Find(id);
            if (sliderSection == null)
            {
                return HttpNotFound();
            }
            return View(sliderSection);
        }

        // POST: SliderSections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SliderSection sliderSection = db.SliderSections.Find(id);
            db.SliderSections.Remove(sliderSection);
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
