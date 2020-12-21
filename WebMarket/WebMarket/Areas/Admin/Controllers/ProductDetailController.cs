using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductDetailController : Controller
    {
        private WebMarketContext _context;
        public ProductDetailController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            ViewBag.product = _context.Product.SingleOrDefault(p=>p.Id==id);
            var product_detail = _context.Productdetail.Where(p => p.IdProduct == id).ToList();
            return View(product_detail);
        }
        [HttpPost]
        public IActionResult Create(Productdetail detail)
        {
            var newdetail = new Productdetail()
            {
                IdProduct = detail.IdProduct,
                Quantity = detail.Quantity,
                EntryDate = detail.EntryDate,
                Mfg = detail.Mfg,
                Exp = detail.Exp
            };
            _context.Add(newdetail);
            _context.SaveChanges();
            return RedirectToAction("Index",detail.IdProduct);
        }
    }
}
