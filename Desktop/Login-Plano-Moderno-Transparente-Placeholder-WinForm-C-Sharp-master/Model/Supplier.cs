namespace Model
{
    public class Supplier
    {
        private int id;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string city;
        private string country;
        private string phone;
        private string fax;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string ContactTitle
        {
            get { return contactTitle; }
            set { contactTitle = value; }
        }

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
