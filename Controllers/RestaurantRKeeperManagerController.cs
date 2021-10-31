using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Manager")]
    public class ManagerController : ControllerBase
    {
        [HttpPost("StaffList")]
        public string StaffList(string str)
        {
            return str; // Метод формирования списка персонала на текущую смену
        }

        [HttpPost("ProductAccounting")]
        public string ProductAccounting(string str)
        {
            return str; // Метод учета недостающей продукции
        }

        [HttpPost("CalculatingProfit")]
        public string CalculatingProfit(string str)
        {
            return str; // Метод подсчета прибыли за текущую смену
        }
    }
}