using Microsoft.AspNetCore.Hosting;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Microsoft.EntityFrameworkCore;
using Online_Shop.Data;
using Online_Shop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Admin.Controllers
{
  [Area("Admin")]
  public class ProductController : Controller
  {
    private ApplicationDbContext _db;
    private IHostingEnvironment _he;

    public ProductController(ApplicationDbContext db,IHostingEnvironment he)
    {
      _db = db;
      _he = he;
  
    }
    public IActionResult Index()
    {
      return View(_db.Products.Include(c=>c.ProductTypes).Include(f=>f.SpecialTags).ToList());
    }

    //POST Index action method
    [HttpPost]
    public IActionResult Index(decimal? lowAmount,decimal? largeAmount)
    {
      var products = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTags).Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
      if(lowAmount==null || largeAmount == null)
      {
         products = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTags).ToList();

      }
      return View(products);
    }
    //Get Create method
    public IActionResult Create()
    {
      ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
      ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTag");
      return View();
    }
    //Post Create method
    [HttpPost]
    public async Task<IActionResult>Create(Products products)
    {
      if (ModelState.IsValid)
      {
        var searchProduct = _db.Products.FirstOrDefault(c => c.Name == products.Name);
        if (searchProduct != null)
        {
          ViewBag.message = "This Product is already exist";
          ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
          ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTag");
          return View(products);
        }

        if (products.ImgFile != null)
        {

          string ext = Path.GetExtension(products.ImgFile.FileName).ToLower();
          if (ext == ".jpg" || ext == ".png" || ext == ".jpeg")
          {
            string fileName = Path.Combine(_he.WebRootPath, "Images", products.ImgFile.FileName);
            using(var filestream=new FileStream(fileName, FileMode.Create))
            {
            await  products.ImgFile.CopyToAsync(filestream);
              products.Image = "\\Images\\" + products.ImgFile.FileName;
            }
          }
        }
        if (products.ImgFile == null)
        {
          products.Image = "\\Images\\NoImage.png";
        }
        _db.Add(products);
        await _db.SaveChangesAsync();
        TempData["save"] = "Product Type has been saved";
        return RedirectToAction(nameof(Index));
      }
      return View(products);
    }
    //Get Edit Action Method
    public IActionResult Edit(int?id)
    {
      ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
      ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTag");
      if (id == null)
      {
        return NotFound();
      }
      var product = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTags).FirstOrDefault(c => c.Id == id);
      if (product == null)
      {
        return NotFound();
      }

      return View(product);
    }
    //Post Edit Action Method
    [HttpPost]
    public async Task<IActionResult> Edit(Products products)
    {
      if (ModelState.IsValid)
      {
        //var searchProduct = _db.Products.FirstOrDefault(c => c.Name == products.Name);
        //if (searchProduct != null)
        //{
        //  ViewBag.message = "This Product is already exist";
        //  ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
        //  ViewData["TagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "SpecialTag");
        //  return View(products);
        //}

        if (products.ImgFile != null)
        {

          string ext = Path.GetExtension(products.ImgFile.FileName).ToLower();
          if (ext == ".jpg" || ext == ".png" || ext == ".jpeg")
          {
            string fileName = Path.Combine(_he.WebRootPath, "Images", products.ImgFile.FileName);
            using (var filestream = new FileStream(fileName, FileMode.Create))
            {
              await products.ImgFile.CopyToAsync(filestream);
              products.Image = "\\Images\\" + products.ImgFile.FileName;
            }
          }
        }
        if (products.ImgFile == null)
        {
          products.Image = "\\Images\\NoImage.png";
        }
        _db.Update(products);
        await _db.SaveChangesAsync();
        TempData["update"] = "Product Type has been Updated";
        return RedirectToAction(nameof(Index));
      }
      return View(products);
    }
    //Get Details Action Method
    public IActionResult Details(int?id)
    {
      if (id == null)
      {
        return NotFound();
      }
      var product = _db.Products.Include(c => c.ProductTypes).Include(c => c.SpecialTags).FirstOrDefault(c => c.Id == id);
      if (product == null)
      {
        return NotFound();
      }
      return View(product);

    }
    //Get Delete Action Method

    public IActionResult Delete(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }
      var product = _db.Products.Include(c=>c.ProductTypes).Include(c=>c.SpecialTags).Where(c => c.Id == id).FirstOrDefault();
      if (product == null)
      {
        return NotFound();
      }
      return View(product);
    }
    //POST delete Action Method
    [HttpPost]
    [ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirm(int?id)
    {
      if (id == null)
      {
        return NotFound();
      }
      var product = _db.Products.FirstOrDefault(c => c.Id == id);
      if (product == null)
      {
        return NotFound();
      }
      _db.Products.Remove(product);
      await _db.SaveChangesAsync();
      TempData["deletedata"] = "Product has been Deleted";
      return RedirectToAction(nameof(Index));

    }

    
   

  }
}
