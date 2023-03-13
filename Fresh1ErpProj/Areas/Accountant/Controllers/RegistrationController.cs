using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fresh1ErpProj.Extra;

namespace Fresh1ErpProj.Areas.Accountant.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Accountant/Registration
        public ActionResult Index()
        {
            ViewBag.rsg = Extra.Works.GenerateRegistercode();
            return View();
        }
        public ActionResult Registrationform()
        {
            return View();
        }
    }
}