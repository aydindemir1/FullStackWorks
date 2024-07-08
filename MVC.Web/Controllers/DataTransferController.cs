using Microsoft.AspNetCore.Mvc;
using MVC.Web.Models;

namespace MVC.Web.Controllers
{
    public class DataTransferController : Controller
    {
        public IActionResult TwoPage()
        {
            TempData["userId"] = 10;
            return View();
        }
        public IActionResult OnePage() 
        {
          return View();
        }
        public IActionResult Index()
        {
            var name = "Ali";

            var names = new List<string> { "Ali", "Ayşe", "Zeynep", "Rabia"};

            ViewData["name"] = name;

            ViewData["nameList"] = names;

            var number = 10;

            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            ViewBag.number = number;

            ViewBag.numberList = numbers;

            var pageModel = new IndexPageViewModel();

            pageModel.Name = name;
            pageModel.Names = names;
            pageModel.Number = number;
            pageModel.Numbers = numbers;

            return View(pageModel);
        }
    }
}
