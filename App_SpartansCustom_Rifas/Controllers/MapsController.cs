using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lexa.Controllers
{
    public class MapsController : Controller
    {
        public ActionResult Google()
        {
            return View();
        }

        public ActionResult Vector()
        {
            return View();
        }
    }
}