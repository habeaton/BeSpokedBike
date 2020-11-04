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
    public class CommissionsController : Controller
    {
        private BikeSaleContext db = new BikeSaleContext();

        // GET: Commissions
        public ActionResult Index()
        {
            return View(db.Commision.ToList());
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
