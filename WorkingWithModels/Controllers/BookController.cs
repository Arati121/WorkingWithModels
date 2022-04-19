using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithModels.Models;

namespace WorkingWithModels.Controllers
{
    public class BookController : Controller
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
        public IActionResult List(Book b)
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book b)
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Book b)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Book b)
        {
            return View();
        }
    }
}
