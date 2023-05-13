using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
    public class VendorController : Controller
    {

        public IActionResult ID()
        {

            Vendor vendor = new Vendor("Hello", "This is the vendor that has nothing");
            return View(vendor);
        }
    }
}
