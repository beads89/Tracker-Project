using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Tracker.Models;

namespace Tracker.Controllers
{
    public class VendorsController : Controller
    {
      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        List<Vendors> allVendors = Vendors.GetAll();
        return View(allVendors);
      }
      [HttpGet("/vendors/new")]
      public ActionResult New()
      {
        return View();
      }
      [HttpPost("/vendors")]
      public ActionResult Create(string vendorName, string vendorDescription)
      {
        Vendors newVendor = new Vendors(vendorName, vendorDescription);
        return RedirectToAction("Index");
      }
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
      public ActionResult Create(int vendorId, string orderContents, string orderDescription, string orderDate, int orderPrice)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendors foundVendor = Vendors.Find(vendorId);
        Orders newOrder = new Orders(orderContents, orderDescription, orderDate, orderPrice);
        foundVendor.AddOrder(newOrder);
        List<Orders> vendorOrders = foundVendor.Orders;
        model.Add("orders", vendorOrders);
        model.Add("vendors", foundVendor);
        return View("Show", model);
      }
    }
}