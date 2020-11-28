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
        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            var cate = _context.Category.Where(p => p.Name == name).SingleOrDefault();
          
            var types = _context.Type.Where(p => p.IdCategory == cate.Id).ToList();
            ViewBag.namecate = cate.Name;
            return View(types);
        }
    }
}
