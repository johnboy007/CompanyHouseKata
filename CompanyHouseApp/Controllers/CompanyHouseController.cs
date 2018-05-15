using CompanyHouseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyHouseApp.Controllers
{
    public class CompanyHouseController : Controller
    {
        // GET: CompanyHouse
        public ActionResult Index(string name)
        {
            var comanyHouse = new Services.CompanyHouse(name);
            return View(comanyHouse.GetList());
        }
    }
}