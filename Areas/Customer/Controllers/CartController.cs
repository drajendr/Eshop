using EShop.Data;
using EShop.Helper;
using EShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<CartController> _logger;
        public CartController(ApplicationDbContext applicationDbContext, ILogger<CartController> logger)
        {
            _db = applicationDbContext;
            _logger = logger;
        }

        [Route("index")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            }
            return View();
        }

        [Route("buy/{id}")]
        public async Task<IActionResult> Buy(int id)
        {
            _logger.LogInformation("Adding product from cart. Product id - " + id);
            try
            {
                if (SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart") == null)
                {
                    List<CartItem> cart = new List<CartItem>();
                    cart.Add(new CartItem { Product = await _db.Products.FindAsync(id), Quantity = 1 });
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
                else
                {
                    List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                    int index = isExist(id);
                    if (index != -1)
                    {
                        cart[index].Quantity++;
                    }
                    else
                    {
                        cart.Add(new CartItem { Product = _db.Products.Find(id), Quantity = 1 });
                    }
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError("Category creation error - " + ex.Message);
                throw;
            }
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            _logger.LogInformation("Removing product from cart. Product id - " + id);
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        private int isExist(int id)
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        //[Route("checkout")]
        //public IActionResult Checkout()
        //{

        //}

    }
}
