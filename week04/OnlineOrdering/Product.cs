namespace OnlineOrdering
{
    public class Product
    {
        // Private member variables
        private string _name;
        private string _productId;
        private decimal _price;
        private int _quantity;

        // Constructor
        public Product(string name, string productId, decimal price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        // Getters
        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        // Calculate the total cost of the product
        public decimal GetTotalCost()
        {
            return _price * _quantity;
        }
    }
}