using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningListofObjects
{
    internal class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }

        public decimal Price { get; private set; }

        public void SetProductId(int productId)
        {
            this.ProductId = productId;
        }

        public void SetProductName(string productName)
        {
            this.ProductName = productName;
        }

        public void SetPrice(decimal price)
        {
            this.Price = price;
        }
        
    }
}
