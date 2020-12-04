using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;

namespace WebMarket.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private WebMarketContext _context;
        public ProductViewComponent(WebMarketContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(string name)
        {
            var products = from p in _context.Product
                           join t in _context.Type
                           on p.IdType equals t.Id
                           where t.Name == name
                           select p;
            return View(products);
        }
    }
}