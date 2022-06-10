using System;

namespace Model
{
    public class Order
    {
        private int id;
        private DateTime orderDate;
        private DateTime orderNumber;
        private int customerId;
        private decimal totalAmount;

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public DateTime OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
