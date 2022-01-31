using Microsoft.AspNetCore.Mvc;
using MVC_assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_assignment.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(int temp)
        {
            ViewBag.message = DoctorModel.CheckIfFever(temp);

            return View();
        }
    }
}
