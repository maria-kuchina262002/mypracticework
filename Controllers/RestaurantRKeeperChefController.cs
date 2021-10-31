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

<<<<<<< HEAD
        [HttpGet("TakingOrder")]
        public string TakingOrder(string str)
=======
        [HttpGet("taking-order")]
        public string InformationAboutDishes(string str)
>>>>>>> 402e5371e6c2a9e05ef4b32cd4265a55869943e7
        {
            return str; // Метод принятия заказа
        }

<<<<<<< HEAD
        [HttpGet("Cooking")]
        public string Cooking(string str)
=======
        [HttpGet("cooking")]
        public string OrderingDishes(string str)
>>>>>>> 402e5371e6c2a9e05ef4b32cd4265a55869943e7
        {
            return str; // Метод приготовления заказа
        }

<<<<<<< HEAD
        [HttpPost("MenuCompilation")]
        public string MenuCompilation(string str)
=======
        [HttpPost("menu-compilation")]
        public string PayBill(string str)
>>>>>>> 402e5371e6c2a9e05ef4b32cd4265a55869943e7
        {
            return str; // Метод составления меню
        }

<<<<<<< HEAD
        [HttpPost("CompilationMissingProducts")]
        public string CompilationMissingProducts(string str)
=======
        [HttpPost("compilation-missing-products")]
        public string LeavingReview(string str)
>>>>>>> 402e5371e6c2a9e05ef4b32cd4265a55869943e7
        {
            return str; // Метод формирования списка недостающих продуктов
        }
    }
}
