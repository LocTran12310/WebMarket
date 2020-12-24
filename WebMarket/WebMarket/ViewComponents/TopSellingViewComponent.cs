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
        public async Task<IViewComponentResult> InvokeAsync()
        {
      
            var sellitems = (from product in _context.Product.Where(p => p.Discount >= 0)                 
                             select new ProductVM
                             {
                                 Id = product.Id,
                                 Image = product.Image,
                                 Name = product.Name,
                                 Price = product.Price,
                                 Discount = product.Discount,
                                 NewPrice = (Double)((100 - product.Discount) * product.Price) / 100
                             }).ToList();

            var offeritems = (from product in _context.Product.Where(p => p.Discount > 0)
                              select new ProductVM
                              {
                                  Id = product.Id,
                                  Image = product.Image,
                                  Name = product.Name,
                                  Price = product.Price,
                              }).ToList();

            var typess = (from type in _context.Type
                          from Category in _context.Category.Where(i => i.Id == type.IdCategory).Take(1)
                          select new ProductVM
                          {
                                type1 = type.Name ,
                              
                          }).ToList();
            ViewBag.type2 = typess;
            ViewBag.offeritems = offeritems;
            return View(sellitems);
        }
    }
}
