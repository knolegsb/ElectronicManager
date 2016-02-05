using ElectronicManager.Domain;
using ElectronicManager.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db;


        // Homecontroller constructor to declare a dependency on the IDepartmentDataSource interface
        // it can't be created and used unless it receives an object that implements the IEmailSender interface.
        // it denpends only on the interface.
        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";
            var allDepartments = _db.Departments;

            return View(allDepartments);
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
    }
}