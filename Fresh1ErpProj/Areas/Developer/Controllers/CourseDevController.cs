using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseOpworks;


namespace Fresh1ErpProj.Areas.Developer.Controllers
{
    public class CourseDevController : Controller
    {

      
        // GET: Developer/CourseDev
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Course()
        {
            return View();
        }

        public ActionResult CourseFees()
        {
            return View();
        }

        


        
    }
}