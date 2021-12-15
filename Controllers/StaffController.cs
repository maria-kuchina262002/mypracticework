using Microsoft.AspNetCore.Mvc;
using mypracticework.Domain;
using mypracticework.Repository;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Staff")]
    public class StaffController : ControllerBase
    {
        [HttpPut]
        public Staff Create(Staff staff)
        {
            Storage.StaffStorage.Create(staff);
            return staff;
        }

        [HttpGet]
        public Staff Read(int staffId)
        {
            return Storage.StaffStorage.Read(staffId);
        }

        [HttpPost]
        public Staff Update(int staffId, Staff newStaff)
        {
            return Storage.StaffStorage.Update(staffId, newStaff);
        }

        [HttpDelete]
        public bool Delete(int staffId)
        {
            return Storage.StaffStorage.Delete(staffId);
        }

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
        [HttpGet("TakingOrder")]
        public string TakingOrder(string str)
        {
            return str; // Метод формирования заказа
        }

        [HttpGet("OpeningBill")]
        public string OpeningBill(string str)
        {
            return str; // Метод открытия счета
        }

        [HttpPost("TransferOrder")]
        public string TransferOrder(string str)
        {
            return str; // Метод передачи заказа на кухню
        }

        [HttpPost("CancellationDishes")]
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
