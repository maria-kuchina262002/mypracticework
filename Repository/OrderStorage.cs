using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class Order
    {
        public class OrderStorage
        {
            private Dictionary<int, Order> Orders { get; } = new Dictionary<int, Order>();

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
}
