using System;
using Projeto3.Entities;
using Projeto3.Entities.Enums;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {            
            System.Console.WriteLine("Enter client data:");
            System.Console.Write("Name: ");
            string clientName = Console.ReadLine();
            System.Console.Write("Email: ");
            string clientMail = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter order data:");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientMail, clientBirth);
            Order order = new Order(DateTime.Now, status, client);

            System.Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                System.Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.addItem(orderItem);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("ORDER SUMMARY: ");
            System.Console.WriteLine(order);
        }
    }
}
