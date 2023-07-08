using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        Console.Clear();
        Console.WriteLine("ONLINE ORDERING\n");

        List<Order> orderList = new List<Order>();

        // I know it's not necessary to add a user interface but I added them in the programs for practice.
        // Also, my program uses "," as the "." in the float numbers for the price. Use "," if "." doesn't work.
        
        Console.Write("How many orders are you going to create? ");
        int numberOfOrders = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfOrders; i++)
        {
            Order order = new Order();
            Console.WriteLine($"\nOrder {i}\n");

            // New Customer.
            Console.Write("Name of the customer: ");
            string customerName = Console.ReadLine();
            Customer customer = new Customer(customerName);
            
            // New Address.
            Console.Write("Street: ");
            string street = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State/Province: ");
            string stateProvince = Console.ReadLine();
            Console.Write("Country (USA, others): ");
            string country = Console.ReadLine();
            Address address = new Address(street, city, stateProvince, country);

            customer.SetCustomerAddress(address);
            order.SetOrderCustomer(customer);

            Console.Write("\nHow many products are you adding in this order? ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int j = 1; j <= numberOfProducts; j++)
            {
                // New Product.
                Console.Write($"\nProduct {j}\nName: ");
                string name = Console.ReadLine();
                Console.Write("ID: ");
                string id = Console.ReadLine();
                Console.Write("Price: ");
                float price = float.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                order.AddOrderProduct(name, id, price, quantity);
            }

            orderList.Add(order);
        }

        // Console.Clear();
        Console.WriteLine("\n\n# Order list:");
        foreach (Order order in orderList)
        {
            Console.WriteLine($"\nTotal cost: ${order.CalculateCost()}\nShipping lavel: \n{order.ShippingLavel()}\nPacking lavel:");
            foreach (string product in order.PackingLavel())
            {
                Console.WriteLine(product);
            }
        }
    }
}