using Microsoft.AspNetCore.Mvc;

namespace SeyahatProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
