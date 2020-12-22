using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMarket.Entities;

namespace WebMarket.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    [Authorize]
    public class PriceUpdatedManagerController : Controller
    {
        private WebMarketContext _context;
        public PriceUpdatedManagerController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var priceUpdateList = _context.Priceupdate.Include(a=>a.IdAdminNavigation).Include(p=>p.IdProductNavigation);
            return View(priceUpdateList);
        }
    }
}
