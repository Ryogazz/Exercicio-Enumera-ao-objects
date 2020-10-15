using System;
using System.Collections.Generic;
using System.Text;
using exercicio_Enumeraçao_3.Enums;
using exercicio_Enumeraçao_3.Entities;
using System.Xml.Schema;

namespace exercicio_Enumeraçao_3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = DateTime.Now;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }


        public double Total;
        public double GetTotal(OrderItem item)
        {
            foreach (OrderItem i in Itens)
            {
                Total += i.SubTotal();
            }
            return Total;
        }

    }
}
