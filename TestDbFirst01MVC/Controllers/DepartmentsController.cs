using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestDbFirst01MVC.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: Departments
        public ActionResult Index()
        {
            var context = new TestDbFirst01MVC.DAL.AdventureWorks2017Entities2();
            var departments = context.Departments;

            return View(departments);
        }
    }
}