using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {

        [HttpGet("InformationAboutDishes")]
        public string InformationAboutDishes(string str)
        {
            return str; // Метод получения информации о блюдах
        }

        [HttpGet("OrderingDishes")]
        public string OrderingDishes(string str)
        {
            return str; // Метод заказа блюд
        }
       
        [HttpGet("PayBill")]
        public string PayBill(string str)
        {
            return str; // Метод оплаты счета
        }

        [HttpGet("LeavingReview")]
        public string LeavingReview (string str)
        {
            return str; // Метод оценивания обслуживания и блюд
        }
    }
}

