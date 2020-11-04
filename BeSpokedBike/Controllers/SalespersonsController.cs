using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeSpokedBike.DAL;
using BeSpokedBike.Models;

namespace BeSpokedBike.Controllers
{
    public class SalespersonsController : Controller
    {
        private BikeSaleContext db = new BikeSaleContext();

        // GET: Salespersons
        public ActionResult Index()
        {
            return View(db.Salesperson.ToList());
        }

        // GET: Salespersons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salespersons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalespersonID,FirstName,LastName,Address,Phone,StartDate,TerminationDate,Manager")] Salesperson salesperson)
        {
            if (ModelState.IsValid)
            {
                db.Salesperson.Add(salesperson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesperson);
        }

        // GET: Salespersons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salesperson salesperson = db.Salesperson.Find(id);
            if (salesperson == null)
            {
                return HttpNotFound();
            }
            return View(salesperson);
        }

        // POST: Salespersons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalespersonID,FirstName,LastName,Address,Phone,StartDate,TerminationDate,Manager")] Salesperson salesperson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesperson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salesperson);
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
