namespace PierresBakery.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        public Order(int OrderId, string title, string description, decimal price, DateTime date)
        {
            this.OrderId = OrderId;
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.Date= date;
            
        }
    }
}
