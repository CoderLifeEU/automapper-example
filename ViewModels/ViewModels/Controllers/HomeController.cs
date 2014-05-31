using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels.ViewModel;
using AutoMapper;
using ViewModels.Models;

namespace ViewModels.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            CreateUserViewModel model = new CreateUserViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
               User user = AutoMapper.Mapper.Map<CreateUserViewModel, User>(model);
                return RedirectToAction("Success");
                // Create User code           
            }
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

    }
}
