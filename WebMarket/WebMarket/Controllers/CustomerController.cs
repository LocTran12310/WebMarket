
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Entities;
using WebMarket.Models;
using System.Security.Claims;

namespace WebMarket.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {

        private WebMarketContext _context;
        public CustomerController(WebMarketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
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
        [AllowAnonymous, HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> Login(AccountVM acc)
        {
            var AccCus = _context.Account.SingleOrDefault(a => a.Username == acc.UserName && a.Password == acc.PassWord);
            if (AccCus == null)
            {
                ViewBag.Error = "Account not exsit";
                return View();
            }
            var customer = _context.Customer.SingleOrDefault(c => c.Id == AccCus.IdCustomer);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,customer.Name),
                new Claim(ClaimTypes.Email, customer.Email),
                new Claim("MaKH", customer.Id.ToString()),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Role, "QuanTriHeThong"),
                new Claim(ClaimTypes.Role, "BanHang")
            };
            var userIdentity = new ClaimsIdentity(claims, "login");
            // create principal
            var principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [AllowAnonymous, HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> Register(RegisterVM res)
        {
            int id=1;
            if (res.account.PassWord == res.account.PasswordConfirm)
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
                var lastRow = _context.Customer.OrderByDescending(c => c.Id).Take(1).SingleOrDefault();
                id = lastRow.Id;
            }

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
    }
}
