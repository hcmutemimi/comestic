using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Comestic.Data;
using Comestic.Models;
using Comestic.Models.ViewModels;
using Comestic.Ulitity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Comestic.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.ManagerUser)]
   
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _hostingEnvironment;
        [BindProperty]
        public ProductViewModel ProductVM { get; set; }
        public ProductController(ApplicationDbContext db, IWebHostEnvironment hostEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostEnvironment;
            ProductVM = new ProductViewModel()
            {
                Category = _db.Category,
                Product = new Models.Product()
            };
           
        }
        public async Task <IActionResult> Index()
        {
            var product = await _db.Product.Include(m=>m.Category).Include(m=>m.SubCategory).ToListAsync();
            return View(product);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View(ProductVM);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            ProductVM.Product.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());

            if (!ModelState.IsValid)
            {
                return View(ProductVM);
            }

            _db.Product.Add(ProductVM.Product);
            await _db.SaveChangesAsync();

            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var ProductFromDb = await _db.Product.FindAsync(ProductVM.Product.Id);

            if (files.Count > 0)
            {
                //files has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension = Path.GetExtension(files[0].FileName);

                using (var filesStream = new FileStream(Path.Combine(uploads, ProductVM.Product.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                ProductFromDb.Image = @"\images\" + ProductVM.Product.Id + extension;
            }
            else
            {
                //no file was uploaded, so use default
                var uploads = Path.Combine(webRootPath, @"images\" + SD.DefaultImage);
                System.IO.File.Copy(uploads, webRootPath + @"\images\" + ProductVM.Product.Id + ".png");
                ProductFromDb.Image = @"\images\" + ProductVM.Product.Id + ".png";
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductVM.Product = await _db.Product.Include(m => m.Category).Include(m => m.SubCategory).SingleOrDefaultAsync(m => m.Id == id);
            ProductVM.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == ProductVM.Product.CategoryId).ToListAsync();

            if (ProductVM.Product == null)
            {
                return NotFound();
            }
            return View(ProductVM);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPOST(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductVM.Product.SubCategoryId = Convert.ToInt32(Request.Form["SubCategoryId"].ToString());

            if (!ModelState.IsValid)
            {
                ProductVM.SubCategory = await _db.SubCategory.Where(s => s.CategoryId == ProductVM.Product.CategoryId).ToListAsync();
                return View(ProductVM);
            }

            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var ProductFromDb = await _db.Product.FindAsync(ProductVM.Product.Id);

            if (files.Count > 0)
            {
                //New Image has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension_new = Path.GetExtension(files[0].FileName);

                //Delete the original file
                var imagePath = Path.Combine(webRootPath, ProductFromDb.Image.TrimStart('\\'));

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                //we will upload the new file
                using (var filesStream = new FileStream(Path.Combine(uploads, ProductVM.Product.Id + extension_new), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                ProductFromDb.Image = @"\images\" + ProductVM.Product.Id + extension_new;
            }

                ProductFromDb.Name = ProductVM.Product.Name;
                ProductFromDb.Description = ProductVM.Product.Description;
                ProductFromDb.NewPrice = ProductVM.Product.NewPrice;
                ProductFromDb.OldPrice = ProductVM.Product.OldPrice;
                ProductFromDb.Tag = ProductVM.Product.Tag;
                ProductFromDb.CategoryId = ProductVM.Product.CategoryId;
                ProductFromDb.SubCategoryId = ProductVM.Product.SubCategoryId;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _db.Product.SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _db.Product.SingleOrDefaultAsync(m => m.Id == id);
            _db.Product.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
