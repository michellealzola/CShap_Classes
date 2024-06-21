using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    internal class Product
    {
        private int _productId;
        private string _name;
        private decimal _price;
        private int _stock;

        public Product()
        {
            _productId = 0;
            _name = string.Empty;
            _price = 0;
            _stock = 0;
        }

        public int ProductId { get { return _productId; } set { _productId = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }
        public int Stock { get { return _stock; } set { _stock = value; } }

    }
}
