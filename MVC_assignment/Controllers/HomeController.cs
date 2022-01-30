 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_assignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {
            ViewBag.year1 = "2021 - 2022 Course at Lexicon";
            ViewBag.content1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            ViewBag.year2 = "2020 - 2021 Made some money";
            ViewBag.content2 = "Mauris augue massa, suscipit non interdum et, facilisis quis augue.";
            ViewBag.year3 = "2021 - 2022 Lorem";
            ViewBag.content3 = "Vestibulum eget turpis ut leo viverra eleifend. Fusce nec ipsum et nibh consectetur lacinia.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.adress = "Bond street 1, London, England.";
            ViewBag.mobile = "+44 70 255255";
            ViewBag.email = "a.torin@gmail.com";

            return View();
        }
        public IActionResult Projects()
        {
            ViewBag.project1 = "https://github.com/Bobbafesk/ConsoleCalculatorBetter";
            ViewBag.description1 = "I nice simple console calculator.";
            ViewBag.project2 = "https://github.com/Bobbafesk/ConsoleHangman";
            ViewBag.description2 = "The game Hang man in console.";
            ViewBag.project3 = "https://github.com/Bobbafesk/VendingMachineController";
            ViewBag.description3 = "A vending machine stub to use.";
            ViewBag.project4 = "https://github.com/Bobbafesk/CSS-uppgift";
            ViewBag.description4 = "A html and css assignment.";
            ViewBag.project5 = "https://github.com/Bobbafesk/Sokoban-assignment";
            ViewBag.description5 = "The game Sokoban.";
            ViewBag.project6 = "https://github.com/Bobbafesk/MVC_assignment";
            ViewBag.description6 = "MVC project.";
            return View();
        }
    }
}
