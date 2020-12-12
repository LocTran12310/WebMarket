using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;
using WebMarket.Models;
using WebMarket.Secure;

namespace WebMarket.Controllers
{
    public class CategoryController : Controller
    {
        private readonly WebMarketContext _context;
        private readonly IDataProtector protector;

        public CategoryController(WebMarketContext context, IDataProtectionProvider dataProtectionProvider,
                              DataProtectionPurposeStrings dataProtectionPurposeStrings)
        {
            _context = context;
            this.protector = dataProtectionProvider.CreateProtector(
               dataProtectionPurposeStrings.ProductIdRouteValue);
        }
       


        [HttpPost]
        public PartialViewResult Discount(int data)
        {
            var Dis = (from product in _context.Product.Where(p => p.Discount > 0)
                       from image in _context.Image.Where(i => i.IdProduct == product.Id).Take(1)
                       select new ProductVM
                       {
                           Id = product.Id,
                           Image = image.Image1,
                           Name = product.Name,
                           Price = product.Price,
                           Discount = product.Discount,
                           NewPrice = (Double)((100 - product.Discount) * product.Price) / 100
                       }).ToList();
            ViewBag.data = data;                     
            return PartialView("_ProductPartialView", Dis);
        }
      


        private int numpage = 6;
        [HttpGet("Category/{name}")]

        public IActionResult Index(string name ,int page=1)
        {
            var listproduct =
                (
                 from cate in _context.Category.Where(c => c.Name == name)
                 from product in _context.Product
                 join type in _context.Type
                 on product.IdType equals type.Id
                 where type.IdCategory == cate.Id
                 from image in _context.Image.Where(i => i.IdProduct == product.Id).Take(1)
                 select new ProductVM
                 {
                     Id = product.Id,
                     EncryptedId = protector.Protect(product.Id.ToString()),
                     type1 =type.Name,
                     Image = image.Image1,
                     Name = product.Name,
                     Price = product.Price,
                     Discount = product.Discount,
                     NewPrice = (Double)((100 - product.Discount) * product.Price) / 100
                 }).ToList().Skip((page - 1) * numpage).Take(numpage);
            int count;
            if (listproduct.Count() == 0)
            {
                count = 0;
            }
            else
            {
                count = (
               from product in _context.Product
               from cate in _context.Category
               from Image in _context.Image.Where(i => i.IdProduct == product.Id).Take(1)
               where cate.Name == name
               select product).Count();

            }

            ViewBag.name = name;
            ViewBag.total = (Int32)(Math.Ceiling((float)count / numpage));
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
               from image in _context.Image.Where(i => i.IdProduct == product.Id).Take(1)
               select new ProductVM
               {
                   Id = product.Id,
                   Image = image.Image1,
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
        [HttpGet("Category/{name}/{type}/{id}")]
        public IActionResult Detail(string name,string type,string id)
        {
            string decryptedId = protector.Unprotect(id);
            int decryptedIntId = Convert.ToInt32(decryptedId);
            ViewBag.name = name;

            var product = (from p in _context.Product.Where(p => p.Id == decryptedIntId)
                           from image in _context.Image.Where(i => i.IdProduct == p.Id).Take(1)
                           select new ProductVM
                           {
                               Id = p.Id,
                               EncryptedId = protector.Protect(p.Id.ToString()),
                               type1=type,
                               Image = image.Image1,
                               Name = p.Name,
                               Price = p.Price,
                               Discount = p.Discount,
                               NewPrice = (Double)((100 - p.Discount) * p.Price) / 100
                           }).SingleOrDefault();
            return View(product);
        }

    }
  

}
