using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly WebMarketContext _context;

        public HomeController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
