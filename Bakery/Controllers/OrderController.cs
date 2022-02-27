using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

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
    public ActionResult Create(string ordersName)
    {
    Order newOrder = new Order(ordersName);
    return RedirectToAction("Index");
    }
     [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Order selectedOrder = Order.Find(id);
    List<Item> orderItems = selectedOrder.Items;
    model.Add("order", selectedOrder);
    model.Add("items", orderItems);
    return View(model);
    }
    [HttpPost("/order/{orderId}/items")]
    public ActionResult Create(int orderId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Order foundOrder = Order.Find(orderId);
      Item newItem = new Item(itemDescription);
      foundOrder.AddItem(newItem);
      List<Item> orderItems = foundOrder.Items;
      model.Add("items", orderItems);
      model.Add("order", foundOrder);
      return View("Show", model);
    }
  }
}