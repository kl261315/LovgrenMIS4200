using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LovgrenMIS4200.DAL;
using LovgrenMIS4200.Models;

namespace LovgrenMIS4200.Controllers
{
    public class currentOwnersController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: currentOwners
        public ActionResult Index()
        {
            var currentOwners = db.currentOwners.Include(c => c.Car).Include(c => c.Owner);
            return View(currentOwners.ToList());
        }

        // GET: currentOwners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            currentOwner currentOwner = db.currentOwners.Find(id);
            if (currentOwner == null)
            {
                return HttpNotFound();
            }
            return View(currentOwner);
        }

        // GET: currentOwners/Create
        public ActionResult Create()
        {
            ViewBag.carsID = new SelectList(db.Cars, "CarsID", "carNickName");
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "ownerLastName");
            return View();
        }

        // POST: currentOwners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "currentOwnerID,qtyofCars,ownerID,carsID")] currentOwner currentOwner)
        {
            if (ModelState.IsValid)
            {
                db.currentOwners.Add(currentOwner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.carsID = new SelectList(db.Cars, "CarsID", "carNickName", currentOwner.carsID);
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "ownerLastName", currentOwner.ownerID);
            return View(currentOwner);
        }

        // GET: currentOwners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            currentOwner currentOwner = db.currentOwners.Find(id);
            if (currentOwner == null)
            {
                return HttpNotFound();
            }
            ViewBag.carsID = new SelectList(db.Cars, "CarsID", "carNickName", currentOwner.carsID);
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "ownerLastName", currentOwner.ownerID);
            return View(currentOwner);
        }

        // POST: currentOwners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "currentOwnerID,qtyofCars,ownerID,carsID")] currentOwner currentOwner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(currentOwner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.carsID = new SelectList(db.Cars, "CarsID", "carNickName", currentOwner.carsID);
            ViewBag.ownerID = new SelectList(db.Owners, "ownerID", "ownerLastName", currentOwner.ownerID);
            return View(currentOwner);
        }

        // GET: currentOwners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            currentOwner currentOwner = db.currentOwners.Find(id);
            if (currentOwner == null)
            {
                return HttpNotFound();
            }
            return View(currentOwner);
        }

        // POST: currentOwners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            currentOwner currentOwner = db.currentOwners.Find(id);
            db.currentOwners.Remove(currentOwner);
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
