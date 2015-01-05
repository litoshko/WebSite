using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class CarRequestController : Controller
    {
        private WebSiteContext db = new WebSiteContext();

        //
        // GET: /CarRequest/

        public ActionResult Index()
        {
            var carrequst = db.CarRequst.Include(c => c.Car).Include(c => c.UserProfile);
            return View(carrequst.ToList());
        }

        //
        // GET: /CarRequest/Details/5

        public ActionResult Details(int id = 0)
        {
            CarRequest carrequest = db.CarRequst.Find(id);
            if (carrequest == null)
            {
                return HttpNotFound();
            }
            return View(carrequest);
        }

        //
        // GET: /CarRequest/Create

        public ActionResult Create()
        {
            ViewBag.CarId = new SelectList(db.Car, "CarId", "Make");
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "UserName");
            return View();
        }

        //
        // POST: /CarRequest/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarRequest carrequest)
        {
            if (ModelState.IsValid)
            {
                db.CarRequst.Add(carrequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarId = new SelectList(db.Car, "CarId", "Make", carrequest.CarId);
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "UserName", carrequest.UserId);
            return View(carrequest);
        }

        //
        // GET: /CarRequest/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CarRequest carrequest = db.CarRequst.Find(id);
            if (carrequest == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarId = new SelectList(db.Car, "CarId", "Make", carrequest.CarId);
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "UserName", carrequest.UserId);
            return View(carrequest);
        }

        //
        // POST: /CarRequest/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CarRequest carrequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carrequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarId = new SelectList(db.Car, "CarId", "Make", carrequest.CarId);
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "UserName", carrequest.UserId);
            return View(carrequest);
        }

        //
        // GET: /CarRequest/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CarRequest carrequest = db.CarRequst.Find(id);
            if (carrequest == null)
            {
                return HttpNotFound();
            }
            return View(carrequest);
        }

        //
        // POST: /CarRequest/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarRequest carrequest = db.CarRequst.Find(id);
            db.CarRequst.Remove(carrequest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}