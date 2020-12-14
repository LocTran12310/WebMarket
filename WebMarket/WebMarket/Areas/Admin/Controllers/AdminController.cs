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

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminController : Controller
    {
        private readonly WebMarketContext _context;

        public AdminController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous, HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous, HttpPost]
        public async Task<IActionResult> Login(AccountVM acc)
        {
            
            var AccCus = _context.Admin.SingleOrDefault(a => a.Username == acc.UserName && a.Password == acc.PassWord);
            if (AccCus == null) {
                return RedirectToAction("Index");
            }
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,AccCus.Name),
                    new Claim(ClaimTypes.Email, AccCus.Username),
                    new Claim("IdAdmin", AccCus.Id.ToString()),
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim(ClaimTypes.Role, "BanHang")
                };
            var userIdentity = new ClaimsIdentity(claims, "login");
            // create principal
            var principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);
            //******Admin Login******
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
                int lastRow = _context.Customer.OrderByDescending(c => c.Id).Select(c => c.Id).First();
                int id = (lastRow != null) ? lastRow : 1;
                var acc = new Account
                {
                    Username = res.account.UserName,
                    Password = res.account.PassWord,
                    Type = 0,
                    IdCustomer = id,
                };
                _context.Account.Add(acc);
                _context.SaveChanges();
            }
            return View("Login");
        }
    }
}
