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







    }
}
