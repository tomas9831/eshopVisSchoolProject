using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class SingleOrderModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PaymentType { get; set; }
        public string Adress { get; set; }
        public string DeliveryType { get; set; }
        public double Price { get; set; }
    }
}
