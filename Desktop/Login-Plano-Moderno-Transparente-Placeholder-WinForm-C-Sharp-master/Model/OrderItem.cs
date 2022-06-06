namespace Model
{
    public class OrderItem
    {
        private int id;
        private int orderId;
        private int productId;
        private decimal unitPrice;
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
