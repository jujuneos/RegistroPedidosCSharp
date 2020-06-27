using System;
using System.Collections.Generic;
using System.Text;
using Projeto3.Entities.Enums;

namespace Projeto3.Entities
{
    class Order{

        public DateTime moment = DateTime.Now;
        public OrderStatus status { get; set; }
        public Client client { get; set; }
        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime Moment, OrderStatus Status, Client client1)
        {
            moment = Moment;
            status = Status;
            client = client1;
        }

        public void addItem (OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double sum = 0;
            foreach(OrderItem i in items)
            {
                sum += i.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + moment);
            sb.AppendLine("Order Status: " + status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items:");
            foreach(OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2"));
            return sb.ToString();
        }

    }
}