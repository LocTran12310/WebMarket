using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMarket.Entities;
using WebMarket.Helpers;
using Type = WebMarket.Entities.Type;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductManagerController : Controller
    {
        private WebMarketContext _context;
        public ProductManagerController(WebMarketContext context)
        {
            _context = context;
        }
        public List<Product> data(int cate = 0, int ty = 0)
        {

            var products = (from product in _context.Product
                            join type in _context.Type
                            on product.IdType equals type.Id
                            join category in _context.Category
                            on type.IdCategory equals category.Id
                            select product);
            if (cate != 0)
            {
                products = (from product in _context.Product
                            join type in _context.Type
                            on product.IdType equals type.Id
                            join category in _context.Category
                            on type.IdCategory equals category.Id
                            where category.Id == cate
                            select product);
                if (ty != 0)
                {
                    products = (from product in _context.Product
                                join type in _context.Type
                                on product.IdType equals type.Id
                                join category in _context.Category
                                on type.IdCategory equals category.Id
                                where category.Id == cate && type.Id == ty
                                select product);
                }
            }
            var pro = products.Include(p => p.IdTypeNavigation).Include(c => c.IdProviderNavigation).ToList();
            return pro;
        }
       
        public IActionResult Index(int cate=0,int ty=0)
        {
            Category c = new Category()
            {
                Id = 0,
                Name = "All Categories",
            };
            var categories = _context.Category.ToList();
            categories.Insert(0, c);
            ViewBag.IdCategory = new SelectList(categories, "Id", "Name");
            var products = data(cate, ty);
            ViewBag.cateId = cate;
            ViewBag.typeId = ty;
            return View(products);
        }
        public IActionResult filterajax(int cate ,int ty)
        {
            var products = data(cate, ty);
            return PartialView("_filterajax",products);
        }
        
        public IActionResult selectajax(int cate = 0)
        {
            var t = new Type()
            {
                Id = 0,
                Name = "All Types",
            };
            var types = _context.Type.Where(t => t.IdCategory == cate).ToList();
            types.Insert(0, t);
            ViewBag.IdType = new SelectList(types, "Id", "Name");
         
            return PartialView("_selectajax");
        }
        [HttpGet]
        public IActionResult Create()
        {
            var newcate = new Category()
            {
                Id = 0,
                Name = "All Categories",
            };
            var providers = _context.Provider.ToList();
            var types = _context.Type.ToList();
            var cate = _context.Category.ToList();
            cate.Insert(0,newcate);
            ViewBag.IdProvider = new SelectList(providers, "Id", "Name");
            ViewBag.IdType = new SelectList(types, "Id", "Name");
            ViewBag.IdCategory = new SelectList(cate, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product,IFormFile file)
        {
            string image = Helpers.ExtensionHelper.UploadFile(file, "img-products");
            if (image == "error")
            {
                return Content("the image is null ");
            }
            var newproduct = new Product()
            {
                Name = product.Name,
                Discount =product.Discount,
                Price = product.Price,
                Image = image,
                Description = product.Image,
                IdProvider = product.IdProvider,
                IdType = product.IdType
            };
            _context.Product.Add(newproduct);
            _context.SaveChanges();
            int lastRow = _context.Product.OrderByDescending(a => a.Id).Select(a => a.Id).First();
            var user = @User.Claims.FirstOrDefault(c => c.Type == "Ma").Value;
            var updatedetail = new Priceupdate()
            {
                IdProduct = lastRow,
                IdAdmin = Int32.Parse(user),
                Price =(double) product.Price,
                Priceupdated = (double)((100 - product.Discount) * product.Price) / 100,
                DateUpdate = default,
                DateEnd = default,
            };
            _context.Priceupdate.Add(updatedetail);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _context.Product.SingleOrDefault(p => p.Id == id);
            var providers = _context.Provider.ToList();
            var types = _context.Type.ToList();
            
            ViewBag.IdProvider = new SelectList(providers, "Id", "Name");
            ViewBag.IdType = new SelectList(types, "Id", "Name");
            return View(product);
        }
        [HttpPost]
        [Obsolete]
        public IActionResult Edit(Product product,double old_price ,IFormFile file)
        {
            string image = Helpers.ExtensionHelper.UploadFile(file, "img-products");
            if (image != "error")
            {
                product.Image = image;
            }

            var user = @User.Claims.FirstOrDefault(c => c.Type == "Ma").Value;

            if (product.Price != old_price)
            {
                var data = _context.Priceupdate.SingleOrDefault(p => p.IdProduct == product.Id);
                if(data != null)
                {
                    _context.Database.ExecuteSqlCommand("UPDATE [priceupdate] SET priceupdated=" + product.Price + "WHERE ID_product = " + product.Id);
                }
                else
                {
                    var updatedetail = new Priceupdate()
                    {
                        IdProduct = product.Id,
                        IdAdmin = Int32.Parse(user),
                        Price = (double)old_price,
                        Priceupdated = (double)((100 - product.Discount) * product.Price) / 100,
                        DateUpdate = default,
                        DateEnd = default,
                    };
                    _context.Priceupdate.Add(updatedetail);
                }
                
            }
            _context.Update(product); 
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var product = _context.Product.SingleOrDefault(c => c.Id == id);
            _context.Product.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
