using System;

namespace mypracticework.Domain
{
   public class Ingridient
    {
        public int IngridientId { get; set; }
        public int Calorie { get; set; }
        public DateTime ShelfLife { get; set; }
        public int Menu { get; set; }
    }
}
