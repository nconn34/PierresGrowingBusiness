using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }
    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }
    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }
    [HttpGet("/orders/{orderId}/items/{itemId}")]
    public ActionResult Show(int orderId, int itemId)
    {
    Item item = Item.Find(itemId);
    Order order = Order.Find(orderId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("item", item);
    model.Add("order", order);
    return View(model);
    }
    [HttpGet("/order/{orderId}/items/new")]
    public ActionResult New(int orderId)
    {
     Order order = Order.Find(orderId);
     return View(order);
    }
  }
}