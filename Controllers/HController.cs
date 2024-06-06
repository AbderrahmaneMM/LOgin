using LOgin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace LOgin.Controllers
{
    public class HController : Controller
    {
        // GET: H
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Swip(Hmodel hm)
        {
            if (ModelState.IsValid)
            {
                if (hm.Password== 123)
                {
                    return RedirectToAction("View");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }return View(hm);
        }
        [HttpGet]
        public ViewResult Hview(Hmodel hm)
        {
              Swip(hm);
            return View("HView",hm);
         
        }
        [HttpPost]
        public ViewResult Lview(Lmodel lm) 
        {
            return View("View", lm);
        }
    }
}