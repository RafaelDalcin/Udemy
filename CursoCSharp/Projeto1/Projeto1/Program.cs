using Projeto1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto1.Entities.Enums;

namespace Projeto1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: "); 
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY)");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthday);
            Order order = new Order(status, DateTime.Now, client);
     

            Console.Write("How many items for this order?");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");

                Product product = new Product(productName, productPrice);

                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY");
            Console.WriteLine(order);









        }

    }
}
