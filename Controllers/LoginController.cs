using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondWeb.Models;

namespace SecondWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public int Auth(string email,string pwd)
        {
            int res = Procs.CheckUser(email,pwd);
            return res;
        }
    }
}