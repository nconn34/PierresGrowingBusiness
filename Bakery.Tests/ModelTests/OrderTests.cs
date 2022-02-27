using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Item()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "One Dozen Bagels.";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "One Dozen Bagels.";
      Order newOrder = new Order(description);
      string updatedDescription = "Do the dishes";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description01 = "One dozen bagels";
      string description02 = "Two dozen scones";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
     [TestMethod]
  public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
  {
    //Arrange
    string description = "One dozen bagels.";
    Order newOrder = new Order(description);

    //Act
    int result = newOrder.Id;
    //Assert
    Assert.AreEqual(1, result);
  }
   [TestMethod]
  public void Find_ReturnsCorrectOrder_Order()
  {
    //Arrange
    string description01 = "One dozen bagels";
    string description02 = "Two dozen scones";
    Order newOrder1 = new Order(description01);
    Order newOrder2 = new Order(description02);

    //Act
    Order result = Order.Find(2);

    //Assert
    Assert.AreEqual(newOrder2, result);
  }
  }
}
