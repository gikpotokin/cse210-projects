namespace OnlineOrdering
{
    public class Address
    {
        // Private member variables
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        // Constructor
        public Address(
            string street,
            string city,
            string state,
            string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        // Determine whether the address is in the USA
        public bool IsInUSA()
        {
            return _country.ToLower() == "usa" ||
                   _country.ToLower() == "united states" ||
                   _country.ToLower() == "united states of america";
        }

        // Return the complete address
        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_state}\n{_country}";
        }
    }
}