using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System;
using System.Linq;

namespace PierresBakery.Controllers
{
    public class OrdersController : Controller
    {
        private static List<Order> orders = new List<Order>();

        [HttpGet("/Orders/Create")]
        public IActionResult Create(int vendorId)
        {
            Vendor vendor = VendorsController.GetVendors().FirstOrDefault(v => v.VendorId == vendorId);
            if (vendor == null)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost("/Orders/Create")]
        public IActionResult Create(int vendorId, string title, string description, decimal price, DateTime date)
        {
            Vendor vendor = VendorsController.GetVendors().FirstOrDefault(v => v.VendorId == vendorId);
            if (vendor == null)
            {
                return NotFound();
            }

            Order newOrder = new Order(title, description, price, date);
            vendor.Orders.Add(newOrder);

            return RedirectToAction("Index", "Vendors", new { vendorId = vendor.VendorId });
        }
        
    }
}
