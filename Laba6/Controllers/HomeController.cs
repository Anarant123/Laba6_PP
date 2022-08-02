using Laba6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laba6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Task1()
        {
            return View();
        }
        public IActionResult Task2()
        {
            return View();
        }
        public IActionResult Task3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Task1(string Sentence)
        {
            int count = 0;
            for(int i = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == ' ') count++;

            }
            ViewBag.Sentence = Sentence;
            ViewBag.Count = count;
            return View();
        }
        [HttpPost]
        public IActionResult Task2(string N)
        {
            int n = int.Parse(N);
            int znak = -1;
            double a;
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                znak *= -1;
                a = Convert.ToDouble(znak + "," + (i));
                result += a;
            }
            ViewBag.n = n;
            ViewBag.Result = Math.Round(result, 1);
            return View();
        }
        [HttpPost]
        public IActionResult Task3(string Word)
        {
            string a = Word.TrimStart();
            a = a.TrimEnd();
            a = a.ToLower();
            if (a[0] == a[a.Length - 1])
                ViewBag.Word = "Да! Слово начинается и заканчивается на одну и ту же букву.";
            else
                ViewBag.Word = "Нет! Слово начинается и заканчивается на разные буквы.";
            ViewBag.w = Word;
            return View();
        }
    }
}