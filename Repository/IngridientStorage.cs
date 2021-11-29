using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class Ingridient
    {
        public class IngridientStorage
        {
            private Dictionary<int, Ingridient> Ingridients { get; } = new Dictionary<int, Ingridient>();

            public void Create(Ingridient ingridient)
            {
                Ingridients.Add(ingridient.IngridientId, ingridient);
            }

            public Ingridient Read(int ingridientId)
            {
                return Ingridients[ingridientId];
            }

            public Ingridient Update(int ingridientId, Ingridient newIngridient)
            {
                Ingridients[ingridientId] = newIngridient;
                return Ingridients[ingridientId];
            }

            public bool Delete(int ingridientId)
            {
                return Ingridients.Remove(ingridientId);
            }

        }
    }
}
