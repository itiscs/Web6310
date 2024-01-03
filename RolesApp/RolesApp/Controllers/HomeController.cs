using Microsoft.AspNetCore.Mvc;
using RolesApp.Models;
using System.Diagnostics;

namespace RolesApp.Controllers
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
            if(HttpContext.Session.Keys.Contains("Product"))
            {
                var id = HttpContext.Session.GetInt32("Product");
                ViewData["Product"] = $"Выбран товар - Product {id}";
            }    

            return View();
        }

        public IActionResult Privacy()
        {
            if(HttpContext.Request.Cookies.ContainsKey("Color"))
                ViewData["Color"] = HttpContext.Request.Cookies["Color"].ToString();

            if (HttpContext.Request.Cookies.ContainsKey("Date"))
                ViewData["Date"] = HttpContext.Request.Cookies["Date"].ToString();

            return View();
        }

        [HttpPost]
        public IActionResult Privacy(string sel, int product, DateTime date1)
        {
            HttpContext.Response.Cookies.Append("Color", sel);
            HttpContext.Response.Cookies.Append("Date", date1.ToString("s"));

            HttpContext.Session.SetInt32("Product", product);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
