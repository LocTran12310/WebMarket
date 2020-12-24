using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMarket.Entities;
using WebMarket.Helpers;
using WebMarket.Models;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderManagerController : Controller
    {
        private WebMarketContext _context;
        public OrderManagerController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var order = _context.Order.ToList();
           
            return View(order);
        }
        [HttpPost]
       
        public ActionResult Detail(int id)
        {
         
      
            var detail = _context.Orderdetail.Include(od => od.IdOrderNavigation).Include(od => od.IdProductNavigation).Where(od=> od.IdOrder == id).ToList();
            var order = _context.Order.SingleOrDefault(o=>o.Id ==id);
           
            ViewBag.order = order;

            return this.PartialView("_OrderPatial" , detail);

        }
       
           public IActionResult Status()
        {
                Order ord = new Order();
                ord.Status = 1;
                _context.Update(ord);
                _context.SaveChanges();
                return RedirectToAction("Status", "OrderManager");
        }

    }
}
