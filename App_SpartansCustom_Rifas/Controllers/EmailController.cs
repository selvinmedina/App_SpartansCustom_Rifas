using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lexa.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult Compose()
        {
            return View();
        }

        public ActionResult Inbox()
        {
            return View();
        }

        public ActionResult Read()
        {
            return View();
        }
    }
}