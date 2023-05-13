using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Diagnostics;
using System.Numerics;

namespace PierresBakery.Controllers
{
    public class VendorsController : Controller

    {
        
        public static List<Vendor> vendors = new();
        public ActionResult Index()
        {

 
            vendors.Add(new Vendor(2, "Hello2", "This is the vendor that has nothing"));
            vendors.Add(new Vendor(3, "Hello3", "This is the vendor that has nothing"));

            Debug.WriteLine(vendors.Count);
            return View(vendors) ;
        }

        






    }
}
