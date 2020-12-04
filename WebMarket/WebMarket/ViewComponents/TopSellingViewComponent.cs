using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            var sellitems = (from p in _context.Product
                            join i in _context.Image
                            on p.Id equals i.IdProduct
                            select new ProductVM
                            {
                                Id = p.Id,
                                Image = i.Image1,
                                Name = p.Name,
                                Price = p.Price,
                                Discount = p.Discount,
                                NewPrice = (Double)((100 - p.Discount) * p.Price)
                            }).ToList();
            return View(sellitems);
        }
    }
}
