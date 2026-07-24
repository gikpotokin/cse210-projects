using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

            // INSTRUCTIONS/NOTES:
            //
            // This program demonstrates the principle of encapsulation by using separate
            // classes to represent products, customers, addresses, and orders.
            //
            // - Program.cs creates customers, addresses, products, and orders, then
            //   displays the packing labels, shipping labels, and total prices.
            // - Product.cs stores product information and calculates the total cost
            //   based on the product price and quantity.
            // - Customer.cs stores the customer's name and address and determines
            //   whether the customer lives in the USA.
            // - Address.cs stores the customer's street, city, state/province, and
            //   country and provides methods to check the country and format the address.
            // - Order.cs manages the list of products and customer, calculates the
            //   total order cost including shipping, and generates packing and
            //   shipping labels.
            //
            // All member variables are private, and public methods are used to access
            // and work with the data. The program creates at least two orders with
            // multiple products and displays the results without requiring user interaction.
            //
            // Author: Godswill Moses Ikpotokin
            // CEO & Software Developer, Applinet Technology
            // Student, BYU-Pathway Worldwide



            Address address1 = new Address(
                "123 Main Street",
                "Seattle",
                "Washington",
                "USA"
            );

            Customer customer1 = new Customer(
                "John Smith",
                address1
            );

            Order order1 = new Order(customer1);

            Product product1 = new Product(
                "Laptop",
                "LAP001",
                800.00m,
                1
            );

            Product product2 = new Product(
                "Wireless Mouse",
                "MOU001",
                25.00m,
                2
            );

            Product product3 = new Product(
                "Keyboard",
                "KEY001",
                50.00m,
                1
            );

            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);


            Console.WriteLine("__________________________________________");
            Console.WriteLine("              ORDER 1");
            Console.WriteLine("__________________________________________");
            Console.WriteLine();

            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine(order1.GetShippingLabel());

            Console.WriteLine(
                $"TOTAL PRICE: ${order1.GetTotalCost():F2}"
            );

            Console.WriteLine();



            Address address2 = new Address(
                "15 Allen Avenue",
                "Lagos",
                "Lagos State",
                "Nigeria"
            );

            Customer customer2 = new Customer(
                "Mary Johnson",
                address2
            );

            Order order2 = new Order(customer2);

            Product product4 = new Product(
                "Smartphone",
                "PHN001",
                500.00m,
                1
            );

            Product product5 = new Product(
                "Phone Case",
                "CAS001",
                20.00m,
                2
            );

            Product product6 = new Product(
                "Power Bank",
                "PWB001",
                40.00m,
                1
            );

            order2.AddProduct(product4);
            order2.AddProduct(product5);
            order2.AddProduct(product6);



            Console.WriteLine("__________________________________________");
            Console.WriteLine("              ORDER 2");
            Console.WriteLine("__________________________________________");
            Console.WriteLine();

            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine(order2.GetShippingLabel());

            Console.WriteLine(
                $"TOTAL PRICE: ${order2.GetTotalCost():F2}"
            );

            Console.WriteLine();

            Console.WriteLine("__________________________________________");
            Console.WriteLine("          END OF ORDER PROCESSING");
            Console.WriteLine("__________________________________________");
        }
    }
}