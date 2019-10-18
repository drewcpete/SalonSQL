using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        private readonly HairSalonContext _db;

        public StylistsController(HairSalonContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist stylist = _db.Stylists.Include(e => e.Clients).FirstOrDefault(e => e.Id == id);
            return View(stylist);
        }
        
        public ActionResult Edit(int id)
        {
            var thisStylist = _db.Stylists.FirstOrDefault(e => e.Id == id);
            return View(thisStylist);
        }

        [HttpPost]
        public ActionResult Edit(Stylist stylist)
        {
            _db.Entry(stylist).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisStylist = _db.Stylists.FirstOrDefault(e => e.Id == id);
            _db.Stylists.Remove(thisStylist);
            _db.SaveChanges();
            return RedirectToAction("index");
        }

    }
}