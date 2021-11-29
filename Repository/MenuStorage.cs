using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class Menu
    {
        public class MenuStorage
        {
            private Dictionary<int, Menu> Menues { get; } = new Dictionary<int, Menu>();

            public void Create(Menu menu)
            {
                Menues.Add(menu.MenuId, menu);
            }

            public Menu Read(int menuId)
            {
                return Menues[menuId];
            }

            public Menu Update(int menuId, Menu newMenu)
            {
                Menues[menuId] = newMenu;
                return Menues[menuId];
            }

            public bool Delete(int menuId)
            {
                return Menues.Remove(menuId);
            }

        }
    }
}







