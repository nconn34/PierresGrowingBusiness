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

//     [TestMethod]
//     public void GetAll_ReturnsEmptyList_ItemList()
//     {
//       List<Item> newList = new List<Item> { };
//       List<Item> result = Item.GetAll();
//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void GetAll_ReturnsItems_ItemList()
//     {
//       string description01 = "Walk the dog";
//       string description02 = "Wash the dishes";
//       Item newItem1 = new Item(description01);
//       Item newItem2 = new Item(description02);
//       List<Item> newList = new List<Item> { newItem1, newItem2 };
//       List<Item> result = Item.GetAll();
//       CollectionAssert.AreEqual(newList, result);
//     }
//      [TestMethod]
//   public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
//   {
//     //Arrange
//     string description = "Walk the dog.";
//     Item newItem = new Item(description);

//     //Act
//     int result = newItem.Id;
//     //Assert
//     Assert.AreEqual(1, result);
//   }
//    [TestMethod]
//   public void Find_ReturnsCorrectItem_Item()
//   {
//     //Arrange
//     string description01 = "Walk the dog";
//     string description02 = "Wash the dishes";
//     Item newItem1 = new Item(description01);
//     Item newItem2 = new Item(description02);

//     //Act
//     Item result = Item.Find(2);

//     //Assert
//     Assert.AreEqual(newItem2, result);
  }
  }
