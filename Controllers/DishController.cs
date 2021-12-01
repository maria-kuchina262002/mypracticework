using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Dish")]
    public class DishController : ControllerBase
    {
        [HttpPut]
        public Dish Create(Dish dish)
        {
            Storage.DishStorage.Create(dish);
            return dish;
        }

        [HttpGet]
        public Dish Read(int dishId)
        {
            return Storage.DishStorage.Read(dishId);
        }

        [HttpPost]
        public Dish Update(int dishId, Dish newDish)
        {
            return Storage.DishStorage.Update(dishId, newDish);
        }

        [HttpDelete]
        public bool Delete(int dishId)
        {
            return Storage.DishStorage.Delete(dishId);
        }
    }

}
