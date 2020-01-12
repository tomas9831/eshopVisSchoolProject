using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class ProductOrderModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
