using System;

namespace SmartOrderAPI.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending"; // Pending, Confirmed, Shipped, Completed, Canceled
        public decimal TotalAmount { get; set; }
    }
}
