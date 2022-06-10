using System;
namespace Model
{
    public class SalesListing
    {
        public int orderId { get; set; }
        public DateTime orderDate { get; set; }
        public string customer { get; set; }
        public string product { get; set; }
        public double totalAmount { get; set; }
    }
}