using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Menu")]
    public class MenuController : ControllerBase
    {
        [HttpPut]
        public Menu Create(Menu menu)
        {
            Storage.MenuStorage.Create(menu);
            return menu;
        }

        [HttpGet]
        public Menu Read(int menuId)
        {
            return Storage.MenuStorage.Read(menuId);
        }

        [HttpPost]
        public Menu Update(int menuId, Menu newMenu)
        {
            return Storage.MenuStorage.Update(menuId, newMenu);
        }

        [HttpDelete]
        public bool Delete(int menuId)
        {
            return Storage.MenuStorage.Delete(menuId);
        }

    }
