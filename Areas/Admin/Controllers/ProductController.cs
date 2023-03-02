using EShop.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace EShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _env;
        public ProductController(ApplicationDbContext applicationDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _db = applicationDbContext;
            _env = webHostEnvironment;
        }
        // GET: ProductController
        public async Task<ActionResult> Index()
        {
            return View(await _db.Products.Include(c => c.Category).Include(s => s.SubCategory).ToListAsync());
        }

        // GET: ProductController/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            Product product = await _db.Products.FindAsync(id);
            if (id == null)
                return NotFound();

            return View(product);
        }

        // GET: ProductController/Create
        public async Task<ActionResult> Create()
        {
            List<Category> categories = new List<Category>();
            categories = await _db.Categories.ToListAsync();
            //categories.Insert(0, new Category { CategoryId = 0, CategoryName = "select" });
            ViewData["ProductCategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");           
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetSubCategory(int id)
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            subCategories = await _db.SubCategories.Where(r => r.CategoryId == id).ToListAsync();
            //subCategories.Insert(0, new SubCategory { Id = 0, Name = "select" });
            return Json(new SelectList(subCategories, "Id", "Name"));
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product productData, IFormFile productImage)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string imagePath = string.Empty;
                    if (productImage != null)
                    {
                        var name = Path.Combine(_env.WebRootPath + @"\ProductImage", Path.GetFileName(productImage.FileName));
                        await productImage.CopyToAsync(new FileStream(name,FileMode.Create));
                        imagePath = @"ProductImage\" + productImage.FileName;
                    }
                    else { imagePath = @"ProductImage\NotFound.png"; }

                    Product product = new Product();
                    product.ProductName = productData.ProductName;
                    product.Price = productData.Price;
                    product.Description = productData.Description;
                    product.ProductImage = imagePath;
                    product.ProductCategoryId = productData.ProductCategoryId;
                    product.ProductSubCategoryId = productData.ProductSubCategoryId;
                    _db.Products.Add(product);
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

        // GET: ProductController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var product = await _db.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            var categories = await _db.Categories.ToListAsync();
            ViewData["ProductCategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");
            var subCategories = await _db.SubCategories.Where(r => r.CategoryId == product.ProductCategoryId).ToListAsync();
            ViewData["ProductSubCategoryId"] = new SelectList(subCategories, "Id", "Name");
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Product productData, IFormFile productImage)
        {
            try
            {
                Product product = await _db.Products.FindAsync(id);
                if (product == null)
                    return NotFound();
                if (ModelState.IsValid)
                {
                    string imagePath = string.Empty;
                    if (productImage != null)
                    {
                        var name = Path.Combine(_env.WebRootPath + @"\ProductImage", Path.GetFileName(productImage.FileName));
                        await productImage.CopyToAsync(new FileStream(name, FileMode.Create));
                        imagePath = @"ProductImage\" + productImage.FileName;
                    }
                    else { imagePath = productData.ProductImage; }
                    product.ProductName = productData.ProductName;
                    product.Description = productData.Description;
                    product.Price = productData.Price;
                    product.ProductCategoryId = productData.ProductCategoryId;
                    product.ProductSubCategoryId = productData.ProductSubCategoryId;
                    product.ProductImage = imagePath;
                    _db.Products.Update(product);
                    await _db.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
            }
        }

        // GET: ProductController/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Product product = await _db.Products.Include(c => c.Category).Include(s => s.SubCategory).FirstOrDefaultAsync(row => row.ProductId == id);
            if (product == null) return NotFound();
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id, Product productData)
        {
            try
            {
                if (id == null) return NotFound();
                Product product = await _db.Products.FindAsync(id);
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                
                if (System.IO.File.Exists(Path.Combine(_env.WebRootPath + @"\", productData.ProductImage)))
                {
                    // If file found, delete it    
                    System.IO.File.Delete(Path.Combine(_env.WebRootPath + @"\", productData.ProductImage));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                throw;
            }
        }
    }
}
