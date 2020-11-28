using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Controllers
{
    public class CategoryController : Controller
    {
       
        public IActionResult Index(string id)
        {
            ViewBag.id = id;
            return View();
        }
        
    }
}
