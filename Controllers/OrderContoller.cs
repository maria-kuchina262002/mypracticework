using Microsoft.AspNetCore.Mvc;
using mypracticework.Domain;
using mypracticework.Repository;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Order")]
    public class OrderController : ControllerBase
    {
        [HttpPut]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return order;
        }

        [HttpGet]
        public Order Read(int orderId)
        {
            return Storage.OrderStorage.Read(orderId);
        }

        [HttpPost]
        public Order Update(int orderId, Order newOrder)
        {
            return Storage.OrderStorage.Update(orderId, newOrder);
        }

        [HttpDelete]
        public bool Delete(int orderId)
        {
            return Storage.OrderStorage.Delete(orderId);
        }

    }
