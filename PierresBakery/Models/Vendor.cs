namespace PierresBakery.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int VendorId { get; set; }
        public List<Order> Orders { get; set; }

        public Vendor(int VendorId, string name, string description)
        {
            this.VendorId = VendorId;
            this.Name = name;
            this.Description = description;
            this.Orders = new List<Order>();
        }
    }
}
