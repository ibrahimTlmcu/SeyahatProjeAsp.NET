using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace SeyahatProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
