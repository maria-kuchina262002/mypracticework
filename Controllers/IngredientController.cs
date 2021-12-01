using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Ingredient")]
    public class IngredientController : ControllerBase
    {
        [HttpPut]
        public Ingredient Create(Ingredient ingredient)
        {
            Storage.IngredientStorage.Create(ingredient);
            return ingredient;
        }

        [HttpGet]
        public Ingredient Read(int ingredientId)
        {
            return Storage.IngredientStorage.Read(ingredientId);
        }

        [HttpPost]
        public Ingredient Update(int ingredientId, Ingredient newIngredient)
        {
            return Storage.IngredientStorage.Update(ingredientId, newIngredient);
        }

        [HttpDelete]
        public bool Delete(int ingredientId)
        {
            return Storage.IngredientStorage.Delete(ingredientId);
        }

    }
