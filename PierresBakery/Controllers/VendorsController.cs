using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Diagnostics;
using System.Numerics;

namespace PierresBakery.Controllers
{
    public class VendorsController : Controller

    {

        private static List<Vendor> vendors = new()
    {
        new Vendor(1, "Vendor 1", "This is vendor 1"),
        new Vendor(2, "Vendor 2", "This is vendor 2"),
        new Vendor(3, "Vendor 3", "This is vendor 3")
    };
        public IActionResult Index(int? vendorId)
        {

            vendors[0].addOrder(new Order(1, "Order 1", "This is order 1", 12, new DateTime()));
            if (vendorId.HasValue)
            {
                var vendor = vendors.FirstOrDefault(v => v.VendorId == vendorId);
                if (vendor == null)
                {
                    return NotFound();
                }

                return View("Details", vendor);
            }

            return View(vendors);
        }



        [HttpGet("/vendors/{vendorId}/orders/new")]
        public IActionResult Create(int vendorId)
        {
            Vendor vendor = vendors.FirstOrDefault(v => v.VendorId == vendorId);
            if (vendor == null)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost("/vendors/{vendorId}/orders/new")]
        public IActionResult Create(int vendorId, string title, string description, decimal price, DateTime date)
        {
            Vendor vendor = vendors.FirstOrDefault(v => v.VendorId == vendorId);
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
