using Microsoft.AspNetCore.Mvc;

namespace ex03_Baitaptonghop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
