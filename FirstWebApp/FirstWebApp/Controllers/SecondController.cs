using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class SecondController : Controller
    {
       // [Route("MyPath")]
        public IActionResult Index(string id)
        {
            if (id != null)
                ViewData["Name"] = id;
            return View();
        }
    }
}
