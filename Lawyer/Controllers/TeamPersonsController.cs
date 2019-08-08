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
    public class TeamPersonsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TeamPersons
        public ActionResult Index()
        {
            return View(db.TeamPersons.ToList());
        }

        // GET: TeamPersons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamPerson teamPerson = db.TeamPersons.Find(id);
            if (teamPerson == null)
            {
                return HttpNotFound();
            }
            return View(teamPerson);
        }

        // GET: TeamPersons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamPersons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Image,Name,Category,Description,FacebookUrl,TwitterUrl,InstagramUrl")] TeamPerson teamPerson)
        {
            if (ModelState.IsValid)
            {
                db.TeamPersons.Add(teamPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teamPerson);
        }

        // GET: TeamPersons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamPerson teamPerson = db.TeamPersons.Find(id);
            if (teamPerson == null)
            {
                return HttpNotFound();
            }
            return View(teamPerson);
        }

        // POST: TeamPersons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Image,Name,Category,Description,FacebookUrl,TwitterUrl,InstagramUrl")] TeamPerson teamPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teamPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teamPerson);
        }

        // GET: TeamPersons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeamPerson teamPerson = db.TeamPersons.Find(id);
            if (teamPerson == null)
            {
                return HttpNotFound();
            }
            return View(teamPerson);
        }

        // POST: TeamPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeamPerson teamPerson = db.TeamPersons.Find(id);
            db.TeamPersons.Remove(teamPerson);
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
