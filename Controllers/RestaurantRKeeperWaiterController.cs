using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/waiter")]
    public class WaiterController : ControllerBase
    {

        [HttpGet("taking-order")]
        public string TakingOrder (string str)
        {
            return str; // Метод формирования заказа
        }

        [HttpGet("opening-bill")]
        public string OpeningBill (string str)
        {
            return str; // Метод открытия счета
        }
       
        [HttpPost("transfer-order")]
        public string TransferOrder(string str)
        {
            return str; // Метод передачи заказа на кухню
        }

        [HttpPost("cancellation-dishes")]
        public string CancellationDishes(string str)
        {
            return str; // Метод отмены позиций из заказа
        }

        [HttpGet("customer-service")]
        public string CustomerService(string str)
        {
            return str; // Метод обслуживания клиента в порядке электронной очереди
        }
    }
}

