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
  }
}