using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Comestic.Models;
using Comestic.Data;
using Microsoft.EntityFrameworkCore;
using Comestic.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Comestic.Ulitity;
using System.Text;

namespace Comestic.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task <IActionResult> Index()
        {
            IndexViewModel IndexVM = new IndexViewModel()
            {
                Product = await _db.Product.Include(m => m.Category).Include(m => m.SubCategory).ToListAsync(),
                Category = await _db.Category.ToListAsync(),
                Coupon = await _db.Coupon.Where(c => c.IsActive == true).ToListAsync()
            };

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                var cnt = _db.ShoppingCart.Where(u => u.ApplicationUserId == claim.Value).ToList().Count;
                HttpContext.Session.SetInt32("ssCartCount", cnt);
            }
            return View(IndexVM);
        }
       
        [Authorize]
        public async Task <IActionResult> Details(int id)
        {
            var productFrom = await _db.Product.Include(m => m.Category).Include(m => m.SubCategory).Where(m => m.Id == id).FirstOrDefaultAsync();
            ShoppingCart cartObj = new ShoppingCart()
            {
                Product = productFrom,
                ProductId = productFrom.Id
            };
            return View(cartObj);
        }
        public async Task<IActionResult> Search(string name = "", int productPage = 1)
        {
            //Check name is null replace a empty string.
            if (name == null)
            {
                name = "";
            }

            IndexViewModel IndexVM = new IndexViewModel()
            {
                Product = await _db.Product.Include(m => m.Category).Include(m => m.SubCategory).ToListAsync(),
                Category = await _db.Category.ToListAsync(),
                SubCategory = await _db.SubCategory.ToListAsync(),
                Coupon = await _db.Coupon.Where(c => c.IsActive == true).ToListAsync()
            };

            //Pagination: - Url determine current pages.
            StringBuilder param = new StringBuilder();
            param.Append("/Customer/Home/Search?=:");

            param.Append("&name=");
            if (name != null)
            {
                param.Append(name);
            }

            IndexVM.Product = IndexVM.Product.Where(m => m.Name.ToLower().Contains(name.ToLower()) || m.SubCategory.Name.ToLower().Contains(name.ToLower()));
            return View(IndexVM);
        }
        [Authorize]
        public async Task<IActionResult> Category(int id)
        {
            IndexViewModel IndexVM = new IndexViewModel()
            {
                Product = await _db.Product.Include(m => m.Category).Where(m => m.Id == id).ToListAsync(),
           
            };
            return View(IndexVM);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Details(ShoppingCart cartObject)
        {
            cartObject.Id = 0;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

                cartObject.ApplicationUserId = claim.Value;

                ShoppingCart cartFromDB = await _db.ShoppingCart.Where(c => c.ApplicationUserId == cartObject.ApplicationUserId

                    && c.ProductId == cartObject.ProductId).FirstOrDefaultAsync();
                if (cartFromDB == null)
                {
                    await _db.ShoppingCart.AddAsync(cartObject);
                }
                else
                {
                    cartFromDB.Count = cartFromDB.Count + cartObject.Count;
                }
                await _db.SaveChangesAsync();

                var count = _db.ShoppingCart.Where(c => c.ApplicationUserId == cartObject.ApplicationUserId).ToList().Count();

                HttpContext.Session.SetInt32(SD.ssShopingCartCount, count);

                return RedirectToAction("Index");
            }
            else
            {
                var productFrom = await _db.Product.Include(m => m.Category).Include(m => m.SubCategory).Where(m => m.Id == cartObject.ProductId).FirstOrDefaultAsync();
                ShoppingCart cartObj = new ShoppingCart()
                {
                    Product = productFrom,
                    ProductId = productFrom.Id
                };
                return View(cartObj);
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
