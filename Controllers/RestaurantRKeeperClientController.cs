using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {

        [HttpGet("information-about-dishes")]
        public string InformationAboutDishes(string str)
        {
            return str; // Метод получения информации о блюдах
        }

        [HttpPost("ordering-dishes")]
        public string OrderingDishes(string str)
        {
            return str; // Метод заказа блюд
        }
       
        [HttpPost("pay-bill")]
        public string PayBill(string str)
        {
            return str; // Метод оплаты счета
        }

        [HttpPost("leaving-review")]
        public string LeavingReview (string str)
        {
            return str; // Метод оценивания обслуживания и блюд
        }
    }
}

