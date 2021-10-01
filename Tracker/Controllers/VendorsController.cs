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
    }
}