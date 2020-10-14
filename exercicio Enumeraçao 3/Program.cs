using System;
using exercicio_Enumeraçao_3.Entities;
using exercicio_Enumeraçao_3.Enums;

namespace exercicio_Enumeraçao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i < N; i++)
            {
                Console.WriteLine("Enter #" + N + " item data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(name, price);
                OrderItem order = new OrderItem(quantity, price);
            }


        }
    }
}
