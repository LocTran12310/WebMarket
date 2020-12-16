using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMarket.Entities;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProviderManagerController : Controller
    {
        private WebMarketContext _context;
        public ProviderManagerController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var providers = _context.Provider.ToList();
            return View(providers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Provider provider)
        {
            var newprovider = new Provider()
            {
                Name=provider.Name,
                Address = provider.Address,
                Phone = provider.Phone,
            };
            _context.Provider.Add(newprovider);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var provider = _context.Provider.SingleOrDefault(t => t.Id == id);
            return View(provider);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Provider provider)
        {
            
            _context.Provider.Update(provider);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var provider = _context.Provider.SingleOrDefault(c => c.Id == id);
            _context.Provider.Remove(provider);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
