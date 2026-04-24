using OrderNotificationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderNotificationSystem
{
    public static class OrderExtentionMethod
    {
        public static string FormatOrderMessage(this Order order)
        {
            return $"Order #{order.Id} - {order.ProductName} - Price: {order.Price}";
        }

    }
}
