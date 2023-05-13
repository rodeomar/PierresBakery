namespace PierresBakery.Models
{
    public class Order
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public Order(string title, string description, decimal price, DateTime date)
        {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
        }
    }
}
