using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentDev.Web.JudePersonalWebsite.Models;

namespace FluentDev.Web.JudePersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var introText = ConfigurationManager.AppSettings["Intro.Text"];


            int indexOfShortString = introText.ToLower().IndexOf("career", StringComparison.Ordinal);

            var shortIntroText = introText.Substring(0, indexOfShortString + 5);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}