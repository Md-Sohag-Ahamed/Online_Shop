using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Shop.Data;
using Online_Shop.Models;
using Online_Shop.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop.Areas.Customer.Controllers
{
  [Area("Customer")]
  public class OrderController : Controller
  {
    private ApplicationDbContext _db;
    public OrderController(ApplicationDbContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      return View();
    }
    //GET Checkout action method
    public IActionResult Checkout()
    {
      return View();
    }
    //POST Checkout action method
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Checkout(Order anorder)
    {
      List<Products> products = HttpContext.Session.Get<List<Products>>("products");
      if (products != null)
      {
        foreach(var product in products)
        {
          OrderDetails orderDetails = new OrderDetails();
          orderDetails.ProductId = product.Id;
          anorder.OrderDetails.Add(orderDetails);

        }
      }
      anorder.OrderNo = GetOrderNo();
      _db.Orders.Add(anorder);
      await _db.SaveChangesAsync();
      HttpContext.Session.Set("products",new List<Products>());
      return View();
    }
    public string GetOrderNo()
    {
      int rowCount = _db.Orders.ToList().Count() + 1;
      return rowCount.ToString("000");
    }

  }
}
