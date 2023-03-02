using EShop.Areas.Customer.Controllers;
using EShop.Data;
using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace EShop.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<CategoryController> _logger;
        public CategoryController(ApplicationDbContext applicationDbContext, ILogger<CategoryController> logger)
        {
            _db = applicationDbContext;
            _logger = logger;
        }
        // GET: CategoryController
        public async Task<ActionResult> Index()
        {
            return View(await _db.Categories.ToListAsync());
        }

        // GET: CategoryController/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            Category product = await _db.Categories.FindAsync(id);
            if (id == null)
                return NotFound();

            return View(product);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Category categoryData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Category category = new Category();
                    category.CategoryName = categoryData.CategoryName;
                    category.Description = categoryData.Description;
                    _db.Categories.Add(category);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    _logger.LogError("Category creation error - " + ex.Message);
                    throw;
                }
            }
            return View();
        }

        // GET: CategoryController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var category = await _db.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Category categoryData)
        {
            try
            {
                Category category = await _db.Categories.FindAsync(id);
                if (category == null)
                    return NotFound();
                if (ModelState.IsValid)
                {
                    category.CategoryName = categoryData.CategoryName;
                    category.Description = categoryData.Description;
                    _db.Categories.Update(category);
                    await _db.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                _logger.LogError("Category creation error - " + ex.Message);
                throw;
            }
        }

        // GET: CategoryController/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Category category = await _db.Categories.FirstOrDefaultAsync(row => row.CategoryId == id);
            if (category == null) return NotFound();
            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id, Category categoryData)
        {
            try
            {
                if (id == null) return NotFound();
                Category category = await _db.Categories.FindAsync(id);
                _db.Categories.Remove(category);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError("Category creation error - " + ex.Message);
                throw;
            }
        }
    }
}
