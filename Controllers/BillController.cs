using Microsoft.AspNetCore.Mvc;
using mypracticework.Domain;
using mypracticework.Repository;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Bill")]
    public class BillController : ControllerBase
    {
        [HttpPut]
        public Bill Create(Bill bill)
        {
            Storage.BillStorage.Create(bill);
            return bill;
        }

        [HttpGet]
        public Bill Read(int billId)
        {
            return Storage.BillStorage.Read(billId);
        }

        [HttpPost]
        public Bill Update(int billId, Bill newBill)
        {
            return Storage.BillStorage.Update(billId, newBill);
        }

        [HttpDelete]
        public bool Delete(int billId)
        {
            return Storage.BillStorage.Delete(billId);
        }
    }

}
