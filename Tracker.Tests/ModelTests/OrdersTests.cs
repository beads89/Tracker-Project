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
      Orders newOrder = new Orders("c", "d", "e", 5);
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrder_ReturnsDescriptionOfOrder_String()
    {
      string order = "many pies";
      string description = "pies of many";
      string date = "jan";
      int price = 15;

      Orders newOrder = new Orders(order, description, date, price);
      string results = newOrder.Contents;

      Assert.AreEqual(order, results);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string order1 = "many pies";
      string description1 = "pies of many";
      string date1 = "jan";
      int price1 = 15;
      string order2 = "many more pies";
      string description2 = "pies of many more";
      string date2 = "feb";
      int price2 = 20;
      Orders newOrder1 = new Orders(order1, description1, date1, price1);
      Orders newOrder2 = new Orders(order2, description2, date2, price2);
      List<Orders> newOrders = new List<Orders> {newOrder1, newOrder2};

      List<Orders> result = Orders.GetAll();

      CollectionAssert.AreEqual(newOrders, result);
    }
    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string order = "ten cakes";
      string description = "pies of many";
      string date = "jan";
      int price = 15;
      Orders newOrder = new Orders(order, description, date, price);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsSpecificOrders_Orders()
    {
      string order1 = "pancakes";
      string description1 = "pies of many";
      string date1 = "jan";
      int price1 = 15;
      string order2 = "waffles";
      string description2 = "pies of many more";
      string date2 = "feb";
      int price2 = 20;
      Orders newOrder1 = new Orders(order1, description1, date1, price1);
      Orders newOrder2 = new Orders(order2, description2, date2, price2);

      Orders result = Orders.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}