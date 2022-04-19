using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithModels.Models;

namespace WorkingWithModels.Controllers
{
    public class EmployeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        [HttpPost]
        public IActionResult List(Employe emp)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employe emp)
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Employe emp)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Employe emp)
        {
            return View();
        }
    }
}
