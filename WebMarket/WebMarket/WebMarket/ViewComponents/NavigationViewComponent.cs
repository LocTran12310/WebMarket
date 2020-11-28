using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;

namespace WebMarket.ViewComponents
{
    public class NavigationViewComponent : ViewComponent
    {
        private WebMarketContext _context;
        public NavigationViewComponent(WebMarketContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Category.ToListAsync());
        }
    }
}
