using Microsoft.AspNetCore.Mvc;
using RolesApp.Models;

namespace RolesApp.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;

        public CartController(Cart c)
        {
            cart = c;
        }
        public IActionResult Index()
        {
            return View(cart);
        }
    }
}
