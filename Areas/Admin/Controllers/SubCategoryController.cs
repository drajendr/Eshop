using EShop.Data;
using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SubCategoryController(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }

        // GET: SubCategoryController
        public async Task<ActionResult> Index()
        {
            return View(await _db.SubCategories.Include(c => c.Category).ToListAsync());
        }

        // GET: SubCategoryController/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            SubCategory subCategory = await _db.SubCategories.Include(c => c.Category).FirstOrDefaultAsync(row => row.Id == id);
            if (id == null)
                return NotFound();

            return View(subCategory);
        }

        // GET: SubCategoryController/Create
        public async Task<ActionResult> Create()
        {
            ViewData["CategoryId"] = new SelectList(await _db.Categories.ToListAsync(), "CategoryId", "CategoryName");
            return View();
        }

        // POST: SubCategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SubCategory subCategoryData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SubCategory subCategory = new SubCategory();
                    subCategory.Name = subCategoryData.Name;
                    subCategory.CategoryId = subCategoryData.CategoryId;
                    _db.SubCategories.Add(subCategory);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
            return View();
        }

        // GET: SubCategoryController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            ViewData["CategoryId"] = new SelectList(await _db.Categories.ToListAsync(), "CategoryId", "CategoryName");
            var subCategory = await _db.SubCategories.FindAsync(id);
            if (subCategory == null)
            {
                return NotFound();
            }
            return View(subCategory);            
        }

        // POST: SubCategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, SubCategory subCategoryData)
        {
            try
            {
                SubCategory subCategory = await _db.SubCategories.FindAsync(id);
                if (subCategory == null)
                    return NotFound();
                if (ModelState.IsValid)
                {
                    subCategory.Name = subCategoryData.Name;
                    subCategory.CategoryId = subCategoryData.CategoryId;
                    _db.SubCategories.Update(subCategory);
                    await _db.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
            }
        }

        // GET: SubCategoryController/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            SubCategory subCategory = await _db.SubCategories.Include(c => c.Category).FirstOrDefaultAsync(row => row.Id == id);
            if (subCategory == null) return NotFound();
            return View(subCategory);
        }

        // POST: SubCategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id, SubCategory subCategoryData)
        {
            try
            {
                if (id == null) return NotFound();
                SubCategory subCategory = await _db.SubCategories.FindAsync(id);
                _db.SubCategories.Remove(subCategory);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
            }
        }
    }
}
