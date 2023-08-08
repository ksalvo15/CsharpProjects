using CarInsurance1.Models;
using CarInsurance1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
                {                    
                    List<Insuree> quotes = db.Insurees.ToList();
                    var quoteVms = new List<QuoteVm>();
                    foreach (var quote in quotes)
                    {
                        QuoteVm quoteVm = new QuoteVm();
                        quoteVm.Id = quote.Id;
                        quoteVm.FirstName = quote.FirstName;
                        quoteVm.LastName = quote.LastName;
                        quoteVm.EmailAddress = quote.EmailAddress;
                        quoteVm.Quote = quote.Quote;

                        quoteVms.Add(quoteVm);

                    }
                    return View(quoteVms);
                }            
        }

        public ActionResult InsureeQuote(int id, int age, int caryear, bool DUI, bool fullcover, int ticket, string carmodel, string carmake, string emailAddress, string firstName, string lastName, int Quote)
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
                quote.Quote = Quote;

                
                int initialQuote = 0;

                //a-d
                var insureeage = quote.DateOfBirth;
                string strAge = insureeage.ToString();
                age = Convert.ToInt32(strAge);

                if (age <= 18)
                {
                    initialQuote += 100;
                }
                else if (age >= 19 && age <= 25)
                {
                    initialQuote += 50;
                }
                else
                {
                    initialQuote += 25;
                }

                //e,f               
                quote.CarYear = caryear;

                if (caryear >= 2000 && caryear <= 2015)
                {
                    initialQuote += 25;
                }

                //g-h

                if (carmake == "Porshe")
                {
                    initialQuote += 25;
                }

                if (carmake == "Porshe" & carmodel == "911 Carrera")
                {
                    initialQuote += 25;
                    initialQuote += 25;
                }

                //i-k

                initialQuote += ticket * 10;

                if (DUI == true && fullcover != true)
                {
                    Quote = (int)(initialQuote * 1.25);
                }
                else if (DUI == true && fullcover == true)
                {
                    Quote = (int)((initialQuote * 1.25) * 1.5);
                }
                else
                {
                    Quote = initialQuote;
                }
                db.Insurees.Add(quote);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}