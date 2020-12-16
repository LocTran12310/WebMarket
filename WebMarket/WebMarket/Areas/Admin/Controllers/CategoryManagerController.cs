﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMarket.Entities;
using WebMarket.Helpers;

namespace WebMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryManagerController : Controller
    {
        private WebMarketContext _context;
        public CategoryManagerController(WebMarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Category.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category, IFormFile file)
        {
            string image = Helpers.ExtensionHelper.UploadFile(file);
            if(image == "error")
            {

                return Content("the image is null");
            }
            var newcate = new Category()
            {
                Name = category.Name,
                Image = image
            };
            _context.Category.Add(newcate);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _context.Category.SingleOrDefault(c => c.Id == id);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category,IFormFile file)
        {
            string image = Helpers.ExtensionHelper.UploadFile(file);
            if (image != "error")
            {
                category.Image = image;
            }
            _context.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var category = _context.Category.SingleOrDefault(c => c.Id == id);
            _context.Category.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
