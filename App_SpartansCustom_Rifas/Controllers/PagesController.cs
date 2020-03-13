using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lexa.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult BadRequest()
        {
            return View();
        }

        public ActionResult InternalServerError()
        {
            return View();
        }

        public ActionResult Blank()
        {
            return View();
        }

        public ActionResult Directory()
        {
            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult LockScreen()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult RecoverPassword()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Timeline()
        {
            return View();
        }
    }
}