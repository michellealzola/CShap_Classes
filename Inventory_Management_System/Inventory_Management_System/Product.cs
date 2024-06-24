using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
    public class Product
    {
        public Product (string productId, string name, decimal price, int quantity)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string ProductId { get; set; }
        public string Name { get; set; }        
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
