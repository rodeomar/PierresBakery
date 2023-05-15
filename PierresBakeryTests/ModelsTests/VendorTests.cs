using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierresBakery.Models.Tests
{
    [TestClass()]
    public class VendorTests
    {

        [TestMethod]
        public void TestAddOrder()
        {
            
            Vendor vendor = new Vendor(1, "Test Vendor", "Test Description");
            Order order = new Order("Test Order", "Test Description", 10.50m, DateTime.Now);

            vendor.addOrder(order);

            Assert.AreEqual(vendor.Orders.Count, 1);
            Assert.AreEqual(vendor.Orders[0], order);
        }

        [TestMethod()]
        public void TestOrderPriceValidation()
        {
            
            string title = "Test Order";
            string description = "Test description";
            decimal validPrice = 10.50m;
            decimal invalidPrice = -5.00m; 
            DateTime date = DateTime.Now;

            Order validOrder = new Order(title, description, validPrice, date);
            Order invalidOrder = new Order(title, description, invalidPrice, date);

            Assert.IsTrue(validOrder.Price >= 0, "Valid order has invalid price");
            Assert.IsFalse(invalidOrder.Price >= 0, "Invalid order has valid price");
        }

        [TestMethod]
        public void TestOrderTitleProperty()
        {
            
            string title = "Test Order";
            string description = "Test description";
            decimal price = 10.50m;
            DateTime date = DateTime.Now;
            Order order = new Order(title, description, price, date);

            
            string newTitle = "New Title";
            order.Title = newTitle;

            
            Assert.AreEqual(order.Title, newTitle);
        }

 

    }
}