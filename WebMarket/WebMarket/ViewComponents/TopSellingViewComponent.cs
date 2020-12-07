using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;
using WebMarket.Models;

namespace WebMarket.ViewComponents
{
    public class TopSellingViewComponent : ViewComponent
    {
        private WebMarketContext _context;
        public TopSellingViewComponent(WebMarketContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var sellitems = (from product in _context.Product.Where(p=>p.Discount>0)
                             from image in _context.Image.Where(i=>i.IdProduct==product.Id ).Take(1)
                             select new ProductVM
                            {
                                Id = product.Id,
                                Image = image.Image1,
                                Name = product.Name,
                                Price = product.Price,
                                Discount = product.Discount,
                                NewPrice = (Double)((100 - product.Discount) * product.Price)/100
                            }).ToList();

            var offeritems = (from product in _context.Product.Where(p => p.Discount == 0)
                              from image in _context.Image.Where(i => i.IdProduct == product.Id).Take(1)
                              select new ProductVM
                              {
                                  Id = product.Id,
                                  Image = image.Image1,
                                  Name = product.Name,
                                  Price = product.Price,
                              }).ToList();
            ViewBag.offeritems = offeritems;
            return View(sellitems);
        }
    }
}
