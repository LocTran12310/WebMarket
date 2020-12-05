using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Models;
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
        
        public ActionResult Index()
        {
            var backgrounds = _context.Background.ToList();
            ViewBag.background = backgrounds;
            return View();
        }
    }
}
