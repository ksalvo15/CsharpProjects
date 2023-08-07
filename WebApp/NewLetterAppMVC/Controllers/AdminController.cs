﻿using NewLetterAppMVC.Models;
using NewLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    //var signups = db.NewsSignUps.Where(x => x.Removed == null).ToList();
                    var signups = (from c in db.NewsSignUps
                                    where c.Removed == null
                                    select c).ToList();
                    var signupVms = new List<SignupVm>();
                    foreach (var signup in signups)
                    {
                        var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                        signupVm.FirstName = signup.FirstName;
                        signupVm.LastName = signup.LastName;
                        signupVm.EmailAddress = signup.EmailAddress;
                        signupVms.Add(signupVm);
                    }
                    return View(signupVms);
                }            
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.NewsSignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
//string queryString = @"SELECT Id,FirstName, LastNAme, EmailAddress, SocialSecurityNumber from NewsSignUps";
//List<NewsLetterSignup> signups = new List<NewsLetterSignup>();

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);
//    connection.Open();
//    SqlDataReader reader = command.ExecuteReader();
//    while (reader.Read())
//    {
//        var signup = new NewsLetterSignup();
//        signup.Id = Convert.ToInt32(reader["Id"]);
//        signup.FirstName = reader["FirstName"].ToString();
//        signup.LastName = reader["LastName"].ToString();
//        signup.EmailAddress = reader["EmailAddress"].ToString();
//        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
//        signups.Add(signup);
//    }
//}