using NewLetterAppMVC.Models;
using NewLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new NewsSignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.NewsSignUps.Add(signup);
                    db.SaveChanges();
                }
                return View("Success");
            }

        }
    }
}

//private readonly string connectionString = @"Data Source=DESKTOP-OA8SL67\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

//string queryString = @"INSERT INTO NewsSignUps (FirstName, LastName, EmailAddress, SocialSecurityNumber) VALUES
//                        (@FirstName, @LastName, @EmailAddress, @SocialSecurityNumber)";

//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    SqlCommand command = new SqlCommand(queryString, connection);
//    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
//    command.Parameters.Add("@LastName", SqlDbType.VarChar);
//    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

//    command.Parameters["@FirstName"].Value = firstName;
//    command.Parameters["@LastName"].Value = lastName;
//    command.Parameters["@EmailAddress"].Value = emailAddress;

//    connection.Open();
//    command.ExecuteNonQuery();
//    connection.Close();
//}