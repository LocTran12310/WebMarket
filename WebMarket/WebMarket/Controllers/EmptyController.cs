using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;

namespace WebMarket.Controllers
{
    public class EmptyController : Controller
    {
        private WebMarketContext _context;
        public EmptyController(WebMarketContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var backgrounds = _context.Background;

            ViewBag.background = backgrounds;
            return View();
        }
    }
}
