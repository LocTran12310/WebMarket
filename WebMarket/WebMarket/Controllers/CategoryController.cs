using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;
using WebMarket.Models;

namespace WebMarket.Controllers
{
    public class CategoryController : Controller
    {
        private readonly WebMarketContext _context;

       
        public CategoryController(WebMarketContext context)
        {
            _context = context;
        }
        private int numpage = 6;
        [HttpGet("Category/{name}")]
        public IActionResult Index(string name ,int page=1)
        {
            var listproduct =
                (
                from product in _context.Product
                from cate in _context.Category
                where cate.Name==name
                select new ProductVM
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Discount = product.Discount,
                    NewPrice = (Double)((100 - product.Discount) * product.Price) / 100
                }).ToList().Skip((page - 1) * numpage).Take(numpage);
            var count = (
                from product in _context.Product
                from cate in _context.Category
                where cate.Name == name
                select product).Count();
            ViewBag.name = name;
            ViewBag.total = (Int32)(Math.Ceiling((float)count/numpage));
            ViewBag.currentpage = page;
            return View(listproduct);
        }
        [HttpGet("Category/{name}/{type}")]
        public IActionResult ProductByType(string name ,string type,int page =1)
        {
            var listproduct =
               (
               from product in _context.Product
               join t in _context.Type
               on product.IdType equals t.Id
               from cate in _context.Category
               where cate.Name == name && t.Name == type
               select new ProductVM
               {
                   Id = product.Id,
                   Name = product.Name,
                   Price = product.Price,
                   Discount = product.Discount,
                   NewPrice = (Double)((100 - product.Discount) * product.Price) / 100
               }).ToList().Skip((page - 1) * numpage).Take(numpage);
            var count = (from product in _context.Product
                        join t in _context.Type
                        on product.IdType equals t.Id
                        where t.Name == type
                        select product).Count();
            ViewBag.name = name;
            ViewBag.total = (Int32)(Math.Ceiling((float)count / numpage));
            ViewBag.currentpage = page;
            return View("Index",listproduct);
        }
        
    }
}
