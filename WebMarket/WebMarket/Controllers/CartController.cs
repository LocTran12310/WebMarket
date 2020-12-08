using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMarket.Entities;
using WebMarket.Helpers;
using WebMarket.Models;

namespace WebMarket.Controllers
{
    public class CartController : Controller
    {
        private readonly WebMarketContext _context;

        public CartController(WebMarketContext context)
        {
            _context = context;
        }

        public List<CartItem> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItem>();
                }
                return data;
            }
        }

        public IActionResult Index()
        {
            return View(Carts);
        }
        [TempData]
        public string TotalQuantity { get; set; }

        [HttpPost]
        public IActionResult AddToCart(int id, int quantity, string type = "Normal")
        {
            var myCart = Carts;
            var item = myCart.Where(p => p.Id == id).SingleOrDefault();

            if (item == null)//chưa có
            {
                item = (from product in _context.Product.Where(p => p.Id == id)
                        from image in _context.Image.Where(i => i.IdProduct == product.Id).Take(1)
                        select new CartItem { 
                            Id = product.Id,
                            Image=image.Image1,
                            Name = product.Name,
                            Price = product.Price.Value,
                            Discount = product.Discount,
                            Quantity = quantity
                        }).SingleOrDefault();
                myCart.Add(item);
            }
            else
            {
                item.Quantity += quantity;
            }
            HttpContext.Session.Set("GioHang", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    quantity = Carts.Sum(c => c.Quantity)
                });
            }
            return Json(myCart);
        }

    }
}
