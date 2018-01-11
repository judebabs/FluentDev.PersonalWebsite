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

        public WebsiteContent Content;

        public ActionResult Index()
        {
            InitializeWebsiteContent();
            TempData["Content.IntroText"] = Content.IntroductionText;

            var shortDescriptionLimitIndex = Content.IntroductionText.ToLower().IndexOf("career", StringComparison.Ordinal);
            var shortDescription = Content.IntroductionText.Substring(0, shortDescriptionLimitIndex + 7);

            TempData["Short.Intro"] = shortDescription;
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

        private void InitializeWebsiteContent()
        {
            Content = new WebsiteContent {IntroductionText = ConfigurationManager.AppSettings["Intro.Text"]};
        }
    }
}