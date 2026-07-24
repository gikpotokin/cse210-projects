using System.Collections.Generic;
using System.Text;

namespace OnlineOrdering
{
    public class Order
    {
        // Private member variables
        private List<Product> _products;
        private Customer _customer;

        // Constructor
        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        // Add a product to the order
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Calculate the total cost of the order
        public decimal GetTotalCost()
        {
            decimal total = 0;

            // Add the cost of each product
            foreach (Product product in _products)
            {
                total += product.GetTotalCost();
            }

            // Add shipping cost
            if (_customer.IsInUSA())
            {
                total += 5;
            }
            else
            {
                total += 35;
            }

            return total;
        }

        // Create a packing label
        public string GetPackingLabel()
        {
            StringBuilder label = new StringBuilder();

            label.AppendLine("PACKING LABEL");
            label.AppendLine("------------------------------");

            foreach (Product product in _products)
            {
                label.AppendLine($"Product: {product.GetName()}");
                label.AppendLine($"Product ID: {product.GetProductId()}");
                label.AppendLine();
            }

            return label.ToString();
        }

        // Create a shipping label
        public string GetShippingLabel()
        {
            StringBuilder label = new StringBuilder();

            label.AppendLine("SHIPPING LABEL");
            label.AppendLine("------------------------------");
            label.AppendLine($"Customer: {_customer.GetName()}");
            label.AppendLine(_customer.GetAddress().GetFullAddress());

            return label.ToString();
        }
    }
}