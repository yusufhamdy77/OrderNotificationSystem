using System;
using OrderNotificationSystem.Models;

namespace OrderNotificationSystem.Services
{
    public class SMSService
    {
        public void SendSMS(Order order)
        {
            Console.WriteLine($"SMS sent: {order.FormatOrderMessage()}");
        }
    }
}