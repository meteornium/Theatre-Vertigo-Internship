using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheatreCMS3.Areas.Rent.Models;
using TheatreCMS3.Areas.Rent.ViewModels;
using TheatreCMS3.Models;

namespace TheatreCMS3.Areas.Rent.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rent/Rentals
        public ActionResult Index()
        {
            return View(db.Rentals.ToList());
        }

        // GET: Rent/Rentals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        // GET: Rent/Rentals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rent/Rentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRental([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Rentals.Add(rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rental);
        }

        // rental equipment method create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRentalEquipment([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages,ChokingHazard,SuffocationHazard,PurchasePrice")] RentalEquipment rental)
        {
            if (ModelState.IsValid)
            {
                db.Rentals.Add(rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rental);
        }

        // rental room method create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRentalRoom([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages,RoomNumber,SquareFootage,MaxOccupancy")] RentalRoom rental)
        {
            if (ModelState.IsValid)
            {
                db.Rentals.Add(rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rental);
        }

        // GET: Rent/Rentals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var rental = db.Rentals.Find(id);
            AllRentalsVM rentals = new AllRentalsVM(rental);
            if (rental == null)
            {
                return HttpNotFound();
            }
            ViewBag.Value = rental.GetType().ToString();
            if (ViewBag.Value == "TheatreCMS3.Areas.Rent.Models.Rental")
            {
                ViewBag.EditValue = "EditRental";
            } else if (ViewBag.Value == "TheatreCMS3.Areas.Rent.Models.RentalRoom")
            {
                ViewBag.EditValue = "EditRentalRoom";
            } else if (ViewBag.Value == "TheatreCMS3.Areas.Rent.Models.RentalEquipment")
            {
                ViewBag.EditValue = "EditRentalEquipment";
            }
            return View(rentals);
        }

        // POST: Rent/Rentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditRental([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rental).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rental);
        }

        // edit rental equipment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditRentalEquipment([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages,ChokingHazard,SuffocationHazard,PurchasePrice")] RentalEquipment rental)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rental).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rental);
        }

        // edit rental room
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditRentalRoom([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages,RoomNumber,SquareFootage,MaxOccupancy")] RentalRoom rental)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rental).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rental);
        }

        // GET: Rent/Rentals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        // POST: Rent/Rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rental rental = db.Rentals.Find(id);
            db.Rentals.Remove(rental);
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
