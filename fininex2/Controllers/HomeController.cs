using fininex2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.EntryProcessor;

namespace fininex2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult EntryInput()
        {
            ViewBag.Message = "Entry input.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EntryInput(EntryModel model)
        {
            if (ModelState.IsValid)
            {
                int recordCreated = CreateEntry(model.Name, model.Amount, model.Currency, model.Description);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}