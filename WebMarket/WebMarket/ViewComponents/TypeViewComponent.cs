using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;

namespace WebMarket.ViewComponents
{
    public class TypeViewComponent : ViewComponent
    {
        private WebMarketContext _context;
        public TypeViewComponent(WebMarketContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(string name)
        {
            
            var types = from type in _context.Type
                        join category in _context.Category
                        on type.IdCategory equals category.Id 
                        select type;
            ViewBag.namecate = name;
            return View(types);
        }
    }
}
