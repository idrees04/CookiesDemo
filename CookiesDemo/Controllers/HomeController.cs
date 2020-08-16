using CookiesDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookiesDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User u)
        {

            if(ModelState.IsValid==true)
            {
                HttpCookie cookie = new HttpCookie("Username");
                cookie.Value = u.Username;

                HttpContext.Response.Cookies.Add(cookie);
                //to make Persistent cookie wil add this line
                //cookie.Expires = DateTime.Now.AddDays(2);
                cookie.Expires = DateTime.Now.AddMinutes(2);
                return RedirectToAction("Index","Dashboard");
            }
            return View(u);
        }
    }
}