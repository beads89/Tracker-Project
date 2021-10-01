using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrdersTests : IDisposable
  {
    public void Dispose()
    {
      Orders.ClearAll();
    }
    [TestMethod]
    public void OrdersConstructor_CreatesNewOrder_Order()
    {
      Orders newOrder = new Orders("5 fab fennel cakes");
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrder_ReturnsDescriptionOfOrder_String()
    {
      string order = "many pies";

      Orders newOrder = new Orders(order);
      string results = newOrder.Contents;

      Assert.AreEqual(order, results);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string order1 = "many pies";
      string order2 = "many more pies";
      Orders newOrder1 = new Orders(order1);
      Orders newOrder2 = new Orders(order2);
      List<Orders> newOrders = new List<Orders> {newOrder1, newOrder2};

      List<Orders> result = Orders.GetAll();

      CollectionAssert.AreEqual(newOrders, result);
    }
  }
}