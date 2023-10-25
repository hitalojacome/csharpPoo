using System;
using Exercício03.Entities;
using Exercício03.Entities.Enums;

namespace Workspace {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(clientName, clientEmail, clientBirth);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Order order = new Order(DateTime.Now, orderStatus, client);
            
            for(int i = 1; i <=n; i++) {               
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.OrderItems.Add(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine(order);
        }
    }
}