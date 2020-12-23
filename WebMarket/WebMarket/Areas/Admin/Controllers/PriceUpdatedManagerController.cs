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
            var dateFrom = "2000-12-23 09:06:05.5026713";
            var dateTo = "2030-12-23 09:06:05.5026713";
            var queryables = _context.Priceupdate.FromSqlRaw("SELECT * FROM dbo.priceupdate FOR SYSTEM_TIME ALL").AsNoTracking().OrderByDescending(od=> od.DateUpdate).ToList();
            return View(queryables);
            
        }
    }
}
