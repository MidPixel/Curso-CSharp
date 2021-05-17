using System;
using Proj001___Enum.Entities;
using Proj001___Enum.Entities.Enums; //Apontando a Classe Enum

namespace Enum.Proj001___Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamando o Status Criado no Enum com "Status = OrderStatus.PendingPayment"
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter Enum para String

            string texto01 = OrderStatus.PendingPayment.ToString();

            //Converter String para Enum

            OrderStatus order01 = Enum.Parse<OrderStatus>("Delivered");

            }
    }
}
