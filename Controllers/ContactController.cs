using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondWeb.Models;

namespace SecondWeb.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        public void ContactDetail(string FullName, string Email, string Subjects, string MM)
        {
            Procs.ContactDetail(FullName, Email, Subjects, MM);
        }
    }
}