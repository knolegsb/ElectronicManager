using ElectronicManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicManager.Web.Controllers
{
    public class AdminController : Controller
    {
        private IUserRepository repository;

        public AdminController(IUserRepository repo)
        {
            repository = repo;
        }

        public ActionResult ChangeLoginName(string oldName, string newName)
        {
            User user = repository.FetchByLoginName(oldName);
            user.LoginName = newName;
            repository.SubmitChanges();
            return View();
        }
    }
}