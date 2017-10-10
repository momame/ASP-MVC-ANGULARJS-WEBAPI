using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_MVC_StudentInfo.Controllers
{
    public class TillPrintersController : Controller
    {
        // GET: TillPrinters
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowTills()
        {
            return PartialView("ShowAllTill");
        }

        public ActionResult AddTill()
        {
            return PartialView("AddTill");
        }

        public ActionResult EditTill()
        {
            return PartialView("EditTill");
        }
    }
}