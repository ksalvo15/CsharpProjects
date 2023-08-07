using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;


namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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


        private ActionResult InsureeQuote (int id, int age, int caryear, bool DUI, bool fullcover, int ticket, string carmodel, string carmake, string emailAddress, string firstName, string lastName)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {


                var quote = new Insuree();
                quote.Id = id;
                quote.FirstName = firstName;
                quote.LastName = lastName;
                quote.EmailAddress = emailAddress;
                quote.CarMake = carmake;
                quote.CarModel = carmodel;
                quote.SpeedingTickets = ticket;
                quote.DUI = DUI;
                quote.CoverageType = fullcover;

                //a-d
                var insureeage = quote.DateOfBirth;
                string strage = insureeage.ToString();
                age = Convert.ToInt32(strage);
                int insureeageprice;
                int insureebase = 50;

                if (age <= 18)
                {
                    insureeageprice = insureebase + 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    insureeageprice = insureebase + 50;
                }
                else
                {
                    insureeageprice = insureebase +25;
                }

                //e,f
                int caryearprice = 0;
                quote.CarYear = caryear;

                if (caryear >= 2000 && caryear <= 2015)
                {
                    caryearprice = 25;
                }

                //g-h
                
                int carmakeprice;
                int carmodelprice;
                if (carmake == "Porshe")
                {
                    carmakeprice = 25;
                }
                else
                {
                    carmakeprice = 0;
                }

                if (carmake == "Porshe" & carmodel == "911 Carrera")
                {
                    carmakeprice = 25;
                    carmodelprice = 25;
                }
                else
                {
                    carmakeprice = 0;
                    carmodelprice = 0;
                }

                //i-k
                
                int speedingprice;
                speedingprice = ticket * 10;
                
                int FinalQuote;

                int initialQuote = insureebase + speedingprice + caryearprice + carmakeprice + carmodelprice;

                if (DUI == true && fullcover != true)
                {
                    FinalQuote = (int)(initialQuote * 1.25);
                }
                else if (DUI == true && fullcover == true)
                {
                    FinalQuote = (int)((initialQuote * 1.25)*1.5);
                }
                else
                {
                    FinalQuote = initialQuote;
                }
                db.Insurees.Add(quote);
                db.SaveChanges();
            }
            return RedirectToAction("Admin");
        }
    }
}
