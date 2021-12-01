using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Products")]
    public class ProductsController : ControllerBase
    {
        [HttpPut]
        public Products Create(Products products)
        {
            Storage.ProductsStorage.Create(products);
            return products;
        }

        [HttpGet]
        public Products Read(int productsId)
        {
            return Storage.ProductsStorage.Read(productsId);
        }

        [HttpPost]
        public Products Update(int productsId, Products newProducts)
        {
            return Storage.ProductsStorage.Update(productsId, newProducts);
        }

        [HttpDelete]
        public bool Delete(int productsId)
        {
            return Storage.ProductsStorage.Delete(productsId);
        }

    }
