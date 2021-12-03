using mypracticework.Domain;
using System.Collections.Generic;

namespace mypracticework.Repository
{
    public class DishStorage
    {
        private Dictionary<int, Dish> Dishes { get; } = new();

        public void Create(Dish dish)
        {
            Dishes.Add(dish.DishId, dish);
        }

        public Dish Read(int dishId)
        {
            return Dishes[dishId];
        }

        public Dish Update(int dishId, Dish newDish)
        {
            Dishes[dishId] = newDish;
            return Dishes[dishId];
        }

        public bool Delete(int dishId)
        {
            return Dishes.Remove(dishId);
        }
    }
}