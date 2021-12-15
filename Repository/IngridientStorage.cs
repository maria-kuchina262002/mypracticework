using mypracticework.Domain;
using System.Collections.Generic;

namespace mypracticework.Repository
{
        public class IngridientStorage
        {
            private Dictionary<int, Ingridient> Ingridients { get; } = new();

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
