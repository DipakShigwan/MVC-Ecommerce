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

            //if (result == null)
            //    return HttpNotFound();

            //var viewModel = new CustomerFormViewModel
            //{
            //    Customer = customer,
            //    MembershipTypes = _context.MembershipTypes.ToList()
            //};

            return View(result);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
