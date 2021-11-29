namespace mypracticework.Domain
{
   public class Bill
    {
        public int BillId { get; set; }
        public int Order { get; set; }
        public string PaymentMethod { get; set; }
        public decimal OrderCost { get; set; }
        public int Status { get; set; }
    }
}
