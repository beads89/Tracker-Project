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
      Vendors newVendor = new Vendors("Taylor's Swift Bakes");
      Assert.AreEqual(typeof(Vendors), newVendor.GetType());
    }

    [TestMethod]
    public  void Name_ReturnsNameOfVendor_String()
    {
      string vendorName = "Taylor's Swift Bakes";
      Vendors newVendor = new Vendors(vendorName);

      string result = newVendor.Name;

      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "Taylor's Swift Bakes";
      Vendors newVendor = new Vendors(vendorName);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
  }
}