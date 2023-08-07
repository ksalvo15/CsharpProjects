using CarInsurance.Models;
using CarInsurance.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
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
                    quoteVm.Email = quote.EmailAddress;
                    quoteVm.FinalQuote = quote.FinalQuote;

                    quoteVms.Add(quoteVm);

                }
                return View(quoteVms);
            }
        }
    }
}