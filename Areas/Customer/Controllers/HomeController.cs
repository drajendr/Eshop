using EShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _db = applicationDbContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.Products.ToListAsync());
        }
    }
}
