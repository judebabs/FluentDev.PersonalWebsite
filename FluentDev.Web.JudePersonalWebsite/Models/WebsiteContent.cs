using System.Collections.Generic;

namespace FluentDev.Web.JudePersonalWebsite.Models
{
    public class WebsiteContent
    {

        public string IntroductionText { get; set; }

        public string PhoneNumber { get; set; }

        public string DisplayFullName { get; set; }

        public string ContactEmailAddress { get; set; }

        public bool ShouldDisplayPortofolio { get; set; }

        public bool DisplayBlog { get; set; }

        public string BlogToPullFromUrl { get; set; }

        public Dictionary<string,string> WhatIdo { get; set; }

        public Dictionary<string,string>HowIdoIt { get; set; }

        public Dictionary<string, string> FunFact { get; set; }


    }
}