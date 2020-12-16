using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMarket.Entities;
using WebMarket.Helpers;

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
        public IActionResult Index()
        {
            var products = _context.Product.Include(p => p.IdTypeNavigation).Include(p => p.IdProviderNavigation);   
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var providers = _context.Provider.ToList();
            var types = _context.Type.ToList();
            ViewBag.IdProvider = new SelectList(providers, "Id", "Name");
            ViewBag.IdType = new SelectList(types, "Id", "Name");
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
        public async Task<IActionResult> Edit(Product product, IFormFile file)
        {
            string image = Helpers.ExtensionHelper.UploadFile(file, "img-products");
            if (image != "error")
            {
                product.Image = image;
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
