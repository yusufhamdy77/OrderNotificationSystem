using System;
using System.Collections.Generic;
using System.Linq;
namespace OrderNotificationSystem.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
}