using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMarket.Entities;
using WebMarket.Helpers;
using WebMarket.Models;
namespace WebMarket.Controllers
{
    public class Thanhtoan : Controller
    {

        private WebMarketContext _context;
        public Thanhtoan(WebMarketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            int customer = HttpContext.Session.Get<int>("KhachHang");
            var cart=HttpContext.Session.Get<List<CartItem>>("GioHang");
            if (cart != null)
            {
                double? TongTien = cart.Sum(p => p.TotalPrice);
                ViewBag.TongTien = TongTien;
                int Quanity = cart.Sum(c => c.Quantity);
                ViewBag.Quanity = Quanity;
            }
            if (customer == 0)
            {
                return RedirectToAction("Login", "Customer");
            }
            var customer_info = _context.Customer.Find(customer);
            ViewBag.cart = cart;
            return View(customer_info);
        }
        [HttpPost]
        public IActionResult Pay(Customer customer)
        {
            int id = HttpContext.Session.Get<int>("KhachHang");
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");

            
            Order ord = new Order();
            ord.Name = customer.Name;
            ord.Address = customer.Address;
            ord.OrderDate = DateTime.Now;
            ord.IdAdmin = 1;
            ord.IdCustomer = id;
            ord.Email = customer.Email;
            ord.Phone = customer.Phone;
            _context.Order.Add(ord);
            _context.SaveChanges();

            int lastOrder = _context.Order.OrderByDescending(a => a.Id).Select(a => a.Id).First();
            List<Orderdetail> lorderdetail = new List<Orderdetail>();
            foreach (var item in cart)
            {
                var orderdetail = new Orderdetail
                {
                    IdOrder = lastOrder,
                    IdProduct = item.Id,
                    Quantity = item.Quantity,
                    Discount = item.Discount,
                    Newprice = item.NewPrice,
                };
                _context.Orderdetail.Add(orderdetail);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Cart");
        }
    }
}
