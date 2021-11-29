using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class Bill
    {
        public class BillStorage
        {
            private Dictionary<int, Bill> Bills { get; } = new Dictionary<int, Bill>();

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
}