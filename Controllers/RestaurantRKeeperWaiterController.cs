using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Waiter")]
    public class WaiterController : ControllerBase
    {

        [HttpGet("TakingOrder")]
        public string TakingOrder (string str)
        {
            return str; // Метод формирования заказа
        }

        [HttpGet("OpeningBill")]
        public string OpeningBill (string str)
        {
            return str; // Метод открытия счета
        }
       
        [HttpGet("TransferOrder")]
        public string TransferOrder(string str)
        {
            return str; // Метод передачи заказа на кухню
        }

        [HttpGet("CancellationDishes")]
        public string CancellationDishes(string str)
        {
            return str; // Метод отмены позиций из заказа
        }

        [HttpGet("CustomerService")]
        public string CustomerService(string str)
        {
            return str; // Метод обслуживания клиента в порядке электронной очереди
        }
    }
}

