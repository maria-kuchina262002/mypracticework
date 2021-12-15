using mypracticework.Domain;
using System.Collections.Generic;

namespace mypracticework.Repository
{
        public class OrderStorage
        {
            private Dictionary<int, Order> Orders { get; } = new();

            public void Create(Order order)
            {
                Orders.Add(order.OrderId, order);
            }

            public Order Read(int orderId)
            {
                return Orders[orderId];
            }

            public Order Update(int orderId, Order newOrder)
            {
                Orders[orderId] = newOrder;
                return Orders[orderId];
            }

            public bool Delete(int orderId)
            {
                return Orders.Remove(orderId);
            }

        }
}
