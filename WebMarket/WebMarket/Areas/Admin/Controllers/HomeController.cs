﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMarket.Entities;
using WebMarket.Models;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {

        private WebMarketContext _context;
        public HomeController(WebMarketContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous, HttpGet("Admin/Login")]
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
    }
}
