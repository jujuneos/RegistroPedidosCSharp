using System;

namespace Projeto3.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int Quantity, double Price, Product prod)
        {
            quantity = Quantity;
            price = Price;
            product = prod;
        }

        public double subTotal()
        {
            return price * quantity;
        }

        public override string ToString()
        {
            return product.name
                + ", $"
                + price.ToString("F2")
                + ", Quantity: "
                + quantity
                + ", Subtotal: $"
                + subTotal().ToString("F2");
        }
    }
}