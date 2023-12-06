using DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;



namespace SeyahatProje.ViewComponents.Default
{
    public class _Static :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "a123";
            return View();
        }
    }
}
