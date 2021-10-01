using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Tracker.Models;

namespace Tracker.Controllers
{
    public class VendorsController : Controller
    {
      // Initial vendor page that shows the list of all vendors
      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        List<Vendors> allVendors = Vendors.GetAll();
        return View(allVendors);
      }
      // Goes to vendor form to add a new vendor
      [HttpGet("/vendors/new")]
      public ActionResult New()
      {
        return View();
      }
      // Creates a new vendor
      [HttpPost("/vendors")]
      public ActionResult Create(string vendorName)
      {
        Vendors newVendor = new Vendors(vendorName);
        return RedirectToAction("Index");
      }
      // Displays a vendor based on id
      [HttpGet("/vendors/{id}")]
      public ActionResult Show(int id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendors selectedVendor = Vendors.Find(id);
        List<Orders> vendorOrders = selectedVendor.Orders;
        model.Add("vendors", selectedVendor);
        model.Add("orders", vendorOrders);
        return View(model);
      }
      [HttpPost("/vendors/{vendorId}/orders")]
      public ActionResult Create(int vendorId, string orderContents)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendors foundVendor = Vendors.Find(vendorId);
        Orders newOrder = new Orders(orderContents);
        foundVendor.AddOrder(newOrder);
        List<Orders> vendorOrders = foundVendor.Orders;
        model.Add("orders", vendorOrders);
        model.Add("vendors", foundVendor);
        return View("Show", model);
      }
    }
}