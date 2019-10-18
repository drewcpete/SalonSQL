using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {
        private readonly HairSalonContext _db;

        public ClientsController(HairSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Client> model = _db.Clients.Include(a => a.Stylist).ToList();

            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "Id", "Name");
            return View();
        } 

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisClient = _db.Clients.FirstOrDefault(e => e.ClientId == id);
            _db.Clients.Remove(thisClient);
            _db.SaveChanges();
            return RedirectToAction("index");
        }



    }
}