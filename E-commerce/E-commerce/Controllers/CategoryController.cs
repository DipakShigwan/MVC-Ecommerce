using E_commerce.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
namespace E_commerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _context;
        public CategoryController(ApplicationDBContext context)
        {
           
            this._context = context;
        }
        // GET: CategoryController
        public ActionResult Index()
        {

            List<Category> categories = _context.Categories.ToList();
           
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _context.Categories.SingleOrDefault(c => c.CategoryId == id);
            return View(result);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            var result = _context.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            if (result == null)
                return NotFound();
            result.CategoryName = category.CategoryName;
            result.Description = category.Description;

            
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _context.Categories.SingleOrDefault(c => c.CategoryId == id);
            return View(result);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Category category)
        {
            var result = _context.Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            if (result == null)
                return NotFound();
            _context.Categories.Remove(result);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
