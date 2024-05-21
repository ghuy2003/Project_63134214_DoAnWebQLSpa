using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_63134214.Controllers
{
    public class AdminLogin_63134214Controller : Controller
    {
        // GET: AdminLogin_63134214
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Your authentication logic goes here
            // For example, check if the username and password are valid

            if (username == "admin" && password == "admin123") // Replace with your authentication logic
            {
                // Authentication successful
                // Redirect to Home/Index upon successful login
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Invalid credentials. Please try again."; // Display error message
                return View("Index"); // Show login view again
            }
        }
    }
}