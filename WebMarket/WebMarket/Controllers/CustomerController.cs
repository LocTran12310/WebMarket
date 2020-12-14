
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;
using WebMarket.Helpers;
using WebMarket.Models;


namespace WebMarket.Controllers
{
    public class CustomerController : Controller
    {

        private WebMarketContext _context;
        public CustomerController(WebMarketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            int data = HttpContext.Session.Get<int>("KhachHang");
            if (data == null ||data == 0)
            {
                return View("Login");
            }
            ViewBag.id = data;
            var customer = _context.Customer.Select(p => new CustomerVM
            {
                Id = p.Id,
                Name = p.Name,
                Address = p.Address,
                Phone = p.Phone,
                Date = p.DateOfBirth,
                Email = p.Email,
            });
            return View(customer);
        }
      
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AccountVM acc)
        {
            var AccCus = _context.Account.SingleOrDefault(a => a.Username == acc.UserName && a.Password == acc.PassWord);
            if (AccCus == null)
            {
                ViewBag.Error = "Account not exsit";
                return View();
            }
            var customer = _context.Customer.SingleOrDefault(c => c.Id == AccCus.IdCustomer);
            HttpContext.Session.Set("KhachHang", customer.Id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Logout()
        {
            HttpContext. Session.Remove("KhachHang");
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM res)
        {
            var idAcc = _context.Account.SingleOrDefault(a => a.Username == res.account.UserName);
            if (idAcc == null )
            {
                var cus = new Customer()
                {
                    Name = res.customer.Name,
                    Address = res.customer.Address,
                    Phone = res.customer.Phone,
                    DateOfBirth = res.customer.Date,
                    Email = res.account.UserName,
                    Status = 0,
                };
                _context.Customer.Add(cus);
                _context.SaveChanges();
                int lastRow = _context.Customer.OrderByDescending(c => c.Id).Select(c=>c.Id).First();
                int id = (lastRow!=null) ? lastRow : 1;
                var acc = new Account
                {
                    Username = res.account.UserName,
                    Password = res.account.PassWord,
                    Type = 0,
                    IdCustomer = id,
                };
                _context.Account.Add(acc);
                _context.SaveChanges();
                return View("Login");
            }
            else
            {
                ViewBag.error = "* Email đã tồn tại";
                return View();
            } 
        }
    }
}
