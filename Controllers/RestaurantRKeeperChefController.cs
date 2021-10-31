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

        [HttpGet("TakingOrder")]
        public string InformationAboutDishes(string str)
        {
            return str; // Метод принятия заказа
        }

        [HttpGet("Cooking")]
        public string OrderingDishes(string str)
        {
            return str; // Метод приготовления заказа
        }

        [HttpPost("MenuCompilation")]
        public string PayBill(string str)
        {
            return str; // Метод составления меню
        }

        [HttpPost("CompilationMissingProducts")]
        public string LeavingReview(string str)
        {
            return str; // Метод формирования списка недостающих продуктов
        }
    }
}