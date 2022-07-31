using Microsoft.AspNetCore.Mvc;

namespace Commercial_1.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
