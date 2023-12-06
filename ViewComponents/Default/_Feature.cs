using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyahatProje.ViewComponents.Default
{
    public class _Feature :ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFatureDal());

        public IViewComponentResult Invoke()
        {
            
            
            ViewBag.v1 = featureManager.TGetList();
            return View();
        }

    }
}
