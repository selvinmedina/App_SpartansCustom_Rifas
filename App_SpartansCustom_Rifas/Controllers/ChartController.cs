using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lexa.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult c3()
        {
            return View();
        }

        public ActionResult Chartist()
        {
            return View();
        }

        public ActionResult Chartjs()
        {
            return View();
        }

        public ActionResult Flot()
        {
            return View();
        }

        public ActionResult Morris()
        {
            return View();
        }

        public ActionResult Other()
        {
            return View();
        }   
    }
}