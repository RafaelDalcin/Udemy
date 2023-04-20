using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Projeto1.Entities.Enums;
using System.Text;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Projeto1.Entities
{
    public class Order
    {
        public OrderStatus Status { get; set; }
        public DateTime Moment { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public Order() { 
        
        }

        public Order(OrderStatus status, DateTime moment, Client client)
        {
            Status = status;
            Moment = moment;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add (item);
        }
        public void RemoveItem (OrderItem item)
        {
            Items.Remove (item);
        }

        public double Total ()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            foreach (OrderItem item in Items) 
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("TOTAL PRICE: $ " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
      
    }

}
