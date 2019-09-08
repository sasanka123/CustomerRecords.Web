using CustomerRecords.BLL;
using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerRecords.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserDataService userDataService;

        public LoginController(IUserDataService userDataService)
        {
            this.userDataService = userDataService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new UserLogin();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(UserLogin model)
        {
            if (ModelState.IsValid)
            {
                userDataService.UserLogin(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
    }
}
