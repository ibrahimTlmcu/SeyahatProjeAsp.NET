using EntityLayer.Concrate;
using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;

using System;
using Microsoft.AspNetCore.Mvc;
using DataAccesLayer.EntityFramework;
using System;
using System.Linq;

namespace SeyahatProje.ViewComponents.Default
{
    public class _PopularDestinationPartial :ViewComponent
    {

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {

            var value = destinationManager.TGetList();
            return View(value);
        }
        
    }
}
