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
        public IActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Feedback(string txtName, string txtFeed)
        {
            if (txtName != null)
                ViewData["name"] = txtName;
            if (txtFeed != null)
                ViewData["feed"] = txtFeed;

            return View();
        }
    }
}
