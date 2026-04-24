using System;
using OrderNotificationSystem.Models;

namespace OrderNotificationSystem.Services
{
    public class OrderService
    {
        public delegate void OrderPlacedEventHandler(Order order1);
        public event OrderPlacedEventHandler OrderDone;

        public void PlaceOrder(Order order)
        {
            Console.WriteLine("Order placed successfully");

            OrderDone?.Invoke(order);

        }
    }
}