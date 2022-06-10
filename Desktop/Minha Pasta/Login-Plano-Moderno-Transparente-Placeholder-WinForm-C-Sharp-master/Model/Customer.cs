namespace Model
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string city;
        private string country;
        private string phone;

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

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
