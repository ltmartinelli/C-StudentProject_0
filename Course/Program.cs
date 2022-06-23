using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities.Enums;
using Course.Entities;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {


            //Client Data Input
            Console.WriteLine("Enter Client Data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Order Data Input

            Console.WriteLine("Enter order data:");

            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int numberOfItemsInOrder = int.Parse(Console.ReadLine());

            //NInstantiate Client, Order, then read items

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 0; i < numberOfItemsInOrder; i++)
            {
                Console.WriteLine($"Enter #{i + 1} Item Data:");

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();


                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine());


                Console.Write("Product Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);


            }

            Console.WriteLine();
            Console.WriteLine("Order Summary: ");
            Console.WriteLine(order.ToString());








        }
    }
}