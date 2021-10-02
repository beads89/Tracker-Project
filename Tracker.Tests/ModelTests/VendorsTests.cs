using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorsTests : IDisposable
  {
    public void Dispose()
    {
      Vendors.ClearAll();
    }

    [TestMethod]

    public void VendorConstructor_CreatesNewVendor_Vendors()
    {
      Vendors newVendor = new Vendors("Taylor's Swift Bakes", "Swifties");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }

    [TestMethod]
    public  void Name_ReturnsNameOfVendor_String()
    {
      string vendorName = "Taylor's Swift Bakes";
      string vendorDescription = "Swifties";
      Vendors newVendor = new Vendors(vendorName, vendorDescription);

      string result = newVendor.Name;

      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "Taylor's Swift Bakes";
      string vendorDescription = "Swifties";
      Vendors newVendor = new Vendors(vendorName, vendorDescription);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorNames_VendorsList()
    {
      string vendor1 = "Taylor's Swift Bakes";
      string vendorDescription1 = "Swifties";
      string vendor2 = "Vitas' Vital Varenyky";
      string vendorDescription2 = "The 7th Element";
      Vendors newVendor1 = new Vendors(vendor1, vendorDescription1);
      Vendors newVendor2 = new Vendors(vendor2, vendorDescription2);
      List<Vendors> newList = new List<Vendors> {newVendor1, newVendor2};

      List<Vendors> result = Vendors.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsSpecifiedVendorName_Vendor()
    {
      string vendor1 = "Taylor's Swift Bakes";
      string vendorDescription1 = "Swifties";
      string vendor2 = "Vitas' Vital Varenyky";
      string vendorDescription2 = "The 7th Element";
      Vendors newVendor1 = new Vendors(vendor1, vendorDescription1);
      Vendors newVendor2 = new Vendors(vendor2, vendorDescription2);

      Vendors result = Vendors.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_PlaceOrderWithCorrectVendor_OrderList()
    {
      string order = "5 fab funnel cakes";
      Orders newOrder = new Orders(order);
      List<Orders> newList = new List<Orders> {newOrder};
      string vendor = "Cakemart's Tarts";
      string vendorDescription = "Swifties";
      Vendors newVendor = new Vendors(vendor, vendorDescription);
      newVendor.AddOrder(newOrder);

      List<Orders> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}