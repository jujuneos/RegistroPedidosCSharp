using System;

namespace Projeto3.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {      
        }

        public Product(string Name, double Price)
        {
            name = Name;
            price = Price;
        }
    }
}