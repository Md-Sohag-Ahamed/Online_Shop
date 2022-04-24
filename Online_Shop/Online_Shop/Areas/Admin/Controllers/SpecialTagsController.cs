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
    public class SpecialTagsController : Controller
    { 
        private ApplicationDbContext _db;

        public SpecialTagsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.SpecialTags.ToList());
        }
        //Create Get action Method
        public ActionResult Create()
        {
            return View();
        }
        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTags specialTags)
        {
            if (ModelState.IsValid)
            {
                _db.SpecialTags.Add(specialTags);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialTags);
        }
        //Edit Get action Method
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialtag = _db.SpecialTags.Find(id);
            if (specialtag == null)
            {
                return NotFound();
            }
            return View(specialtag);
        }
        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SpecialTags specialTags)
        {
            if (ModelState.IsValid)
            {
                _db.Update(specialTags);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialTags);
        }
        //Details Get action Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialtag = _db.SpecialTags.Find(id);
            if (specialtag == null)
            {
                return NotFound();
            }
            return View(specialtag);
        }
        //Details Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(SpecialTags specialTags)
        {

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialtag = _db.SpecialTags.Find(id);
            if (specialtag == null)
            {
                return NotFound();
            }
            return View(specialtag);
        }
        //Delete Post Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, SpecialTags specialTags)
        {
            if (id == null)
            {
                return NotFound();

            }
            if (id != specialTags.Id)
            {
                return NotFound();
            }
            var specialtag = _db.SpecialTags.Find(id);
            if (specialtag == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(specialtag);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialTags);
        }
    }
}
