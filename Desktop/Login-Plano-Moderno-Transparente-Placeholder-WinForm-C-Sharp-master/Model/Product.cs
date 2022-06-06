namespace Model
{
    public class Product
    {
        private int id;
        private string productName;
        private int supplierId;
        private decimal unitPrice;
        private string package;
        private int stock;
        private bool isDiscontinued;

        public bool IsDiscontinued
        {
            get { return isDiscontinued; }
            set { isDiscontinued = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Package
        {
            get { return package; }
            set { package = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int SupplierId
        {
            get { return supplierId; }
            set { supplierId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
