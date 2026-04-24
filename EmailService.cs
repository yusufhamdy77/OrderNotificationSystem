using System;
using OrderNotificationSystem.Models;

namespace OrderNotificationSystem.Services
{
    public class EmailService
    {
        public void SendEmail(Order order)
        {
            Console.WriteLine($"Email sent: {order.FormatOrderMessage()}");
        }
    }
}