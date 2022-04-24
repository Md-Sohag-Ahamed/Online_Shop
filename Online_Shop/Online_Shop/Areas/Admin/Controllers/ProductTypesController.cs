using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductTypesController : Controller
    {
        private ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
    [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }
    //Create Get action Method
    
    public ActionResult Create()
        {
            return View();
        }
        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.ProductTypes.Add(productTypes);
                await _db.SaveChangesAsync();
        TempData["save"] = "Product Type has been saved";
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
   
    //Edit Get action Method
    public ActionResult Edit(int?id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                await _db.SaveChangesAsync();
        TempData["update"] = "Product Type has been Updated";
        return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
        //Details Get action Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Details Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes productTypes)
        { 
               
                return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Delete Post Action Method
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int?id,ProductTypes productTypes)
        {
            if (id == null)
            {
                return NotFound();

            }
            if (id!= productTypes.Id)
            {
                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
        TempData["deletedata"] = "Product Type has been Deleted";
        return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
    }
}
