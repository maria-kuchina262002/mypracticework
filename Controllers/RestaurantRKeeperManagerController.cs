using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/manager")]
    public class ManagerController : ControllerBase
    {

        [HttpPost("staff-list")]
        public string StaffList(string str)
        {
            return str; // Метод формирования списка персонала на текущую смену
        }

        [HttpPost("product-accounting")]
        public string ProductAccounting(string str)
        {
            return str; // Метод учета недостающей продукции
        }
       
        [HttpPost("calculating-profit")]
        public string CalculatingProfit(string str)
        {
            return str; // Метод подсчета прибыли за текущую смену
        }

       
    }
}

