using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace SeyahatProje.ViewComponents.Default
{
    public class _SliderPartail : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
