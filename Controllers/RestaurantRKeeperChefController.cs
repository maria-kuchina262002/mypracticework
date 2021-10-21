using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/chef")]
    public class ClientController : ControllerBase
    {

        [HttpGet("taking-order")]
        public string InformationAboutDishes(string str)
        {
            return str; // Метод принятия заказа
        }

        [HttpGet("cooking")]
        public string OrderingDishes(string str)
        {
            return str; // Метод приготовления заказа
        }

        [HttpPost("menu-compilation")]
        public string PayBill(string str)
        {
            return str; // Метод составления меню
        }

        [HttpPost("compilation-missing-products")]
        public string LeavingReview(string str)
        {
            return str; // Метод формирования списка недостающих продуктов
        }
    }
}
