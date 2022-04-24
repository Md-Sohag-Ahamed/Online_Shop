using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Shop.Data;
using Online_Shop.Models;
using Online_Shop.Utility;
//using Online_Shop.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Online_Shop.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
      private ApplicationDbContext _db;
     private readonly ILogger<HomeController> _logger;
        


        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db)
        {
            _logger = logger;
             _db = db;
        }

        public IActionResult Index(int?page)
        {
            return View(_db.Products.Include(c=>c.ProductTypes).Include(c=>c.SpecialTags).ToList().ToPagedList(page??1,9));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    //Get product detail action method
      [HttpGet]
       public IActionResult Details(int? id)
             {
            if (id == null)
             {
         return NotFound();
        }
      var product = _db.Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
      if (product == null)
      {
        return NotFound();
      }
      return View(product);
      }
    //Get product detail action method
    [HttpPost]
    [ActionName("Details")]
    public IActionResult ProductDetails(int? id)
    {
      List<Products> products = new List<Products>();
      if (id == null)
      {
        return NotFound();
      }
      var product = _db.Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
      if (product == null)
      {
        return NotFound();
      }
      products = HttpContext.Session.Get<List<Products>>("products");
      if (products == null)
      {
        products = new List<Products>();
      }
      products.Add(product);
      HttpContext.Session.Set("products", products);
      return View(product);
    }
    //GET Remove Action method
    [ActionName("Remove")]
    public IActionResult RemoveToCart(int? id)
    {
      List<Products> products = HttpContext.Session.Get<List<Products>>("products");
      if (products != null)
      {
        var product = products.FirstOrDefault(c => c.Id == id);
        if (product != null)
        {
          products.Remove(product);
          HttpContext.Session.Set("products", products);
        }
      }

      return RedirectToAction(nameof(Index));
    }




    [HttpPost]

    public IActionResult Remove(int? id)
    {
      List<Products>products =HttpContext.Session.Get<List<Products>>("products");
      if (products != null)
      {
        var product = products.FirstOrDefault(c => c.Id == id);
        if (product != null)
        {
          products.Remove(product);
          HttpContext.Session.Set("products", products);
        }
      }

      return RedirectToAction(nameof(Index));
    }
    //GET product Cart Action method
    public IActionResult Cart()
    {
      List<Products> products = HttpContext.Session.Get<List<Products>>("products");
      if (products==null)
      {
        products = new List<Products>();

      }
      return View(products);
    }
  }
}
