using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Comestic.Data;
using Comestic.Ulitity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Comestic.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    [Authorize(Roles = SD.ManagerUser)]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task <IActionResult>Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            
            return View(await _db.ApplicationUser.Where(u=>u.Id != claim.Value).ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Index(string User)
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ViewData["Getemployeedetails"] = User;
            var empquery = from x in _db.ApplicationUser.Where(u => u.Id != claim.Value) select x;
            if (!String.IsNullOrEmpty(User))
            {
                empquery = empquery.Where(x => x.Name.Contains(User));

            }
            // return View(await _db.SubCategory.ToListAsync());
            return View(await empquery.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> Lock(string id)
        {
            if(id==null)
            {
                return NotFound("ko tìm thấy");
            }
            var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);

            if (applicationUser == null)
            {
                return NotFound("ko tìm thấy");
            }
            applicationUser.LockoutEnd = DateTime.Now.AddYears(1000);

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UnLock(string id)
        {
            if (id == null)
            {
                return NotFound("ko tìm thấy");
            }
            var applicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);

            if (applicationUser == null)
            {
                return NotFound("ko tìm thấy");
            }
            applicationUser.LockoutEnd = DateTime.Now;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
