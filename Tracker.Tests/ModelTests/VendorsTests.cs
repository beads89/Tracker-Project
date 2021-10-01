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
  }
}