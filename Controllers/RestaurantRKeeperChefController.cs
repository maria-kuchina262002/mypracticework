using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Chef")]
    public class ClientController : ControllerBase
    {
        [HttpGet("TakingOrder")]
        public string TakingOrder(string str)
        {
            return str; // Метод принятия заказа
        }

        [HttpGet("Cooking")]
        public string Cooking(string str)
        {
            return str; // Метод приготовления заказа
        }

        [HttpPost("MenuCompilation")]
        public string MenuCompilation(string str)
        {
            return str; // Метод составления меню
        }

        [HttpPost("CompilationMissingProducts")]
        public string CompilationMissingProducts(string str)
        {
            return str; // Метод формирования списка недостающих продуктов
        }
    }
}
