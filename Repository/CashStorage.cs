using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class CashStorage
    {
        private Dictionary<int, Cash> Cashes { get; } = new();

        public void Create(Cash cash)
        {
            Cashes.Add(cash.CashId, cash);
        }

        public Cash Read(int cashId)
        {
            return Cashes[cashId];
        }

        public Cash Update(int cashId, Cash newCash)
        {
            Cashes[cashId] = newCash;
            return Cashes[cashId];
        }

        public bool Delete(int cashId)
        {
            return Cashes.Remove(cashId);
        }
    }
}