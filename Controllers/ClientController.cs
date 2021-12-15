using Microsoft.AspNetCore.Mvc;
using mypracticework.Domain;
using mypracticework.Repository;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {
        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);
        }

        [HttpPost]
        public Client Update(int clientId, Client newClient)
        {
            return Storage.ClientStorage.Update(clientId, newClient);
        }

        [HttpDelete]
        public bool Delete(int clientId)
        {
            return Storage.ClientStorage.Delete(clientId);
        }

        [HttpGet("InformationAboutDishes")]
        public string InformationAboutDishes(string str)
        {
            return str; // Метод получения информации о блюдах
        }

        [HttpPost("OrderingDishes")]
        public string OrderingDishes(string str)
        {
            return str; // Метод заказа блюд
        }

        [HttpPost("PayBill")]
        public string PayBill(string str)
        {
            return str; // Метод оплаты счета
        }

        [HttpPost("LeavingReview")]
        public string LeavingReview(string str)
        {
            return str; // Метод оценивания обслуживания и блюд
        }
    }
}