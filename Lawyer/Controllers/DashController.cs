using Lawyer.Models;
using Lawyer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lawyer.Controllers
{
    public class DashController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Dash
        public ActionResult Index()
        {
            var dbl = new HomeViewModels();
            var award = (from a in db.Awards select a).ToList();
            var client = (from c in db.Clients select c).ToList();
            var tcase = (from ca in db.Cases select ca).ToList();
            var lawyer = (from la in db.TLawyer select la).ToList();
            var category = (from cat in db.Categories select cat).ToList();
            var practiceArea = (from pr in db.PracticeAreas select pr).ToList();
            var model = new HomeViewModels {
                _award = award,
                _clients = client,
                _case    = tcase,
                _lawyers = lawyer,
                _practiceAreas =practiceArea,
                _category = category
            };
            return View(model);

        }
    }
}
