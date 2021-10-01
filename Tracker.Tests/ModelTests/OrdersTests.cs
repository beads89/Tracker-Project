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
  }
}