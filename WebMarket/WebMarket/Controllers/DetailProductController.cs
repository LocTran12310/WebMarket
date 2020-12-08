using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using WebMarket.Entities;
using WebMarket.Models;
using WebMarket.Secure;

namespace WebMarket.Controllers
{
    public class DetailProductController : Controller
    {
        private readonly WebMarketContext _context;
        private readonly IDataProtector protector;

        public DetailProductController(WebMarketContext context, IDataProtectionProvider dataProtectionProvider,
                              DataProtectionPurposeStrings dataProtectionPurposeStrings)
        {
            _context = context;
            this.protector = dataProtectionProvider.CreateProtector(
               dataProtectionPurposeStrings.ProductIdRouteValue);

        }
        [HttpGet("DetailProduct/{id}")]
        public IActionResult Index(string id)
        {
            string decryptedId = protector.Unprotect(id);
            int decryptedIntId = Convert.ToInt32(decryptedId);


            var product = (from p in _context.Product.Where(p => p.Id == decryptedIntId)
                          from image in _context.Image.Where(i => i.IdProduct == p.Id).Take(1)
                          select new ProductVM
                          {
                              Id = p.Id,
                              EncryptedId = protector.Protect(p.Id.ToString()),
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
