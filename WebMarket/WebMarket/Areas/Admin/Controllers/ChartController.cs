using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMarket.Areas.Admin.Models;
using WebMarket.Entities;
using WebMarket.Models;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        
        private WebMarketContext _context;
        public ChartController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public List<TypeChart> TypeChart()
        {
            List<TypeChart> lst = new List<TypeChart>();
            lst = (from t in _context.Type
                        join od in _context.Product on t.Id equals od.IdType
                        where t.IdCategory == 1
                        group od by t.Name into chart
                        select new TypeChart()
                        {
                            Name = chart.Key,
                            count = chart.Count()
                        }).ToList();
            return lst;
        }
        public List<ProductSellChart> SellChart()
        {
            var lst = (from t in _context.Product
                       join od in _context.Orderdetail on t.Id equals od.IdProduct 
                       group od by t.Name into chart
                       select new ProductSellChart()
                       {
                           Name = chart.Key,
                           sold = chart.Sum(x=>x.Quantity)
                       }).ToList();
            return lst;
        }
    }
}
