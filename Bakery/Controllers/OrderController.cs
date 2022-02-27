using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/orders/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/orders")]
    public ActionResult Create(string description)
    {
      Order vendorOrder = new Order(description);
      return RedirectToAction("Index");
    }
    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }
    [HttpGet("/orders/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
    Vendor vendor = Vendor.Find(vendorId);
    Order order = Order.Find(orderId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("order", order);
    model.Add("vendor", vendor);
    return View(model);
    }
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
     Vendor vendor = Vendor.Find(vendorId);
     return View(vendor);
    }
  }
}

