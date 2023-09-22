using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondWeb.Models;

namespace SecondWeb.Controllers
{
    public class EnquiriesController : Controller
    {
        // GET: Enquiries
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult MailBody()
        {
            return PartialView();
        }

        public PartialViewResult SearchData(string FullName)
        {
            ViewBag.FullName = FullName;
            return PartialView();
        }

    }
}