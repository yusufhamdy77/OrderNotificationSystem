using OrderNotificationSystem.Models;
using OrderNotificationSystem.Services;
using System;


namespace OrderNotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();

            var emailService = new EmailService();
            var smsService = new SMSService();

            orderService.OrderDone += emailService.SendEmail;
            orderService.OrderDone += smsService.SendSMS;

            var order = new Order
            {
                Id = 1,
                ProductName = "Laptop",
                Price = 15000
            };

            orderService.PlaceOrder(order);
        }
    }
}