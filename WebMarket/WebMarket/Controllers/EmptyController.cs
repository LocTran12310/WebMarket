using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Controllers
{
    public class EmptyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
