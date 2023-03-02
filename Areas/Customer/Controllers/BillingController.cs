using EShop.Helper;
using EShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class BillingController : Controller
    {
        public IActionResult Checkout()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if (cart != null && cart.Count != 0)
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            }
            else
                return RedirectToAction("Index", "Home", new { area = "Customer" });
            return View();
        }
    }
}
