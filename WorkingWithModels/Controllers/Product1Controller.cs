using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithModels.Models;

namespace WorkingWithModels.Controllers
{
    public class Product1Controller : Controller
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
        public IActionResult List(Product1 p)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product1 p)
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product1 p)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Product1 p)
        {
            return View();
        }
    }
}
