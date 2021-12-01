using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Cash")]
    public class CashController : ControllerBase
    {
        [HttpPut]
        public Cash Create(Cash cash)
        {
            Storage.CashStorage.Create(cash);
            return cash;
        }

        [HttpGet]
        public Cash Read(int cashId)
        {
            return Storage.CashStorage.Read(cashId);
        }

        [HttpPost]
        public Cash Update(int cashId, Cash newCash)
        {
            return Storage.CashStorage.Update(cashId, newCash);
        }

        [HttpDelete]
        public bool Delete(int cashId)
        {
            return Storage.CashStorage.Delete(cashId);
        }

    }
}