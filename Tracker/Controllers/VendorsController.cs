using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Tracker.Models;

namespace Tracker.Controllers
{
    public class VendorsController : Controller
    {
      // Initial vendor page that shows the list of vendors
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
      // Takes the new info from vendors/new and posts it to /vendor
      [HttpPost("/vendors")]
      public ActionResult Create(string vendorName)
      {
        Vendors newVendor = new Vendors(vendorName);
        return RedirectToAction("Index");
      }
      // Gets an id based on the vendor list
      // [HttpGet("/vendors/{id}")]
      // public ActionResult Show(int id)
      // {

      // }
    }
}