using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public AccountController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Roles()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(roles);
        }

        public IActionResult CreateRole()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                await roleManager.CreateAsync(role);
                return RedirectToAction("Roles");
            }
            else return View(role);
        }
    }
}
