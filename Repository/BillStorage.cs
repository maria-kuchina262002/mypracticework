using System.Collections.Generic;
using mypracticework.Domain;

namespace mypracticework.Repository
{
    public class BillStorage
    {
        private Dictionary<int, Bill> Bills { get; } = new();

        public void Create(Bill bill)
        {
            Bills.Add(bill.BillId, bill);
        }

        public Bill Read(int billId)
        {
            return Bills[billId];
        }

        public Bill Update(int billId, Bill newBill)
        {
            Bills[billId] = newBill;
            return Bills[billId];
        }

        public bool Delete(int billId)
        {
            return Bills.Remove(billId);
        }
    }
}