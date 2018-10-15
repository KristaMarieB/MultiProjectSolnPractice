using HometownZoo.Core.Models;
using HometownZoo.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiProjectSolnPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // did this so we could see another way of adding a reference
            // right click references in this project, add-reference, check mark the one we want to add, click OK
            // then add using to the file
            Person p = new Person()
            {
                Name = "Krista Brassesco"
            };

            string randomZip = "98373";
            if (Validator.IsValidUSZipCode(randomZip))
            {
                
            }

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